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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_parallel_shader_compile")]
    public unsafe partial class ArbParallelShaderCompile : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_parallel_shader_compile";
        [NativeApi(EntryPoint = "glMaxShaderCompilerThreadsARB")]
        public partial void MaxShaderCompilerThreads([Flow(FlowDirection.In)] uint count);

        public ArbParallelShaderCompile(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

