// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_draw_elements_base_vertex")]
    public unsafe partial class ArbDrawElementsBaseVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_draw_elements_base_vertex";
        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, count, type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] void** indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, basevertex);
        }

        public unsafe void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Count(Parameter = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, (uint) basevertex.Length, in basevertex.GetPinnableReference());
        }

        public ArbDrawElementsBaseVertex(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

