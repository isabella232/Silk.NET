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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.FUCHSIA
{
    [Extension("VK_FUCHSIA_buffer_collection")]
    public unsafe partial class FuchsiaBufferCollection : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_FUCHSIA_buffer_collection";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferCollectionFUCHSIA")]
        public unsafe partial Result CreateBufferCollectionFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferCollectionCreateInfoFUCHSIA* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] BufferCollectionFUCHSIA* pCollection);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferCollectionFUCHSIA")]
        public unsafe partial Result CreateBufferCollectionFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferCollectionCreateInfoFUCHSIA* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out BufferCollectionFUCHSIA pCollection);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferCollectionFUCHSIA")]
        public unsafe partial Result CreateBufferCollectionFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferCollectionCreateInfoFUCHSIA* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] BufferCollectionFUCHSIA* pCollection);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferCollectionFUCHSIA")]
        public unsafe partial Result CreateBufferCollectionFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferCollectionCreateInfoFUCHSIA* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out BufferCollectionFUCHSIA pCollection);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferCollectionFUCHSIA")]
        public unsafe partial Result CreateBufferCollectionFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferCollectionCreateInfoFUCHSIA pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] BufferCollectionFUCHSIA* pCollection);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferCollectionFUCHSIA")]
        public unsafe partial Result CreateBufferCollectionFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferCollectionCreateInfoFUCHSIA pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out BufferCollectionFUCHSIA pCollection);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferCollectionFUCHSIA")]
        public unsafe partial Result CreateBufferCollectionFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferCollectionCreateInfoFUCHSIA pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] BufferCollectionFUCHSIA* pCollection);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferCollectionFUCHSIA")]
        public partial Result CreateBufferCollectionFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferCollectionCreateInfoFUCHSIA pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out BufferCollectionFUCHSIA pCollection);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyBufferCollectionFUCHSIA")]
        public unsafe partial void DestroyBufferCollectionFuchsia([Count(Count = 0)] Device device, [Count(Count = 0)] BufferCollectionFUCHSIA collection, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyBufferCollectionFUCHSIA")]
        public partial void DestroyBufferCollectionFuchsia([Count(Count = 0)] Device device, [Count(Count = 0)] BufferCollectionFUCHSIA collection, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferCollectionPropertiesFUCHSIA")]
        public unsafe partial Result GetBufferCollectionPropertiesFuchsia([Count(Count = 0)] Device device, [Count(Count = 0)] BufferCollectionFUCHSIA collection, [Count(Count = 0), Flow(FlowDirection.Out)] BufferCollectionPropertiesFUCHSIA* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.BufferCollectionPropertiesFuchsia);")]
        [NativeApi(EntryPoint = "vkGetBufferCollectionPropertiesFUCHSIA")]
        public partial Result GetBufferCollectionPropertiesFuchsia([Count(Count = 0)] Device device, [Count(Count = 0)] BufferCollectionFUCHSIA collection, [Count(Count = 0), Flow(FlowDirection.Out)] out BufferCollectionPropertiesFUCHSIA pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetBufferCollectionBufferConstraintsFUCHSIA")]
        public unsafe partial Result SetBufferCollectionBufferConstraintsFuchsia([Count(Count = 0)] Device device, [Count(Count = 0)] BufferCollectionFUCHSIA collection, [Count(Count = 0), Flow(FlowDirection.In)] BufferConstraintsInfoFUCHSIA* pBufferConstraintsInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetBufferCollectionBufferConstraintsFUCHSIA")]
        public partial Result SetBufferCollectionBufferConstraintsFuchsia([Count(Count = 0)] Device device, [Count(Count = 0)] BufferCollectionFUCHSIA collection, [Count(Count = 0), Flow(FlowDirection.In)] in BufferConstraintsInfoFUCHSIA pBufferConstraintsInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetBufferCollectionImageConstraintsFUCHSIA")]
        public unsafe partial Result SetBufferCollectionImageConstraintsFuchsia([Count(Count = 0)] Device device, [Count(Count = 0)] BufferCollectionFUCHSIA collection, [Count(Count = 0), Flow(FlowDirection.In)] ImageConstraintsInfoFUCHSIA* pImageConstraintsInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetBufferCollectionImageConstraintsFUCHSIA")]
        public partial Result SetBufferCollectionImageConstraintsFuchsia([Count(Count = 0)] Device device, [Count(Count = 0)] BufferCollectionFUCHSIA collection, [Count(Count = 0), Flow(FlowDirection.In)] in ImageConstraintsInfoFUCHSIA pImageConstraintsInfo);

        public FuchsiaBufferCollection(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

