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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_external_buffer")]
    public unsafe partial class ExtExternalBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_external_buffer";
        [NativeApi(EntryPoint = "glBufferStorageExternalEXT")]
        public partial void BufferStorageExternal([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] nint clientBuffer, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glBufferStorageExternalEXT")]
        public partial void BufferStorageExternal([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] nint clientBuffer, [Flow(FlowDirection.In)] BufferStorageMask flags);

        [NativeApi(EntryPoint = "glNamedBufferStorageExternalEXT")]
        public partial void NamedBufferStorageExternal([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] nint clientBuffer, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glNamedBufferStorageExternalEXT")]
        public partial void NamedBufferStorageExternal([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] nint clientBuffer, [Flow(FlowDirection.In)] BufferStorageMask flags);

        public ExtExternalBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

