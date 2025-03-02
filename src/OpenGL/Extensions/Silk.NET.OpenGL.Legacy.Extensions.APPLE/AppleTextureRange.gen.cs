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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_texture_range")]
    public unsafe partial class AppleTextureRange : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_texture_range";
        [NativeApi(EntryPoint = "glGetTexParameterPointervAPPLE")]
        public unsafe partial void GetTexParameterPointer([Flow(FlowDirection.In)] APPLE target, [Flow(FlowDirection.In)] APPLE pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetTexParameterPointervAPPLE")]
        public unsafe partial void GetTexParameterPointer([Flow(FlowDirection.In)] APPLE target, [Flow(FlowDirection.In)] APPLE pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glTextureRangeAPPLE")]
        public unsafe partial void TextureRange([Flow(FlowDirection.In)] APPLE target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glTextureRangeAPPLE")]
        public partial void TextureRange<T0>([Flow(FlowDirection.In)] APPLE target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        public unsafe void TextureRange<T0>([Flow(FlowDirection.In)] APPLE target, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            TextureRange(target, (uint) (pointer.Length * Unsafe.SizeOf<T0>()), in pointer.GetPinnableReference());
        }

        public AppleTextureRange(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

