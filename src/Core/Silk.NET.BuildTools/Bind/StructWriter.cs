﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using ClangSharp.Interop;
using Humanizer;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Common.Structs;
using Silk.NET.BuildTools.Cpp;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Bind
{
    public static class StructWriter
    {
        /// <summary>
        /// Writes this struct to a file.
        /// </summary>
        /// <param name="struct">The enum to write.</param>
        /// <param name="file">The file to write to.</param>
        /// <param name="profile">The subsystem containing this enum.</param>
        /// <param name="project">The project containing this enum.</param>
        public static void WriteStruct
            (this Struct @struct, string file, Profile profile, Project project, BindState task)
        {
            if (@struct.Attributes.IsBuildToolsIntrinsic(out var args))
            {
                WriteBuildToolsIntrinsic(@struct, file, profile, project, task, args);
                return;
            }

            var sw = new StreamWriter(file) {NewLine = "\n"};
            sw.WriteLine(task.LicenseText());
            sw.WriteLine();
            sw.WriteCoreUsings();
            sw.WriteLine();
            sw.WriteLine("#pragma warning disable 1591");
            sw.WriteLine();
            var ns = project.IsRoot ? task.Task.Namespace : task.Task.ExtensionsNamespace;
            sw.WriteLine($"namespace {ns}{project.Namespace}");
            sw.WriteLine("{");
            string guid = null;
            
            static bool IsChar(Type type) => type.Name == "char" || type.GenericTypes.Any(IsChar);
            var needsCharSetFixup = @struct.Fields.Any(x => IsChar(x.Type));
            
            foreach (var attr in @struct.Attributes)
            {
                if (attr.Name == "BuildToolsIntrinsic")
                {
                    continue;
                }

                if (guid is null && attr.Name == "Guid")
                {
                    guid = string.Join(", ", attr.Arguments);
                }

                if (attr.Name == "StructLayout" && needsCharSetFixup)
                {
                    attr.Arguments.Add("CharSet = CharSet.Unicode");
                    needsCharSetFixup = false;
                }

                sw.WriteLine($"    {attr}");
            }

            if (needsCharSetFixup)
            {
                sw.WriteLine("    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]");
            }

            sw.WriteLine($"    [NativeName(\"Name\", \"{@struct.NativeName}\")]");
            sw.WriteLine($"    public unsafe partial struct {@struct.Name}");
            sw.WriteLine("    {");
            if (guid is not null)
            {
                sw.WriteLine($"        public static readonly Guid Guid = new({guid});");
                sw.WriteLine();
            }

            foreach (var comBase in @struct.ComBases)
            {
                var asSuffix = comBase.Split('.').Last();
                asSuffix = asSuffix.StartsWith('I') ? asSuffix.Substring(1) : comBase;
                asSuffix = asSuffix.StartsWith(task.Task.FunctionPrefix)
                    ? asSuffix.Substring(task.Task.FunctionPrefix.Length)
                    : asSuffix;
                var fromSuffix = @struct.Name.Split('.').Last();
                fromSuffix = fromSuffix.StartsWith('I') ? fromSuffix.Substring(1) : comBase;
                fromSuffix = fromSuffix.StartsWith(task.Task.FunctionPrefix)
                    ? fromSuffix.Substring(task.Task.FunctionPrefix.Length)
                    : fromSuffix;
                sw.WriteLine($"        public static implicit operator {comBase}({@struct.Name} val)");
                sw.WriteLine($"            => Unsafe.As<{@struct.Name}, {comBase}>(ref val);");
                sw.WriteLine();
                if (@struct.Functions.Any(x => x.Signature.Name.Equals("QueryInterface")))
                {
                    sw.WriteLine($"        public static explicit operator {@struct.Name}({comBase} val)");
                    sw.WriteLine($"            => From{fromSuffix}(in val);");
                    sw.WriteLine();
                    sw.WriteLine($"        public readonly ref {comBase} As{asSuffix}()");
                    sw.WriteLine("        {");
                    // yes i know this is unsafe and that there's a good reason why struct members can't return themselves
                    // by reference, but this should work well enough.
                    sw.WriteLine("#if NETSTANDARD2_1 || NET5_0 || NETCOREAPP3_1 || NET5_0_OR_GREATER");
                    sw.WriteLine($"            return ref Unsafe.As<{@struct.Name}, {comBase}>");
                    sw.WriteLine($"            (");
                    sw.WriteLine($"                ref MemoryMarshal.GetReference");
                    sw.WriteLine($"                (");
                    sw.WriteLine($"                    MemoryMarshal.CreateSpan");
                    sw.WriteLine($"                    (");
                    sw.WriteLine($"                        ref Unsafe.AsRef(in this),");
                    sw.WriteLine($"                        1");
                    sw.WriteLine($"                    )");
                    sw.WriteLine($"                )");
                    sw.WriteLine($"            );");
                    sw.WriteLine("#else");
                    sw.WriteLine($"            fixed ({@struct.Name}* @this = &this)");
                    sw.WriteLine($"            {{");
                    sw.WriteLine($"                return ref *({comBase}*) @this;");
                    sw.WriteLine($"            }}");
                    sw.WriteLine("#endif");
                    sw.WriteLine("        }");
                    sw.WriteLine();
                    sw.WriteLine($"        public static ref {@struct.Name} From{fromSuffix}(in {comBase} @this)");
                    sw.WriteLine("        {");
                    sw.WriteLine($"            {@struct.Name}* ret = default;");
                    sw.WriteLine($"            SilkMarshal.ThrowHResult");
                    sw.WriteLine($"            (");
                    sw.WriteLine($"                @this.QueryInterface");
                    sw.WriteLine($"                (");
                    sw.WriteLine($"                    ref SilkMarshal.GuidOf<{@struct.Name}>(),");
                    sw.WriteLine($"                    (void**) &ret");
                    sw.WriteLine($"                )");
                    sw.WriteLine($"            );");
                    sw.WriteLine();
                    sw.WriteLine($"            return ref *ret;");
                    sw.WriteLine("        }");
                    sw.WriteLine();
                }
            }

            if (@struct.Fields.Any(x => x.Count is null))
            {
                sw.WriteLine($"        public {@struct.Name}");
                sw.WriteLine("        (");
                var first = true;
                foreach (var field in @struct.Fields)
                {
                    if (!(field.Count is null) || field.Type.IsByRef || field.Type.IsIn || field.Type.IsOut)
                        continue; // I've chosen not to initialize multi-count fields from ctors.
                    var argName = field.Name[0].ToString().ToLower() + field.Name.Substring(1);
                    argName = Utilities.CSharpKeywords.Contains(argName) ? $"@{argName}" : argName;
                    if (!first)
                    {
                        sw.WriteLine(",");
                    }
                    else
                    {
                        first = false;
                    }

                    var nullable = field.Type.ToString().Contains('*') ? null : "?";
                    sw.Write($"            {field.Type}{nullable} {argName} = {field.DefaultAssignment ?? "null"}");
                }

                sw.WriteLine();
                sw.WriteLine("        ) : this()");
                sw.WriteLine("        {");
                first = true;
                foreach (var field in @struct.Fields)
                {
                    if (!(field.Count is null) || field.Type.IsByRef || field.Type.IsIn || field.Type.IsOut)
                        continue; // I've chosen not to initialize multi-count fields from ctors.
                    var argName = field.Name[0].ToString().ToLower() + field.Name.Substring(1);
                    argName = Utilities.CSharpKeywords.Contains(argName) ? $"@{argName}" : argName;
                    if (!first)
                    {
                        sw.WriteLine();
                    }
                    else
                    {
                        first = false;
                    }

                    sw.WriteLine($"            if ({argName} is not null)");
                    sw.WriteLine("            {");

                    var value = field.Type.ToString().Contains('*') ? null : ".Value";
                    sw.WriteLine($"                {field.Name} = {argName}{value};");
                    sw.WriteLine("            }");
                }

                sw.WriteLine("        }");
                sw.WriteLine();
            }

            var bitfieldIdx = 0;
            long bitfieldPsz = 0, bitfieldRbs = 0;
            string bitfieldLbt = null;
            foreach (var structField in @struct.Fields)
            {
                if (structField.Attributes.IsBuildToolsIntrinsic(out var intrinsic) && intrinsic[0] == "$FUSEFLD")
                {
                    WriteFusedField(@struct, project, structField, intrinsic, sw);
                }
                else if (structField.NumBits is not null)
                {
                    WriteBitfield(structField, ref bitfieldIdx, ref bitfieldPsz, ref bitfieldRbs, ref bitfieldLbt, sw, profile);
                }
                else if (!(structField.Count is null))
                {
                    if (!Field.FixedCapableTypes.Contains(structField.Type.Name))
                    {
                        var count = structField.Count.IsConstant
                            ? int.Parse
                            (
                                profile.Projects.SelectMany(x => x.Value.Classes.SelectMany(y => y.Constants))
                                    .FirstOrDefault(x => x.NativeName == structField.Count.ConstantName)
                                    ?
                                    .Value ?? throw new InvalidDataException("Couldn't find constant referenced")
                            )
                            : structField.Count.IsStatic
                                ? structField.Count.StaticCount
                                : 1;
                        var typeFixup09072020 = new TypeSignatureBuilder(structField.Type).WithIndirectionLevel
                                (structField.Type.IndirectionLevels - 1)
                            .Build();
                        sw.WriteLine($"        {structField.Doc}");
                        foreach (var attr in structField.Attributes)
                        {
                            sw.WriteLine($"        {attr}");
                        }

                        sw.WriteLine($"        [NativeName(\"Type\", \"{structField.NativeType}\")]");
                        sw.WriteLine($"        [NativeName(\"Type.Name\", \"{structField.Type.OriginalName}\")]");
                        sw.WriteLine($"        [NativeName(\"Name\", \"{structField.NativeName}\")]");
                        sw.WriteLine($"        public {structField.Name}Buffer {structField.Name};");
                        sw.WriteLine();
                        sw.WriteLine($"        public struct {structField.Name}Buffer");
                        sw.WriteLine("        {");
                        for (var i = 0; i < count; i++)
                        {
                            sw.WriteLine($"            public {typeFixup09072020} Element{i};");
                        }

                        sw.WriteLine($"            public ref {typeFixup09072020} this[int index]");
                        sw.WriteLine("            {");
                        sw.WriteLine("                get");
                        sw.WriteLine("                {");
                        sw.WriteLine($"                    if (index > {count - 1} || index < 0)");
                        sw.WriteLine("                    {");
                        sw.WriteLine("                        throw new ArgumentOutOfRangeException(nameof(index));");
                        sw.WriteLine("                    }");
                        sw.WriteLine();
                        sw.WriteLine($"                    fixed ({typeFixup09072020}* ptr = &Element0)");
                        sw.WriteLine("                    {");
                        sw.WriteLine("                        return ref ptr[index];");
                        sw.WriteLine("                    }");
                        sw.WriteLine("                }");
                        sw.WriteLine("            }");
                        if (!typeFixup09072020.IsPointer)
                        {
                            sw.WriteLine();
                            sw.WriteLine("#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER");
                            sw.WriteLine($"            public Span<{typeFixup09072020}> AsSpan()");
                            sw.WriteLine($"                => MemoryMarshal.CreateSpan(ref Element0, {count});");
                            sw.WriteLine("#endif");
                        }

                        sw.WriteLine("        }");
                        sw.WriteLine();
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(structField.Doc))
                        {
                            sw.WriteLine($"        {structField.Doc}");
                        }

                        var count = structField.Count.IsConstant
                            ? Utilities.ParseInt
                            (
                                profile.Projects.SelectMany(x => x.Value.Classes.SelectMany(y => y.Constants))
                                    .FirstOrDefault(x => x.NativeName == structField.Count.ConstantName)
                                    ?
                                    .Value ??
                                profile.Projects.SelectMany(x => x.Value.Enums.SelectMany(y => y.Tokens))
                                    .FirstOrDefault(x => x.NativeName == structField.Count.ConstantName)
                                    ?
                                    .Value ?? throw new InvalidDataException("Couldn't find constant referenced")
                            )
                            : structField.Count.IsStatic
                                ? structField.Count.StaticCount
                                : 1;
                        var typeFixup09072020 = new TypeSignatureBuilder(structField.Type).WithIndirectionLevel
                                //(structField.Type.IndirectionLevels - 1).Build();
                                (0)
                            .Build();

                        foreach (var attr in structField.Attributes)
                        {
                            sw.WriteLine($"        {attr}");
                        }

                        sw.WriteLine($"        [NativeName(\"Type\", \"{structField.NativeType}\")]");
                        sw.WriteLine($"        [NativeName(\"Type.Name\", \"{structField.Type.OriginalName}\")]");
                        sw.WriteLine($"        [NativeName(\"Name\", \"{structField.NativeName}\")]");
                        sw.WriteLine($"        public fixed {typeFixup09072020} {structField.Name}[{count}];");
                    }
                }
                else
                {
                    sw.WriteLine(structField.Doc);
                    foreach (var attr in structField.Attributes)
                    {
                        sw.WriteLine($"        {attr}");
                    }

                    sw.WriteLine($"        [NativeName(\"Type\", \"{structField.NativeType}\")]");
                    sw.WriteLine($"        [NativeName(\"Type.Name\", \"{structField.Type.OriginalName}\")]");
                    sw.WriteLine($"        [NativeName(\"Name\", \"{structField.NativeName}\")]");
                    if (structField.Type.IsFunctionPointer)
                    {
                        var camel = structField.Name.Camelize();
                        sw.WriteLine($"        public {structField.Type} {structField.Name}");
                        sw.WriteLine($"        {{");
                        sw.WriteLine($"            get => ({structField.Type}) _{camel};");
                        sw.WriteLine($"            set => _{camel} = value;");
                        sw.WriteLine($"        }}");
                        sw.WriteLine();
                        sw.WriteLine($"        private void* _{camel};");
                    }
                    else
                    {
                        sw.WriteLine($"        public {structField.Type} {structField.Name};");
                    }
                }
            }

            foreach (var function in @struct.Functions.Concat
                (ComVtblProcessor.GetHelperFunctions(@struct, profile.Projects["Core"])))
            {
                using (var sr = new StringReader(function.Signature.Doc))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine($"        {line}");
                    }
                }

                foreach (var attr in function.Signature.Attributes)
                {
                    sw.WriteLine($"        [{attr.Name}({string.Join(", ", attr.Arguments)})]");
                }

                using (var sr = new StringReader
                    (function.Signature.ToString(null, accessibility: true, semicolon: false)))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine($"        {line}");
                    }
                }

                sw.WriteLine("        {");
                foreach (var line in function.Body)
                {
                    sw.WriteLine($"            {line}");
                }

                sw.WriteLine("        }");
                sw.WriteLine();
            }

            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Flush();
            sw.Dispose();
        }

        public static void WriteBuildToolsIntrinsic
            (Struct @struct, string file, Profile profile, Project project, BindState task, List<string> args)
        {
            if (args[0] == "$PFN")
            {
                WriteFunctionPointerWrapper
                    (@struct, file, profile, project, task, args[1], args[2], Enum.Parse<CallingConvention>(args[3]));
            }
            else
            {
                throw new InvalidOperationException("Struct is not a valid intrinsic");
            }
        }

        public static void WriteFunctionPointerWrapper
        (
            Struct @struct,
            string file,
            Profile profile,
            Project project,
            BindState state,
            string delegateName,
            string pfnName,
            CallingConvention conv
        )
        {
            var coreProject = profile.Projects["Core"];
            var type = new Type
            {
                FunctionPointerSignature = new Function
                {
                    Name = delegateName, NativeName = pfnName.Substring(3),
                    Parameters = @struct.Fields.SkipLast(1)
                        .Select
                            ((x, i) => new Parameter {Name = $"arg{i}", Type = x.Type})
                        .ToList(),
                    ReturnType = @struct.Fields.LastOrDefault()?.Type ?? new Type {Name = "void"},
                    Convention = conv
                }
            };

            var fnPtrSig = type.FunctionPointerSignature.GetFunctionPointerSignature();
            using var sw = new StreamWriter(file) {NewLine = "\n"};
            sw.WriteLine(state.LicenseText());
            sw.WriteLine();
            sw.WriteCoreUsings();
            sw.WriteLine();
            sw.WriteLine("#pragma warning disable 1591");
            sw.WriteLine();
            sw.WriteLine($"namespace {state.Task.Namespace}{coreProject.Namespace}");
            sw.WriteLine("{");
            sw.WriteLine($"    public unsafe readonly struct {pfnName} : IDisposable");
            sw.WriteLine("    {");
            sw.WriteLine("        private readonly void* _handle;");
            sw.WriteLine($"        public {fnPtrSig} Handle => ({fnPtrSig}) _handle;");
            sw.WriteLine($"        public {pfnName}");
            sw.WriteLine($"        (");
            sw.WriteLine($"            {fnPtrSig} ptr");
            sw.WriteLine($"        ) => _handle = ptr;");
            sw.WriteLine();
            sw.WriteLine($"        public {pfnName}");
            sw.WriteLine($"        (");
            sw.WriteLine($"             {delegateName} proc");
            sw.WriteLine($"        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);");
            sw.WriteLine();
            sw.WriteLine($"        public static {pfnName} From({delegateName} proc) => new {pfnName}(proc);");
            sw.WriteLine($"        public void Dispose() => SilkMarshal.Free((nint) _handle);");
            sw.WriteLine();
            sw.WriteLine($"        public static implicit operator nint({pfnName} pfn) => (nint) pfn.Handle;");
            sw.WriteLine($"        public static explicit operator {pfnName}(nint pfn)");
            sw.WriteLine($"            => new {pfnName}(({fnPtrSig}) pfn);");
            sw.WriteLine();
            sw.WriteLine($"        public static implicit operator {pfnName}({delegateName} proc)");
            sw.WriteLine($"            => new {pfnName}(proc);");
            sw.WriteLine();
            sw.WriteLine($"        public static explicit operator {delegateName}({pfnName} pfn)");
            sw.WriteLine($"            => SilkMarshal.PtrToDelegate<{delegateName}>(pfn);");
            sw.WriteLine();
            sw.WriteLine($"        public static implicit operator {fnPtrSig}({pfnName} pfn) => pfn.Handle;");
            sw.WriteLine($"        public static implicit operator {pfnName}({fnPtrSig} ptr) => new {pfnName}(ptr);");
            sw.WriteLine("    }");
            sw.WriteLine();
            // type.FunctionPointerSignature.Name = delegateName;
            // type.FunctionPointerSignature.NativeName = $"{pfnName}";
            // type.Name = type.FunctionPointerSignature.NativeName;
            // type.IndirectionLevels--;
            using (var sr = new StringReader
                (type.FunctionPointerSignature.ToString(null, @delegate: true, semicolon: true, accessibility: true)))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sw.WriteLine($"    {line}");
                }
            }

            sw.WriteLine("}");
            sw.WriteLine();
            sw.Flush();
        }

        public static void WriteFusedField(Struct @struct, Project p, Field field, List<string> args, StreamWriter sw)
        {
            var temporaryValue = IsTemporaryValue(p, @struct, args);
            if (!temporaryValue)
            {
                sw.WriteLine("#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER");
                sw.WriteLine($"        public ref {field.Type} {field.Name}");
                sw.WriteLine("        {");
                sw.WriteLine("            [MethodImpl((MethodImplOptions) 768)]");
                sw.WriteLine($"            get => ref MemoryMarshal.CreateSpan(ref {args[1]}, 1)[0].{args[2]};");
                sw.WriteLine("        }");
                sw.WriteLine("#else");
            }

            sw.WriteLine($"        public {field.Type} {field.Name}");
            sw.WriteLine("        {");
            sw.WriteLine($"            get => {args[1]}.{args[2]};");
            sw.WriteLine($"            set => {args[1]}.{args[2]} = value;");
            sw.WriteLine("        }");
            if (!temporaryValue)
            {
                sw.WriteLine("#endif");
            }

            sw.WriteLine();

            static bool IsTemporaryValue(Project p, Struct @struct, List<string> args)
            {
                // ReSharper disable AccessToModifiedClosure
                var fusingStruct = p.Structs.First(x => x.Name == @struct.Fields.First(y => y.Name == args[1]).Type.Name);
                var fusingFieldInst = fusingStruct.Fields.First(x => x.Name == args[2]);
                if (fusingFieldInst.NumBits is not null)
                {
                    return true;
                }

                // ReSharper restore AccessToModifiedClosure
                if (fusingFieldInst.Attributes.IsBuildToolsIntrinsic(out args))
                {
                    if (args[0] == "$FUSEFLD")
                    {
                        return IsTemporaryValue(p, fusingStruct, args);
                    }
                }

                return false;
            }
        }

        public static void WriteBitfield
        (
            Field fieldDecl,
            ref int index,
            ref long previousSize,
            ref long remainingBits,
            ref string currentBitfieldType,
            StreamWriter sw,
            Profile profile
        )
        {
            Debug.Assert(fieldDecl.NumBits is not null);
            sw.WriteLine();
            var type = fieldDecl.Type;
            var typeName = type.Name;
            var typeNameBacking = typeName;
            if (string.IsNullOrWhiteSpace(fieldDecl.NativeType))
            {
                fieldDecl.NativeType = typeName;
            }

            var @enum = profile.Projects.Values.SelectMany(x => x.Enums).FirstOrDefault(x => x.Name == typeName);
            if (@enum is not null)
            {
                typeNameBacking = @enum.EnumBaseType.Name;
            }

            fieldDecl.NativeType += $" : {fieldDecl.NumBits.Value}";
            // TODO union handling? don't have enough metadata atm...
            var bitfieldName = "_bitfield";
            var currentSize = typeNameBacking switch
            {
                "byte" => 1L,
                "sbyte" => 1L,
                "short" => 2L,
                "ushort" => 2L,
                "int" => 4L,
                "uint" => 4L,
                "long" => 8L,
                "ulong" => 8L,
                _ => throw new ArgumentException("Unsupported bitfield type.")
            };
            if (fieldDecl.NumBits > remainingBits)
            {
                if (index >= 0)
                {
                    index++;
                    bitfieldName += index.ToString();
                }

                remainingBits = currentSize * 8;
                previousSize = 0;
                sw.Write("        private ");
                sw.Write(currentBitfieldType = typeNameBacking);
                sw.Write(' ');
                sw.Write(bitfieldName);
                sw.Write(';');
                sw.WriteLine();
                sw.WriteLine();
            }
            else
            {
                currentSize = Math.Max(previousSize, currentSize);
                if (index >= 0)
                {
                    bitfieldName += index.ToString();
                }
            }

            var bitfieldOffset = currentSize * 8 - remainingBits;
            var bitwidthHexStringBacking = ((1 << fieldDecl.NumBits.Value) - 1).ToString("X") + typeNameBacking switch
            {
                "byte" => string.Empty,
                "sbyte" => string.Empty,
                "short" => string.Empty,
                "ushort" => "u",
                "int" => string.Empty,
                "uint" => "u",
                "long" => "L",
                "ulong" => "UL",
                _ => throw new ArgumentException("Unsupported bitfield type.")
            };
            var bitwidthHexString = bitwidthHexStringBacking;
            sw.Write("        public");
            sw.Write(' ');
            sw.Write(typeName);
            sw.Write(' ');
            sw.WriteLine(fieldDecl.Name);
            sw.WriteLine("        {");
            sw.WriteLine("            [MethodImpl(MethodImplOptions.AggressiveInlining)]");
            sw.Write("            get => ");
            sw.Write('(');
            sw.Write(typeName);
            sw.Write(")(");
            if (bitfieldOffset != 0)
            {
                sw.Write('(');
            }

            sw.Write(bitfieldName);
            if (bitfieldOffset != 0)
            {
                sw.Write(" >> ");
                sw.Write(bitfieldOffset);
                sw.Write(')');
            }

            sw.Write(" & 0x");
            sw.Write(bitwidthHexStringBacking);
            sw.Write(')');
            sw.WriteLine(';');
            sw.WriteLine("            [MethodImpl(MethodImplOptions.AggressiveInlining)]");
            sw.Write("            set => ");
            sw.Write(bitfieldName);
            sw.Write(" = ");
            sw.Write('(');
            sw.Write(currentBitfieldType);
            sw.Write(")((");
            sw.Write(typeName);
            sw.Write(")(");
            sw.Write(bitfieldName);
            sw.Write(" & ~");
            if (bitfieldOffset != 0)
            {
                sw.Write('(');
            }

            sw.Write("0x");
            sw.Write(bitwidthHexStringBacking);
            if (bitfieldOffset != 0)
            {
                sw.Write(" << ");
                sw.Write(bitfieldOffset);
                sw.Write(')');
            }

            sw.Write(") | ");
            sw.Write('(');
            sw.Write(typeName);
            sw.Write(')');
            sw.Write('(');
            if (bitfieldOffset != 0)
            {
                sw.Write('(');
            }

            sw.Write('(');
            sw.Write(typeNameBacking);
            sw.Write(")(value)");
            sw.Write(" & 0x");
            sw.Write(bitwidthHexString);
            if (bitfieldOffset != 0)
            {
                sw.Write(") << ");
                sw.Write(bitfieldOffset);
            }

            sw.Write(')');
            sw.Write(')');
            sw.WriteLine(";");
            sw.WriteLine("        }");
            remainingBits -= fieldDecl.NumBits.Value;
            previousSize = Math.Max(previousSize, currentSize);
        }
    }
}
