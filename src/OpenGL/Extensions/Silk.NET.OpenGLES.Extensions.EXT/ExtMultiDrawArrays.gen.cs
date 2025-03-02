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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_multi_draw_arrays")]
    public unsafe partial class ExtMultiDrawArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_multi_draw_arrays";
        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public unsafe partial void MultiDrawArrays([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public unsafe partial void MultiDrawArrays([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public unsafe partial void MultiDrawArrays([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public partial void MultiDrawArrays([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public unsafe partial void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public unsafe partial void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public unsafe partial void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public partial void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        public unsafe void MultiDrawArrays([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawArrays(mode, first, in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawArrays([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawArrays(mode, in first.GetPinnableReference(), count, (uint) first.Length);
        }

        public unsafe void MultiDrawArrays([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawArrays(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawArrays(mode, first, in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawArrays(mode, in first.GetPinnableReference(), count, (uint) first.Length);
        }

        public unsafe void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawArrays(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] void** indices)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElements(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length);
        }

        public unsafe void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in void* indices)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElements(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length);
        }

        public unsafe void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] void** indices)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElements(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length);
        }

        public unsafe void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in void* indices)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElements(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length);
        }

        public unsafe void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] void** indices)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElements(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length);
        }

        public unsafe void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in void* indices)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElements(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length);
        }

        public unsafe void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] void** indices)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElements(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length);
        }

        public unsafe void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] in void* indices)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElements(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length);
        }

        public ExtMultiDrawArrays(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

