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

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe partial class Vk : NativeAPI
    {
        [NativeName("Type", "")]
        [NativeName("Name", "VK_ATTACHMENT_UNUSED")]
        public const uint AttachmentUnused = unchecked((uint) (~0U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_FALSE")]
        public const uint False = unchecked((uint) 0);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_LOD_CLAMP_NONE")]
        public const uint LodClampNone = unchecked((uint) 1000.0F);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_LUID_SIZE")]
        public const uint LuidSize = unchecked((uint) 8);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_LUID_SIZE_KHR")]
        public const uint LuidSizeKhr = unchecked((uint) 8);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DESCRIPTION_SIZE")]
        public const uint MaxDescriptionSize = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DEVICE_GROUP_SIZE")]
        public const uint MaxDeviceGroupSize = unchecked((uint) 32);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DEVICE_GROUP_SIZE_KHR")]
        public const uint MaxDeviceGroupSizeKhr = unchecked((uint) 32);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DRIVER_INFO_SIZE")]
        public const uint MaxDriverInfoSize = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DRIVER_INFO_SIZE_KHR")]
        public const uint MaxDriverInfoSizeKhr = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DRIVER_NAME_SIZE")]
        public const uint MaxDriverNameSize = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_DRIVER_NAME_SIZE_KHR")]
        public const uint MaxDriverNameSizeKhr = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_EXTENSION_NAME_SIZE")]
        public const uint MaxExtensionNameSize = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_GLOBAL_PRIORITY_SIZE_EXT")]
        public const uint MaxGlobalPrioritySizeExt = unchecked((uint) 16);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_MEMORY_HEAPS")]
        public const uint MaxMemoryHeaps = unchecked((uint) 16);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_MEMORY_TYPES")]
        public const uint MaxMemoryTypes = unchecked((uint) 32);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_MAX_PHYSICAL_DEVICE_NAME_SIZE")]
        public const uint MaxPhysicalDeviceNameSize = unchecked((uint) 256);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_QUEUE_FAMILY_EXTERNAL")]
        public const uint QueueFamilyExternal = unchecked((uint) (~1U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_QUEUE_FAMILY_EXTERNAL_KHR")]
        public const uint QueueFamilyExternalKhr = unchecked((uint) (~1U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_QUEUE_FAMILY_FOREIGN_EXT")]
        public const uint QueueFamilyForeignExt = unchecked((uint) (~2U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_QUEUE_FAMILY_IGNORED")]
        public const uint QueueFamilyIgnored = unchecked((uint) (~0U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_REMAINING_ARRAY_LAYERS")]
        public const uint RemainingArrayLayers = unchecked((uint) (~0U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_REMAINING_MIP_LEVELS")]
        public const uint RemainingMipLevels = unchecked((uint) (~0U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_SHADER_UNUSED_KHR")]
        public const uint ShaderUnusedKhr = unchecked((uint) (~0U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_SHADER_UNUSED_NV")]
        public const uint ShaderUnusedNV = unchecked((uint) (~0U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_SUBPASS_EXTERNAL")]
        public const uint SubpassExternal = unchecked((uint) (~0U));
        [NativeName("Type", "")]
        [NativeName("Name", "VK_TRUE")]
        public const uint True = unchecked((uint) 1);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_UUID_SIZE")]
        public const uint UuidSize = unchecked((uint) 16);
        [NativeName("Type", "")]
        [NativeName("Name", "VK_WHOLE_SIZE")]
        public const ulong WholeSize = unchecked((ulong) (~0ul));

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2")]
        public unsafe partial void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0), Flow(FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2")]
        public unsafe partial void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0), Flow(FlowDirection.In)] in SubpassBeginInfo pSubpassBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2")]
        public unsafe partial void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in RenderPassBeginInfo pRenderPassBegin, [Count(Count = 0), Flow(FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass2")]
        public partial void CmdBeginRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in RenderPassBeginInfo pRenderPassBegin, [Count(Count = 0), Flow(FlowDirection.In)] in SubpassBeginInfo pSubpassBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexedIndirectCount")]
        public partial void CmdDrawIndexedIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndirectCount")]
        public partial void CmdDrawIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass2")]
        public unsafe partial void CmdEndRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass2")]
        public partial void CmdEndRenderPass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in SubpassEndInfo pSubpassEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2")]
        public unsafe partial void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo, [Count(Count = 0), Flow(FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2")]
        public unsafe partial void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] SubpassBeginInfo* pSubpassBeginInfo, [Count(Count = 0), Flow(FlowDirection.In)] in SubpassEndInfo pSubpassEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2")]
        public unsafe partial void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in SubpassBeginInfo pSubpassBeginInfo, [Count(Count = 0), Flow(FlowDirection.In)] SubpassEndInfo* pSubpassEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass2")]
        public partial void CmdNextSubpass2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in SubpassBeginInfo pSubpassBeginInfo, [Count(Count = 0), Flow(FlowDirection.In)] in SubpassEndInfo pSubpassEndInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2")]
        public unsafe partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2")]
        public unsafe partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out RenderPass pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2")]
        public unsafe partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2")]
        public unsafe partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassCreateInfo2* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out RenderPass pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2")]
        public unsafe partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in RenderPassCreateInfo2 pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2")]
        public unsafe partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in RenderPassCreateInfo2 pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out RenderPass pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2")]
        public unsafe partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in RenderPassCreateInfo2 pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass2")]
        public partial Result CreateRenderPass2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in RenderPassCreateInfo2 pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out RenderPass pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferDeviceAddress")]
        public unsafe partial ulong GetBufferDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferDeviceAddressInfo* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferDeviceAddress")]
        public partial ulong GetBufferDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferDeviceAddressInfo pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureAddress")]
        public unsafe partial ulong GetBufferOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferDeviceAddressInfo* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureAddress")]
        public partial ulong GetBufferOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferDeviceAddressInfo pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress")]
        public unsafe partial ulong GetDeviceMemoryOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DeviceMemoryOpaqueCaptureAddressInfo* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress")]
        public partial ulong GetDeviceMemoryOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DeviceMemoryOpaqueCaptureAddressInfo pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreCounterValue")]
        public unsafe partial Result GetSemaphoreCounterValue([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pValue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreCounterValue")]
        public partial Result GetSemaphoreCounterValue([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pValue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkResetQueryPool")]
        public partial void ResetQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSignalSemaphore")]
        public unsafe partial Result SignalSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreSignalInfo* pSignalInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSignalSemaphore")]
        public partial Result SignalSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SemaphoreSignalInfo pSignalInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWaitSemaphores")]
        public unsafe partial Result WaitSemaphores([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreWaitInfo* pWaitInfo, [Count(Count = 0)] ulong timeout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWaitSemaphores")]
        public partial Result WaitSemaphores([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SemaphoreWaitInfo pWaitInfo, [Count(Count = 0)] ulong timeout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory2")]
        public unsafe partial Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(FlowDirection.In)] BindBufferMemoryInfo* pBindInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory2")]
        public partial Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(FlowDirection.In)] in BindBufferMemoryInfo pBindInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory2")]
        public unsafe partial Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(FlowDirection.In)] BindImageMemoryInfo* pBindInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory2")]
        public partial Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(FlowDirection.In)] in BindImageMemoryInfo pBindInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchBase")]
        public partial void CmdDispatchBase([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint baseGroupX, [Count(Count = 0)] uint baseGroupY, [Count(Count = 0)] uint baseGroupZ, [Count(Count = 0)] uint groupCountX, [Count(Count = 0)] uint groupCountY, [Count(Count = 0)] uint groupCountZ);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDeviceMask")]
        public partial void CmdSetDeviceMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint deviceMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        public unsafe partial Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        public unsafe partial Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorUpdateTemplate pDescriptorUpdateTemplate);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        public unsafe partial Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        public unsafe partial Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorUpdateTemplateCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorUpdateTemplate pDescriptorUpdateTemplate);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        public unsafe partial Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorUpdateTemplateCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        public unsafe partial Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorUpdateTemplateCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorUpdateTemplate pDescriptorUpdateTemplate);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        public unsafe partial Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorUpdateTemplateCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorUpdateTemplate* pDescriptorUpdateTemplate);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        public partial Result CreateDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorUpdateTemplateCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorUpdateTemplate pDescriptorUpdateTemplate);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversion")]
        public unsafe partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversion")]
        public unsafe partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SamplerYcbcrConversion pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversion")]
        public unsafe partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversion")]
        public unsafe partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SamplerYcbcrConversion pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversion")]
        public unsafe partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SamplerYcbcrConversionCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversion")]
        public unsafe partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SamplerYcbcrConversionCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SamplerYcbcrConversion pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversion")]
        public unsafe partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SamplerYcbcrConversionCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversion")]
        public partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SamplerYcbcrConversionCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SamplerYcbcrConversion pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorUpdateTemplate")]
        public unsafe partial void DestroyDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorUpdateTemplate")]
        public partial void DestroyDescriptorUpdateTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroySamplerYcbcrConversion")]
        public unsafe partial void DestroySamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0)] SamplerYcbcrConversion ycbcrConversion, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroySamplerYcbcrConversion")]
        public partial void DestroySamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0)] SamplerYcbcrConversion ycbcrConversion, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceVersion")]
        public unsafe partial Result EnumerateInstanceVersion([Count(Count = 0)] uint* pApiVersion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceVersion")]
        public partial Result EnumerateInstanceVersion([Count(Count = 0)] ref uint pApiVersion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
        public unsafe partial Result EnumeratePhysicalDeviceGroups([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceGroupCount, [Count(Parameter = "pPhysicalDeviceGroupCount")] PhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
        public unsafe partial Result EnumeratePhysicalDeviceGroups([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceGroupCount, [Count(Parameter = "pPhysicalDeviceGroupCount")] ref PhysicalDeviceGroupProperties pPhysicalDeviceGroupProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
        public unsafe partial Result EnumeratePhysicalDeviceGroups([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref uint pPhysicalDeviceGroupCount, [Count(Parameter = "pPhysicalDeviceGroupCount")] PhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
        public partial Result EnumeratePhysicalDeviceGroups([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref uint pPhysicalDeviceGroupCount, [Count(Parameter = "pPhysicalDeviceGroupCount")] ref PhysicalDeviceGroupProperties pPhysicalDeviceGroupProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2")]
        public unsafe partial void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2")]
        public unsafe partial void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2")]
        public unsafe partial void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements2")]
        public partial void GetBufferMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupport")]
        public unsafe partial void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayoutSupport* pSupport);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSupport = new(StructureType.DescriptorSetLayoutSupport);")]
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupport")]
        public unsafe partial void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorSetLayoutSupport pSupport);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupport")]
        public unsafe partial void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorSetLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayoutSupport* pSupport);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSupport = new(StructureType.DescriptorSetLayoutSupport);")]
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupport")]
        public partial void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorSetLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorSetLayoutSupport pSupport);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures")]
        public unsafe partial void GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(FlowDirection.Out)] PeerMemoryFeatureFlags* pPeerMemoryFeatures);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures")]
        public partial void GetDeviceGroupPeerMemoryFeatures([Count(Count = 0)] Device device, [Count(Count = 0)] uint heapIndex, [Count(Count = 0)] uint localDeviceIndex, [Count(Count = 0)] uint remoteDeviceIndex, [Count(Count = 0), Flow(FlowDirection.Out)] out PeerMemoryFeatureFlags pPeerMemoryFeatures);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue2")]
        public unsafe partial void GetDeviceQueue2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DeviceQueueInfo2* pQueueInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Queue* pQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue2")]
        public unsafe partial void GetDeviceQueue2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DeviceQueueInfo2* pQueueInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out Queue pQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue2")]
        public unsafe partial void GetDeviceQueue2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DeviceQueueInfo2 pQueueInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Queue* pQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue2")]
        public partial void GetDeviceQueue2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DeviceQueueInfo2 pQueueInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out Queue pQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2")]
        public unsafe partial void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2")]
        public unsafe partial void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2")]
        public unsafe partial void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImageMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements2")]
        public partial void GetImageMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImageMemoryRequirementsInfo2 pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2 pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        public unsafe partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        public unsafe partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] out SparseImageMemoryRequirements2 pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        public unsafe partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        public unsafe partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] out SparseImageMemoryRequirements2 pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        public unsafe partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImageSparseMemoryRequirementsInfo2 pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        public unsafe partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImageSparseMemoryRequirementsInfo2 pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] out SparseImageMemoryRequirements2 pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        public unsafe partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImageSparseMemoryRequirementsInfo2 pInfo, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        public partial void GetImageSparseMemoryRequirements2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImageSparseMemoryRequirementsInfo2 pInfo, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] out SparseImageMemoryRequirements2 pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
        public unsafe partial void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalBufferProperties* pExternalBufferProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalBufferProperties = new(StructureType.ExternalBufferProperties);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
        public unsafe partial void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalBufferProperties pExternalBufferProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
        public unsafe partial void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceExternalBufferInfo pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalBufferProperties* pExternalBufferProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalBufferProperties = new(StructureType.ExternalBufferProperties);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
        public partial void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceExternalBufferInfo pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalBufferProperties pExternalBufferProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
        public unsafe partial void GetPhysicalDeviceExternalFenceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalFenceProperties* pExternalFenceProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalFenceProperties = new(StructureType.ExternalFenceProperties);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
        public unsafe partial void GetPhysicalDeviceExternalFenceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalFenceProperties pExternalFenceProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
        public unsafe partial void GetPhysicalDeviceExternalFenceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceExternalFenceInfo pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalFenceProperties* pExternalFenceProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalFenceProperties = new(StructureType.ExternalFenceProperties);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
        public partial void GetPhysicalDeviceExternalFenceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceExternalFenceInfo pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalFenceProperties pExternalFenceProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
        public unsafe partial void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalSemaphoreProperties* pExternalSemaphoreProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalSemaphoreProperties = new(StructureType.ExternalSemaphoreProperties);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
        public unsafe partial void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalSemaphoreProperties pExternalSemaphoreProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
        public unsafe partial void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalSemaphoreProperties* pExternalSemaphoreProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalSemaphoreProperties = new(StructureType.ExternalSemaphoreProperties);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
        public partial void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalSemaphoreProperties pExternalSemaphoreProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures2")]
        public unsafe partial void GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceFeatures2* pFeatures);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pFeatures = new(StructureType.PhysicalDeviceFeatures2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures2")]
        public partial void GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceFeatures2 pFeatures);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties2")]
        public unsafe partial void GetPhysicalDeviceFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] FormatProperties2* pFormatProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pFormatProperties = new(StructureType.FormatProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties2")]
        public partial void GetPhysicalDeviceFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] out FormatProperties2 pFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
        public unsafe partial Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceImageFormatInfo2* pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ImageFormatProperties2* pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.ImageFormatProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
        public unsafe partial Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceImageFormatInfo2* pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageFormatProperties2 pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
        public unsafe partial Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceImageFormatInfo2 pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ImageFormatProperties2* pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pImageFormatProperties = new(StructureType.ImageFormatProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
        public partial Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceImageFormatInfo2 pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageFormatProperties2 pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties2")]
        public unsafe partial void GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceMemoryProperties2* pMemoryProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryProperties = new(StructureType.PhysicalDeviceMemoryProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties2")]
        public partial void GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceMemoryProperties2 pMemoryProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties2")]
        public unsafe partial void GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceProperties2* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.PhysicalDeviceProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties2")]
        public partial void GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceProperties2 pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
        public unsafe partial void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] QueueFamilyProperties2* pQueueFamilyProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyProperties = new(StructureType.QueueFamilyProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
        public unsafe partial void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] out QueueFamilyProperties2 pQueueFamilyProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
        public unsafe partial void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] QueueFamilyProperties2* pQueueFamilyProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pQueueFamilyProperties = new(StructureType.QueueFamilyProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
        public partial void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] out QueueFamilyProperties2 pQueueFamilyProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties2* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties2 pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties2* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties2 pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceSparseImageFormatInfo2 pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties2* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceSparseImageFormatInfo2 pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties2 pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceSparseImageFormatInfo2 pFormatInfo, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties2* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.SparseImageFormatProperties2);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        public partial void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceSparseImageFormatInfo2 pFormatInfo, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties2 pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkTrimCommandPool")]
        public partial void TrimCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint flags);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
        public unsafe partial void UpdateDescriptorSetWithTemplate([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
        public partial void UpdateDescriptorSetWithTemplate<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSet descriptorSet, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateCommandBuffers")]
        public unsafe partial Result AllocateCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CommandBufferAllocateInfo* pAllocateInfo, [Count(Computed = "pAllocateInfo->commandBufferCount"), Flow(FlowDirection.Out)] CommandBuffer* pCommandBuffers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateCommandBuffers")]
        public unsafe partial Result AllocateCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CommandBufferAllocateInfo* pAllocateInfo, [Count(Computed = "pAllocateInfo->commandBufferCount"), Flow(FlowDirection.Out)] out CommandBuffer pCommandBuffers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateCommandBuffers")]
        public unsafe partial Result AllocateCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in CommandBufferAllocateInfo pAllocateInfo, [Count(Computed = "pAllocateInfo->commandBufferCount"), Flow(FlowDirection.Out)] CommandBuffer* pCommandBuffers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateCommandBuffers")]
        public partial Result AllocateCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in CommandBufferAllocateInfo pAllocateInfo, [Count(Computed = "pAllocateInfo->commandBufferCount"), Flow(FlowDirection.Out)] out CommandBuffer pCommandBuffers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateDescriptorSets")]
        public unsafe partial Result AllocateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetAllocateInfo* pAllocateInfo, [Count(Computed = "pAllocateInfo->descriptorSetCount"), Flow(FlowDirection.Out)] DescriptorSet* pDescriptorSets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateDescriptorSets")]
        public unsafe partial Result AllocateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetAllocateInfo* pAllocateInfo, [Count(Computed = "pAllocateInfo->descriptorSetCount"), Flow(FlowDirection.Out)] out DescriptorSet pDescriptorSets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateDescriptorSets")]
        public unsafe partial Result AllocateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorSetAllocateInfo pAllocateInfo, [Count(Computed = "pAllocateInfo->descriptorSetCount"), Flow(FlowDirection.Out)] DescriptorSet* pDescriptorSets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateDescriptorSets")]
        public partial Result AllocateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorSetAllocateInfo pAllocateInfo, [Count(Computed = "pAllocateInfo->descriptorSetCount"), Flow(FlowDirection.Out)] out DescriptorSet pDescriptorSets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateMemory")]
        public unsafe partial Result AllocateMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryAllocateInfo* pAllocateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceMemory* pMemory);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateMemory")]
        public unsafe partial Result AllocateMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryAllocateInfo* pAllocateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceMemory pMemory);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateMemory")]
        public unsafe partial Result AllocateMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryAllocateInfo* pAllocateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceMemory* pMemory);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateMemory")]
        public unsafe partial Result AllocateMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryAllocateInfo* pAllocateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceMemory pMemory);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateMemory")]
        public unsafe partial Result AllocateMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in MemoryAllocateInfo pAllocateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceMemory* pMemory);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateMemory")]
        public unsafe partial Result AllocateMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in MemoryAllocateInfo pAllocateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceMemory pMemory);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateMemory")]
        public unsafe partial Result AllocateMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in MemoryAllocateInfo pAllocateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceMemory* pMemory);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAllocateMemory")]
        public partial Result AllocateMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in MemoryAllocateInfo pAllocateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DeviceMemory pMemory);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBeginCommandBuffer")]
        public unsafe partial Result BeginCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CommandBufferBeginInfo* pBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBeginCommandBuffer")]
        public partial Result BeginCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in CommandBufferBeginInfo pBeginInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindBufferMemory")]
        public partial Result BindBufferMemory([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong memoryOffset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindImageMemory")]
        public partial Result BindImageMemory([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong memoryOffset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginQuery")]
        public partial void CmdBeginQuery([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query, [Count(Count = 0)] QueryControlFlags flags);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass")]
        public unsafe partial void CmdBeginRenderPass([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassBeginInfo* pRenderPassBegin, [Count(Count = 0)] SubpassContents contents);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginRenderPass")]
        public partial void CmdBeginRenderPass([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in RenderPassBeginInfo pRenderPassBegin, [Count(Count = 0)] SubpassContents contents);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorSets")]
        public unsafe partial void CmdBindDescriptorSets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint descriptorSetCount, [Count(Parameter = "descriptorSetCount"), Flow(FlowDirection.In)] DescriptorSet* pDescriptorSets, [Count(Count = 0)] uint dynamicOffsetCount, [Count(Parameter = "dynamicOffsetCount"), Flow(FlowDirection.In)] uint* pDynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorSets")]
        public unsafe partial void CmdBindDescriptorSets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint descriptorSetCount, [Count(Parameter = "descriptorSetCount"), Flow(FlowDirection.In)] DescriptorSet* pDescriptorSets, [Count(Count = 0)] uint dynamicOffsetCount, [Count(Parameter = "dynamicOffsetCount"), Flow(FlowDirection.In)] in uint pDynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorSets")]
        public unsafe partial void CmdBindDescriptorSets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint descriptorSetCount, [Count(Parameter = "descriptorSetCount"), Flow(FlowDirection.In)] in DescriptorSet pDescriptorSets, [Count(Count = 0)] uint dynamicOffsetCount, [Count(Parameter = "dynamicOffsetCount"), Flow(FlowDirection.In)] uint* pDynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindDescriptorSets")]
        public partial void CmdBindDescriptorSets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint descriptorSetCount, [Count(Parameter = "descriptorSetCount"), Flow(FlowDirection.In)] in DescriptorSet pDescriptorSets, [Count(Count = 0)] uint dynamicOffsetCount, [Count(Parameter = "dynamicOffsetCount"), Flow(FlowDirection.In)] in uint pDynamicOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindIndexBuffer")]
        public partial void CmdBindIndexBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] IndexType indexType);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindPipeline")]
        public partial void CmdBindPipeline([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] Pipeline pipeline);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers")]
        public unsafe partial void CmdBindVertexBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers")]
        public unsafe partial void CmdBindVertexBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers")]
        public unsafe partial void CmdBindVertexBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in Buffer pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindVertexBuffers")]
        public partial void CmdBindVertexBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in Buffer pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] in ulong pOffsets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBlitImage")]
        public unsafe partial void CmdBlitImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] ImageBlit* pRegions, [Count(Count = 0)] Filter filter);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBlitImage")]
        public partial void CmdBlitImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] in ImageBlit pRegions, [Count(Count = 0)] Filter filter);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdClearAttachments")]
        public unsafe partial void CmdClearAttachments([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(FlowDirection.In)] ClearAttachment* pAttachments, [Count(Count = 0)] uint rectCount, [Count(Parameter = "rectCount"), Flow(FlowDirection.In)] ClearRect* pRects);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdClearAttachments")]
        public unsafe partial void CmdClearAttachments([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(FlowDirection.In)] ClearAttachment* pAttachments, [Count(Count = 0)] uint rectCount, [Count(Parameter = "rectCount"), Flow(FlowDirection.In)] in ClearRect pRects);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdClearAttachments")]
        public unsafe partial void CmdClearAttachments([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(FlowDirection.In)] in ClearAttachment pAttachments, [Count(Count = 0)] uint rectCount, [Count(Parameter = "rectCount"), Flow(FlowDirection.In)] ClearRect* pRects);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdClearAttachments")]
        public partial void CmdClearAttachments([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(FlowDirection.In)] in ClearAttachment pAttachments, [Count(Count = 0)] uint rectCount, [Count(Parameter = "rectCount"), Flow(FlowDirection.In)] in ClearRect pRects);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdClearColorImage")]
        public unsafe partial void CmdClearColorImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ClearColorValue* pColor, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(FlowDirection.In)] ImageSubresourceRange* pRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdClearColorImage")]
        public unsafe partial void CmdClearColorImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ClearColorValue* pColor, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(FlowDirection.In)] in ImageSubresourceRange pRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdClearColorImage")]
        public unsafe partial void CmdClearColorImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] in ClearColorValue pColor, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(FlowDirection.In)] ImageSubresourceRange* pRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdClearColorImage")]
        public partial void CmdClearColorImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] in ClearColorValue pColor, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(FlowDirection.In)] in ImageSubresourceRange pRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdClearDepthStencilImage")]
        public unsafe partial void CmdClearDepthStencilImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ClearDepthStencilValue* pDepthStencil, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(FlowDirection.In)] ImageSubresourceRange* pRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdClearDepthStencilImage")]
        public unsafe partial void CmdClearDepthStencilImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ClearDepthStencilValue* pDepthStencil, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(FlowDirection.In)] in ImageSubresourceRange pRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdClearDepthStencilImage")]
        public unsafe partial void CmdClearDepthStencilImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] in ClearDepthStencilValue pDepthStencil, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(FlowDirection.In)] ImageSubresourceRange* pRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdClearDepthStencilImage")]
        public partial void CmdClearDepthStencilImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] in ClearDepthStencilValue pDepthStencil, [Count(Count = 0)] uint rangeCount, [Count(Parameter = "rangeCount"), Flow(FlowDirection.In)] in ImageSubresourceRange pRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBuffer")]
        public unsafe partial void CmdCopyBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] BufferCopy* pRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBuffer")]
        public partial void CmdCopyBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] in BufferCopy pRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBufferToImage")]
        public unsafe partial void CmdCopyBufferToImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] BufferImageCopy* pRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyBufferToImage")]
        public partial void CmdCopyBufferToImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] in BufferImageCopy pRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImage")]
        public unsafe partial void CmdCopyImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] ImageCopy* pRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImage")]
        public partial void CmdCopyImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] in ImageCopy pRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImageToBuffer")]
        public unsafe partial void CmdCopyImageToBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] BufferImageCopy* pRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyImageToBuffer")]
        public partial void CmdCopyImageToBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] in BufferImageCopy pRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyQueryPoolResults")]
        public partial void CmdCopyQueryPoolResults([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatch")]
        public partial void CmdDispatch([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint groupCountX, [Count(Count = 0)] uint groupCountY, [Count(Count = 0)] uint groupCountZ);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDispatchIndirect")]
        public partial void CmdDispatchIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDraw")]
        public partial void CmdDraw([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint vertexCount, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstVertex, [Count(Count = 0)] uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexed")]
        public partial void CmdDrawIndexed([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint indexCount, [Count(Count = 0)] uint instanceCount, [Count(Count = 0)] uint firstIndex, [Count(Count = 0)] int vertexOffset, [Count(Count = 0)] uint firstInstance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndexedIndirect")]
        public partial void CmdDrawIndexedIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] uint drawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawIndirect")]
        public partial void CmdDrawIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] uint drawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndQuery")]
        public partial void CmdEndQuery([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndRenderPass")]
        public partial void CmdEndRenderPass([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteCommands")]
        public unsafe partial void CmdExecuteCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint commandBufferCount, [Count(Parameter = "commandBufferCount"), Flow(FlowDirection.In)] CommandBuffer* pCommandBuffers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteCommands")]
        public partial void CmdExecuteCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint commandBufferCount, [Count(Parameter = "commandBufferCount"), Flow(FlowDirection.In)] in CommandBuffer pCommandBuffers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdFillBuffer")]
        public partial void CmdFillBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong size, [Count(Count = 0)] uint data);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdNextSubpass")]
        public partial void CmdNextSubpass([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] SubpassContents contents);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier")]
        public unsafe partial void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier")]
        public unsafe partial void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] in ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier")]
        public unsafe partial void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] in BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier")]
        public unsafe partial void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] in BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] in ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier")]
        public unsafe partial void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] in MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier")]
        public unsafe partial void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] in MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] in ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier")]
        public unsafe partial void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] in MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] in BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier")]
        public partial void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] in MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] in BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] in ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPushConstants")]
        public unsafe partial void CmdPushConstants([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] ShaderStageFlags stageFlags, [Count(Count = 0)] uint offset, [Count(Count = 0)] uint size, [Count(Parameter = "size")] void* pValues);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPushConstants")]
        public partial void CmdPushConstants<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] ShaderStageFlags stageFlags, [Count(Count = 0)] uint offset, [Count(Count = 0)] uint size, [Count(Parameter = "size")] ref T0 pValues) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdResetEvent")]
        public partial void CmdResetEvent([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0)] PipelineStageFlags stageMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdResetQueryPool")]
        public partial void CmdResetQueryPool([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdResolveImage")]
        public unsafe partial void CmdResolveImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] ImageResolve* pRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdResolveImage")]
        public partial void CmdResolveImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Count = 0)] uint regionCount, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] in ImageResolve pRegions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetBlendConstants")]
        public unsafe partial void CmdSetBlendConstants([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 4), Flow(FlowDirection.In)] float* blendConstants);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetBlendConstants")]
        public partial void CmdSetBlendConstants([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 4), Flow(FlowDirection.In)] in float blendConstants);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBias")]
        public partial void CmdSetDepthBias([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float depthBiasConstantFactor, [Count(Count = 0)] float depthBiasClamp, [Count(Count = 0)] float depthBiasSlopeFactor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthBounds")]
        public partial void CmdSetDepthBounds([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float minDepthBounds, [Count(Count = 0)] float maxDepthBounds);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetEvent")]
        public partial void CmdSetEvent([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0)] PipelineStageFlags stageMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetLineWidth")]
        public partial void CmdSetLineWidth([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] float lineWidth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetScissor")]
        public unsafe partial void CmdSetScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstScissor, [Count(Count = 0)] uint scissorCount, [Count(Parameter = "scissorCount"), Flow(FlowDirection.In)] Rect2D* pScissors);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetScissor")]
        public partial void CmdSetScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstScissor, [Count(Count = 0)] uint scissorCount, [Count(Parameter = "scissorCount"), Flow(FlowDirection.In)] in Rect2D pScissors);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilCompareMask")]
        public partial void CmdSetStencilCompareMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] uint compareMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilReference")]
        public partial void CmdSetStencilReference([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] uint reference);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetStencilWriteMask")]
        public partial void CmdSetStencilWriteMask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] StencilFaceFlags faceMask, [Count(Count = 0)] uint writeMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewport")]
        public unsafe partial void CmdSetViewport([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(FlowDirection.In)] Viewport* pViewports);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewport")]
        public partial void CmdSetViewport([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(FlowDirection.In)] in Viewport pViewports);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdUpdateBuffer")]
        public unsafe partial void CmdUpdateBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong dataSize, [Count(Parameter = "dataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdUpdateBuffer")]
        public partial void CmdUpdateBuffer<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] ulong dataSize, [Count(Parameter = "dataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] in ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] in BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] in BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] in ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] in MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] in MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] in ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] in MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] in BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] in MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] in BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] in ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] in Event pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] in Event pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] in ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] in Event pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] in BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] in Event pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] in BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] in ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] in Event pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] in MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] in Event pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] in MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] in ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public unsafe partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] in Event pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] in MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] in BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents")]
        public partial void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] in Event pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] in MemoryBarrier pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] in BufferMemoryBarrier pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] in ImageMemoryBarrier pImageMemoryBarriers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteTimestamp")]
        public partial void CmdWriteTimestamp([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags pipelineStage, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBuffer")]
        public unsafe partial Result CreateBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Buffer* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBuffer")]
        public unsafe partial Result CreateBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Buffer pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBuffer")]
        public unsafe partial Result CreateBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Buffer* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBuffer")]
        public unsafe partial Result CreateBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Buffer pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBuffer")]
        public unsafe partial Result CreateBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Buffer* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBuffer")]
        public unsafe partial Result CreateBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Buffer pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBuffer")]
        public unsafe partial Result CreateBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Buffer* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBuffer")]
        public partial Result CreateBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Buffer pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferView")]
        public unsafe partial Result CreateBufferView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] BufferView* pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferView")]
        public unsafe partial Result CreateBufferView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out BufferView pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferView")]
        public unsafe partial Result CreateBufferView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] BufferView* pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferView")]
        public unsafe partial Result CreateBufferView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out BufferView pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferView")]
        public unsafe partial Result CreateBufferView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferViewCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] BufferView* pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferView")]
        public unsafe partial Result CreateBufferView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferViewCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out BufferView pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferView")]
        public unsafe partial Result CreateBufferView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferViewCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] BufferView* pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateBufferView")]
        public partial Result CreateBufferView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in BufferViewCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out BufferView pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCommandPool")]
        public unsafe partial Result CreateCommandPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CommandPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] CommandPool* pCommandPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCommandPool")]
        public unsafe partial Result CreateCommandPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CommandPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out CommandPool pCommandPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCommandPool")]
        public unsafe partial Result CreateCommandPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CommandPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] CommandPool* pCommandPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCommandPool")]
        public unsafe partial Result CreateCommandPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CommandPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out CommandPool pCommandPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCommandPool")]
        public unsafe partial Result CreateCommandPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in CommandPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] CommandPool* pCommandPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCommandPool")]
        public unsafe partial Result CreateCommandPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in CommandPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out CommandPool pCommandPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCommandPool")]
        public unsafe partial Result CreateCommandPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in CommandPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] CommandPool* pCommandPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCommandPool")]
        public partial Result CreateCommandPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in CommandPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out CommandPool pCommandPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateComputePipelines")]
        public unsafe partial Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateComputePipelines")]
        public unsafe partial Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateComputePipelines")]
        public unsafe partial Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateComputePipelines")]
        public unsafe partial Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateComputePipelines")]
        public unsafe partial Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] in ComputePipelineCreateInfo pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateComputePipelines")]
        public unsafe partial Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] in ComputePipelineCreateInfo pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateComputePipelines")]
        public unsafe partial Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] in ComputePipelineCreateInfo pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateComputePipelines")]
        public partial Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] in ComputePipelineCreateInfo pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorPool")]
        public unsafe partial Result CreateDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorPool* pDescriptorPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorPool")]
        public unsafe partial Result CreateDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorPool pDescriptorPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorPool")]
        public unsafe partial Result CreateDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorPool* pDescriptorPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorPool")]
        public unsafe partial Result CreateDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorPool pDescriptorPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorPool")]
        public unsafe partial Result CreateDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorPool* pDescriptorPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorPool")]
        public unsafe partial Result CreateDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorPool pDescriptorPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorPool")]
        public unsafe partial Result CreateDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorPool* pDescriptorPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorPool")]
        public partial Result CreateDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorPool pDescriptorPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorSetLayout")]
        public unsafe partial Result CreateDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayout* pSetLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorSetLayout")]
        public unsafe partial Result CreateDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorSetLayout pSetLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorSetLayout")]
        public unsafe partial Result CreateDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayout* pSetLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorSetLayout")]
        public unsafe partial Result CreateDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorSetLayout pSetLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorSetLayout")]
        public unsafe partial Result CreateDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorSetLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayout* pSetLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorSetLayout")]
        public unsafe partial Result CreateDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorSetLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorSetLayout pSetLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorSetLayout")]
        public unsafe partial Result CreateDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorSetLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DescriptorSetLayout* pSetLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDescriptorSetLayout")]
        public partial Result CreateDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DescriptorSetLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DescriptorSetLayout pSetLayout);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        [NativeApi(EntryPoint = "vkCreateDevice")]
        public unsafe partial Result CreateDevice([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] DeviceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Device* pDevice);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        [NativeApi(EntryPoint = "vkCreateDevice")]
        public unsafe partial Result CreateDevice([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] DeviceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Device pDevice);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        [NativeApi(EntryPoint = "vkCreateDevice")]
        public unsafe partial Result CreateDevice([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] DeviceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Device* pDevice);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        [NativeApi(EntryPoint = "vkCreateDevice")]
        public unsafe partial Result CreateDevice([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] DeviceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Device pDevice);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        [NativeApi(EntryPoint = "vkCreateDevice")]
        public unsafe partial Result CreateDevice([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in DeviceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Device* pDevice);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        [NativeApi(EntryPoint = "vkCreateDevice")]
        public unsafe partial Result CreateDevice([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in DeviceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Device pDevice);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        [NativeApi(EntryPoint = "vkCreateDevice")]
        public unsafe partial Result CreateDevice([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in DeviceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Device* pDevice);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentDevice = *%$PARAM(pDevice)$%; }")]
        [NativeApi(EntryPoint = "vkCreateDevice")]
        public partial Result CreateDevice([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in DeviceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Device pDevice);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateEvent")]
        public unsafe partial Result CreateEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] EventCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Event* pEvent);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateEvent")]
        public unsafe partial Result CreateEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] EventCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Event pEvent);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateEvent")]
        public unsafe partial Result CreateEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] EventCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Event* pEvent);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateEvent")]
        public unsafe partial Result CreateEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] EventCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Event pEvent);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateEvent")]
        public unsafe partial Result CreateEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in EventCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Event* pEvent);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateEvent")]
        public unsafe partial Result CreateEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in EventCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Event pEvent);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateEvent")]
        public unsafe partial Result CreateEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in EventCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Event* pEvent);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateEvent")]
        public partial Result CreateEvent([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in EventCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Event pEvent);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFence")]
        public unsafe partial Result CreateFence([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FenceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Fence* pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFence")]
        public unsafe partial Result CreateFence([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FenceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Fence pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFence")]
        public unsafe partial Result CreateFence([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FenceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Fence* pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFence")]
        public unsafe partial Result CreateFence([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FenceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Fence pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFence")]
        public unsafe partial Result CreateFence([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in FenceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Fence* pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFence")]
        public unsafe partial Result CreateFence([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in FenceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Fence pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFence")]
        public unsafe partial Result CreateFence([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in FenceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Fence* pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFence")]
        public partial Result CreateFence([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in FenceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Fence pFence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFramebuffer")]
        public unsafe partial Result CreateFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FramebufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Framebuffer* pFramebuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFramebuffer")]
        public unsafe partial Result CreateFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FramebufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Framebuffer pFramebuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFramebuffer")]
        public unsafe partial Result CreateFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FramebufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Framebuffer* pFramebuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFramebuffer")]
        public unsafe partial Result CreateFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FramebufferCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Framebuffer pFramebuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFramebuffer")]
        public unsafe partial Result CreateFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in FramebufferCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Framebuffer* pFramebuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFramebuffer")]
        public unsafe partial Result CreateFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in FramebufferCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Framebuffer pFramebuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFramebuffer")]
        public unsafe partial Result CreateFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in FramebufferCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Framebuffer* pFramebuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateFramebuffer")]
        public partial Result CreateFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in FramebufferCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Framebuffer pFramebuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateGraphicsPipelines")]
        public unsafe partial Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] GraphicsPipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateGraphicsPipelines")]
        public unsafe partial Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] GraphicsPipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateGraphicsPipelines")]
        public unsafe partial Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] GraphicsPipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateGraphicsPipelines")]
        public unsafe partial Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] GraphicsPipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateGraphicsPipelines")]
        public unsafe partial Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] in GraphicsPipelineCreateInfo pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateGraphicsPipelines")]
        public unsafe partial Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] in GraphicsPipelineCreateInfo pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateGraphicsPipelines")]
        public unsafe partial Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] in GraphicsPipelineCreateInfo pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateGraphicsPipelines")]
        public partial Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] in GraphicsPipelineCreateInfo pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImage")]
        public unsafe partial Result CreateImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Image* pImage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImage")]
        public unsafe partial Result CreateImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Image pImage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImage")]
        public unsafe partial Result CreateImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Image* pImage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImage")]
        public unsafe partial Result CreateImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Image pImage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImage")]
        public unsafe partial Result CreateImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImageCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Image* pImage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImage")]
        public unsafe partial Result CreateImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImageCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Image pImage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImage")]
        public unsafe partial Result CreateImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImageCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Image* pImage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImage")]
        public partial Result CreateImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImageCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Image pImage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImageView")]
        public unsafe partial Result CreateImageView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ImageView* pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImageView")]
        public unsafe partial Result CreateImageView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageView pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImageView")]
        public unsafe partial Result CreateImageView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ImageView* pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImageView")]
        public unsafe partial Result CreateImageView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImageViewCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageView pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImageView")]
        public unsafe partial Result CreateImageView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImageViewCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ImageView* pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImageView")]
        public unsafe partial Result CreateImageView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImageViewCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageView pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImageView")]
        public unsafe partial Result CreateImageView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImageViewCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ImageView* pView);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateImageView")]
        public partial Result CreateImageView([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImageViewCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageView pView);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        [NativeApi(EntryPoint = "vkCreateInstance")]
        public unsafe partial Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] InstanceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Instance* pInstance);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        [NativeApi(EntryPoint = "vkCreateInstance")]
        public unsafe partial Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] InstanceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Instance pInstance);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        [NativeApi(EntryPoint = "vkCreateInstance")]
        public unsafe partial Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] InstanceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Instance* pInstance);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        [NativeApi(EntryPoint = "vkCreateInstance")]
        public unsafe partial Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] InstanceCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Instance pInstance);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        [NativeApi(EntryPoint = "vkCreateInstance")]
        public unsafe partial Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] in InstanceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Instance* pInstance);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        [NativeApi(EntryPoint = "vkCreateInstance")]
        public unsafe partial Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] in InstanceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Instance pInstance);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        [NativeApi(EntryPoint = "vkCreateInstance")]
        public unsafe partial Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] in InstanceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Instance* pInstance);

        /// <summary>To be documented.</summary>
        [Inject((SilkTouchStage) 6, "if (%$RESULT$% == Result.Success) { CurrentInstance = *%$PARAM(pInstance)$%; }")]
        [NativeApi(EntryPoint = "vkCreateInstance")]
        public partial Result CreateInstance([Count(Count = 0), Flow(FlowDirection.In)] in InstanceCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Instance pInstance);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineCache")]
        public unsafe partial Result CreatePipelineCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineCacheCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PipelineCache* pPipelineCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineCache")]
        public unsafe partial Result CreatePipelineCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineCacheCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PipelineCache pPipelineCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineCache")]
        public unsafe partial Result CreatePipelineCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineCacheCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PipelineCache* pPipelineCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineCache")]
        public unsafe partial Result CreatePipelineCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineCacheCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PipelineCache pPipelineCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineCache")]
        public unsafe partial Result CreatePipelineCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineCacheCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PipelineCache* pPipelineCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineCache")]
        public unsafe partial Result CreatePipelineCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineCacheCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PipelineCache pPipelineCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineCache")]
        public unsafe partial Result CreatePipelineCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineCacheCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PipelineCache* pPipelineCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineCache")]
        public partial Result CreatePipelineCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineCacheCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PipelineCache pPipelineCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineLayout")]
        public unsafe partial Result CreatePipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PipelineLayout* pPipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineLayout")]
        public unsafe partial Result CreatePipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PipelineLayout pPipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineLayout")]
        public unsafe partial Result CreatePipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PipelineLayout* pPipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineLayout")]
        public unsafe partial Result CreatePipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PipelineLayout pPipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineLayout")]
        public unsafe partial Result CreatePipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PipelineLayout* pPipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineLayout")]
        public unsafe partial Result CreatePipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PipelineLayout pPipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineLayout")]
        public unsafe partial Result CreatePipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PipelineLayout* pPipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePipelineLayout")]
        public partial Result CreatePipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineLayoutCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PipelineLayout pPipelineLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateQueryPool")]
        public unsafe partial Result CreateQueryPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] QueryPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] QueryPool* pQueryPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateQueryPool")]
        public unsafe partial Result CreateQueryPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] QueryPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out QueryPool pQueryPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateQueryPool")]
        public unsafe partial Result CreateQueryPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] QueryPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] QueryPool* pQueryPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateQueryPool")]
        public unsafe partial Result CreateQueryPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] QueryPoolCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out QueryPool pQueryPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateQueryPool")]
        public unsafe partial Result CreateQueryPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in QueryPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] QueryPool* pQueryPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateQueryPool")]
        public unsafe partial Result CreateQueryPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in QueryPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out QueryPool pQueryPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateQueryPool")]
        public unsafe partial Result CreateQueryPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in QueryPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] QueryPool* pQueryPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateQueryPool")]
        public partial Result CreateQueryPool([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in QueryPoolCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out QueryPool pQueryPool);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass")]
        public unsafe partial Result CreateRenderPass([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass")]
        public unsafe partial Result CreateRenderPass([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out RenderPass pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass")]
        public unsafe partial Result CreateRenderPass([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass")]
        public unsafe partial Result CreateRenderPass([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] RenderPassCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out RenderPass pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass")]
        public unsafe partial Result CreateRenderPass([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in RenderPassCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass")]
        public unsafe partial Result CreateRenderPass([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in RenderPassCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out RenderPass pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass")]
        public unsafe partial Result CreateRenderPass([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in RenderPassCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] RenderPass* pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRenderPass")]
        public partial Result CreateRenderPass([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in RenderPassCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out RenderPass pRenderPass);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSampler")]
        public unsafe partial Result CreateSampler([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Sampler* pSampler);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSampler")]
        public unsafe partial Result CreateSampler([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Sampler pSampler);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSampler")]
        public unsafe partial Result CreateSampler([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Sampler* pSampler);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSampler")]
        public unsafe partial Result CreateSampler([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Sampler pSampler);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSampler")]
        public unsafe partial Result CreateSampler([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SamplerCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Sampler* pSampler);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSampler")]
        public unsafe partial Result CreateSampler([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SamplerCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Sampler pSampler);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSampler")]
        public unsafe partial Result CreateSampler([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SamplerCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Sampler* pSampler);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSampler")]
        public partial Result CreateSampler([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SamplerCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Sampler pSampler);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSemaphore")]
        public unsafe partial Result CreateSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Semaphore* pSemaphore);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSemaphore")]
        public unsafe partial Result CreateSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Semaphore pSemaphore);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSemaphore")]
        public unsafe partial Result CreateSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Semaphore* pSemaphore);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSemaphore")]
        public unsafe partial Result CreateSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Semaphore pSemaphore);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSemaphore")]
        public unsafe partial Result CreateSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SemaphoreCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Semaphore* pSemaphore);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSemaphore")]
        public unsafe partial Result CreateSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SemaphoreCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Semaphore pSemaphore);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSemaphore")]
        public unsafe partial Result CreateSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SemaphoreCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Semaphore* pSemaphore);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSemaphore")]
        public partial Result CreateSemaphore([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SemaphoreCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out Semaphore pSemaphore);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateShaderModule")]
        public unsafe partial Result CreateShaderModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ShaderModuleCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ShaderModule* pShaderModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateShaderModule")]
        public unsafe partial Result CreateShaderModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ShaderModuleCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ShaderModule pShaderModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateShaderModule")]
        public unsafe partial Result CreateShaderModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ShaderModuleCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ShaderModule* pShaderModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateShaderModule")]
        public unsafe partial Result CreateShaderModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ShaderModuleCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ShaderModule pShaderModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateShaderModule")]
        public unsafe partial Result CreateShaderModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ShaderModuleCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ShaderModule* pShaderModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateShaderModule")]
        public unsafe partial Result CreateShaderModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ShaderModuleCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ShaderModule pShaderModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateShaderModule")]
        public unsafe partial Result CreateShaderModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ShaderModuleCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ShaderModule* pShaderModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateShaderModule")]
        public partial Result CreateShaderModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ShaderModuleCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ShaderModule pShaderModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyBuffer")]
        public unsafe partial void DestroyBuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyBuffer")]
        public partial void DestroyBuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyBufferView")]
        public unsafe partial void DestroyBufferView([Count(Count = 0)] Device device, [Count(Count = 0)] BufferView bufferView, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyBufferView")]
        public partial void DestroyBufferView([Count(Count = 0)] Device device, [Count(Count = 0)] BufferView bufferView, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyCommandPool")]
        public unsafe partial void DestroyCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyCommandPool")]
        public partial void DestroyCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorPool")]
        public unsafe partial void DestroyDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorPool")]
        public partial void DestroyDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorSetLayout")]
        public unsafe partial void DestroyDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout descriptorSetLayout, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDescriptorSetLayout")]
        public partial void DestroyDescriptorSetLayout([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorSetLayout descriptorSetLayout, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDevice")]
        public unsafe partial void DestroyDevice([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDevice")]
        public partial void DestroyDevice([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyEvent")]
        public unsafe partial void DestroyEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyEvent")]
        public partial void DestroyEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyFence")]
        public unsafe partial void DestroyFence([Count(Count = 0)] Device device, [Count(Count = 0)] Fence fence, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyFence")]
        public partial void DestroyFence([Count(Count = 0)] Device device, [Count(Count = 0)] Fence fence, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyFramebuffer")]
        public unsafe partial void DestroyFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyFramebuffer")]
        public partial void DestroyFramebuffer([Count(Count = 0)] Device device, [Count(Count = 0)] Framebuffer framebuffer, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyImage")]
        public unsafe partial void DestroyImage([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyImage")]
        public partial void DestroyImage([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyImageView")]
        public unsafe partial void DestroyImageView([Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyImageView")]
        public partial void DestroyImageView([Count(Count = 0)] Device device, [Count(Count = 0)] ImageView imageView, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyInstance")]
        public unsafe partial void DestroyInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyInstance")]
        public partial void DestroyInstance([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipeline")]
        public unsafe partial void DestroyPipeline([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipeline")]
        public partial void DestroyPipeline([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineCache")]
        public unsafe partial void DestroyPipelineCache([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineCache")]
        public partial void DestroyPipelineCache([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineLayout")]
        public unsafe partial void DestroyPipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineLayout pipelineLayout, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPipelineLayout")]
        public partial void DestroyPipelineLayout([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineLayout pipelineLayout, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyQueryPool")]
        public unsafe partial void DestroyQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyQueryPool")]
        public partial void DestroyQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyRenderPass")]
        public unsafe partial void DestroyRenderPass([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyRenderPass")]
        public partial void DestroyRenderPass([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroySampler")]
        public unsafe partial void DestroySampler([Count(Count = 0)] Device device, [Count(Count = 0)] Sampler sampler, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroySampler")]
        public partial void DestroySampler([Count(Count = 0)] Device device, [Count(Count = 0)] Sampler sampler, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroySemaphore")]
        public unsafe partial void DestroySemaphore([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroySemaphore")]
        public partial void DestroySemaphore([Count(Count = 0)] Device device, [Count(Count = 0)] Semaphore semaphore, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyShaderModule")]
        public unsafe partial void DestroyShaderModule([Count(Count = 0)] Device device, [Count(Count = 0)] ShaderModule shaderModule, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyShaderModule")]
        public partial void DestroyShaderModule([Count(Count = 0)] Device device, [Count(Count = 0)] ShaderModule shaderModule, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDeviceWaitIdle")]
        public partial Result DeviceWaitIdle([Count(Count = 0)] Device device);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEndCommandBuffer")]
        public partial Result EndCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public unsafe partial Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public unsafe partial Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public unsafe partial Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public unsafe partial Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public unsafe partial Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in byte pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public unsafe partial Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in byte pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public unsafe partial Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in byte pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public partial Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in byte pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public unsafe partial Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public unsafe partial Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public unsafe partial Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public partial Result EnumerateDeviceExtensionProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceLayerProperties")]
        public unsafe partial Result EnumerateDeviceLayerProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] LayerProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceLayerProperties")]
        public unsafe partial Result EnumerateDeviceLayerProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ref LayerProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceLayerProperties")]
        public unsafe partial Result EnumerateDeviceLayerProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] LayerProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateDeviceLayerProperties")]
        public partial Result EnumerateDeviceLayerProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] ref LayerProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] in byte pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] in byte pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] in byte pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public partial Result EnumerateInstanceExtensionProperties([Count(Count = 0), Flow(FlowDirection.In)] in byte pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public unsafe partial Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] ExtensionProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public partial Result EnumerateInstanceExtensionProperties([Flow(FlowDirection.In)] string pLayerName, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] ref ExtensionProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceLayerProperties")]
        public unsafe partial Result EnumerateInstanceLayerProperties([Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] LayerProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceLayerProperties")]
        public unsafe partial Result EnumerateInstanceLayerProperties([Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount")] ref LayerProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceLayerProperties")]
        public unsafe partial Result EnumerateInstanceLayerProperties([Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] LayerProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumerateInstanceLayerProperties")]
        public partial Result EnumerateInstanceLayerProperties([Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount")] ref LayerProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDevices")]
        public unsafe partial Result EnumeratePhysicalDevices([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceCount, [Count(Parameter = "pPhysicalDeviceCount")] PhysicalDevice* pPhysicalDevices);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDevices")]
        public unsafe partial Result EnumeratePhysicalDevices([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceCount, [Count(Parameter = "pPhysicalDeviceCount")] ref PhysicalDevice pPhysicalDevices);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDevices")]
        public unsafe partial Result EnumeratePhysicalDevices([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref uint pPhysicalDeviceCount, [Count(Parameter = "pPhysicalDeviceCount")] PhysicalDevice* pPhysicalDevices);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDevices")]
        public partial Result EnumeratePhysicalDevices([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref uint pPhysicalDeviceCount, [Count(Parameter = "pPhysicalDeviceCount")] ref PhysicalDevice pPhysicalDevices);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkFlushMappedMemoryRanges")]
        public unsafe partial Result FlushMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Parameter = "memoryRangeCount"), Flow(FlowDirection.In)] MappedMemoryRange* pMemoryRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkFlushMappedMemoryRanges")]
        public partial Result FlushMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Parameter = "memoryRangeCount"), Flow(FlowDirection.In)] in MappedMemoryRange pMemoryRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkFreeCommandBuffers")]
        public unsafe partial void FreeCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint commandBufferCount, [Count(Parameter = "commandBufferCount"), Flow(FlowDirection.In)] CommandBuffer* pCommandBuffers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkFreeCommandBuffers")]
        public partial void FreeCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] uint commandBufferCount, [Count(Parameter = "commandBufferCount"), Flow(FlowDirection.In)] in CommandBuffer pCommandBuffers);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkFreeDescriptorSets")]
        public unsafe partial Result FreeDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0)] uint descriptorSetCount, [Count(Parameter = "descriptorSetCount"), Flow(FlowDirection.In)] DescriptorSet* pDescriptorSets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkFreeDescriptorSets")]
        public partial Result FreeDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0)] uint descriptorSetCount, [Count(Parameter = "descriptorSetCount"), Flow(FlowDirection.In)] in DescriptorSet pDescriptorSets);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkFreeMemory")]
        public unsafe partial void FreeMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkFreeMemory")]
        public partial void FreeMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements")]
        public unsafe partial void GetBufferMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferMemoryRequirements")]
        public partial void GetBufferMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Buffer buffer, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryCommitment")]
        public unsafe partial void GetDeviceMemoryCommitment([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pCommittedMemoryInBytes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryCommitment")]
        public partial void GetDeviceMemoryCommitment([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pCommittedMemoryInBytes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceProcAddr")]
        public unsafe partial PfnVoidFunction GetDeviceProcAddr([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] byte* pName);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceProcAddr")]
        public partial PfnVoidFunction GetDeviceProcAddr([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in byte pName);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceProcAddr")]
        public partial PfnVoidFunction GetDeviceProcAddr([Count(Count = 0)] Device device, [Flow(FlowDirection.In)] string pName);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue")]
        public unsafe partial void GetDeviceQueue([Count(Count = 0)] Device device, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint queueIndex, [Count(Count = 0), Flow(FlowDirection.Out)] Queue* pQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceQueue")]
        public partial void GetDeviceQueue([Count(Count = 0)] Device device, [Count(Count = 0)] uint queueFamilyIndex, [Count(Count = 0)] uint queueIndex, [Count(Count = 0), Flow(FlowDirection.Out)] out Queue pQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetEventStatus")]
        public partial Result GetEventStatus([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetFenceStatus")]
        public partial Result GetFenceStatus([Count(Count = 0)] Device device, [Count(Count = 0)] Fence fence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements")]
        public unsafe partial void GetImageMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageMemoryRequirements")]
        public partial void GetImageMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements")]
        public unsafe partial void GetImageSparseMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] SparseImageMemoryRequirements* pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements")]
        public unsafe partial void GetImageSparseMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] out SparseImageMemoryRequirements pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements")]
        public unsafe partial void GetImageSparseMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] SparseImageMemoryRequirements* pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSparseMemoryRequirements")]
        public partial void GetImageSparseMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0)] ref uint pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(FlowDirection.Out)] out SparseImageMemoryRequirements pSparseMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout")]
        public unsafe partial void GetImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ImageSubresource* pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] SubresourceLayout* pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout")]
        public unsafe partial void GetImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ImageSubresource* pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] out SubresourceLayout pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout")]
        public unsafe partial void GetImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] in ImageSubresource pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] SubresourceLayout* pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout")]
        public partial void GetImageSubresourceLayout([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] in ImageSubresource pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] out SubresourceLayout pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetInstanceProcAddr")]
        public unsafe partial PfnVoidFunction GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] byte* pName);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetInstanceProcAddr")]
        public partial PfnVoidFunction GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in byte pName);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetInstanceProcAddr")]
        public partial PfnVoidFunction GetInstanceProcAddr([Count(Count = 0)] Instance instance, [Flow(FlowDirection.In)] string pName);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures")]
        public unsafe partial void GetPhysicalDeviceFeatures([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceFeatures* pFeatures);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures")]
        public partial void GetPhysicalDeviceFeatures([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceFeatures pFeatures);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
        public unsafe partial void GetPhysicalDeviceFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] FormatProperties* pFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
        public partial void GetPhysicalDeviceFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] out FormatProperties pFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
        public unsafe partial Result GetPhysicalDeviceImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0), Flow(FlowDirection.Out)] ImageFormatProperties* pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
        public partial Result GetPhysicalDeviceImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageFormatProperties pImageFormatProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
        public unsafe partial void GetPhysicalDeviceMemoryProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceMemoryProperties* pMemoryProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
        public partial void GetPhysicalDeviceMemoryProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceMemoryProperties pMemoryProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties")]
        public unsafe partial void GetPhysicalDeviceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties")]
        public partial void GetPhysicalDeviceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        public unsafe partial void GetPhysicalDeviceQueueFamilyProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] QueueFamilyProperties* pQueueFamilyProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        public unsafe partial void GetPhysicalDeviceQueueFamilyProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] out QueueFamilyProperties pQueueFamilyProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        public unsafe partial void GetPhysicalDeviceQueueFamilyProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] QueueFamilyProperties* pQueueFamilyProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        public partial void GetPhysicalDeviceQueueFamilyProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pQueueFamilyPropertyCount, [Count(Parameter = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] out QueueFamilyProperties pQueueFamilyProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        public unsafe partial void GetPhysicalDeviceSparseImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        public partial void GetPhysicalDeviceSparseImageFormatProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] SampleCountFlags samples, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineCacheData")]
        public unsafe partial Result GetPipelineCacheData([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineCacheData")]
        public unsafe partial Result GetPipelineCacheData<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineCacheData")]
        public unsafe partial Result GetPipelineCacheData([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] ref nuint pDataSize, [Count(Parameter = "pDataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineCacheData")]
        public partial Result GetPipelineCacheData<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] ref nuint pDataSize, [Count(Parameter = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetQueryPoolResults")]
        public unsafe partial Result GetQueryPoolResults([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetQueryPoolResults")]
        public partial Result GetQueryPoolResults<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] ref T0 pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRenderAreaGranularity")]
        public unsafe partial void GetRenderAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.Out)] Extent2D* pGranularity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRenderAreaGranularity")]
        public partial void GetRenderAreaGranularity([Count(Count = 0)] Device device, [Count(Count = 0)] RenderPass renderPass, [Count(Count = 0), Flow(FlowDirection.Out)] out Extent2D pGranularity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkInvalidateMappedMemoryRanges")]
        public unsafe partial Result InvalidateMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Parameter = "memoryRangeCount"), Flow(FlowDirection.In)] MappedMemoryRange* pMemoryRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkInvalidateMappedMemoryRanges")]
        public partial Result InvalidateMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Count = 0)] uint memoryRangeCount, [Count(Parameter = "memoryRangeCount"), Flow(FlowDirection.In)] in MappedMemoryRange pMemoryRanges);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkMapMemory")]
        public unsafe partial Result MapMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong offset, [Count(Count = 0)] ulong size, [Count(Count = 0)] uint flags, [Count(Count = 0)] void** ppData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkMapMemory")]
        public unsafe partial Result MapMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ulong offset, [Count(Count = 0)] ulong size, [Count(Count = 0)] uint flags, [Count(Count = 0)] ref void* ppData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkMergePipelineCaches")]
        public unsafe partial Result MergePipelineCaches([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Parameter = "srcCacheCount"), Flow(FlowDirection.In)] PipelineCache* pSrcCaches);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkMergePipelineCaches")]
        public partial Result MergePipelineCaches([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Parameter = "srcCacheCount"), Flow(FlowDirection.In)] in PipelineCache pSrcCaches);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueBindSparse")]
        public unsafe partial Result QueueBindSparse([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(FlowDirection.In)] BindSparseInfo* pBindInfo, [Count(Count = 0)] Fence fence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueBindSparse")]
        public partial Result QueueBindSparse([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(FlowDirection.In)] in BindSparseInfo pBindInfo, [Count(Count = 0)] Fence fence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueSubmit")]
        public unsafe partial Result QueueSubmit([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint submitCount, [Count(Parameter = "submitCount"), Flow(FlowDirection.In)] SubmitInfo* pSubmits, [Count(Count = 0)] Fence fence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueSubmit")]
        public partial Result QueueSubmit([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint submitCount, [Count(Parameter = "submitCount"), Flow(FlowDirection.In)] in SubmitInfo pSubmits, [Count(Count = 0)] Fence fence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueWaitIdle")]
        public partial Result QueueWaitIdle([Count(Count = 0)] Queue queue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkResetCommandBuffer")]
        public partial Result ResetCommandBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CommandBufferResetFlags flags);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkResetCommandPool")]
        public partial Result ResetCommandPool([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Count = 0)] CommandPoolResetFlags flags);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkResetDescriptorPool")]
        public partial Result ResetDescriptorPool([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Count = 0)] uint flags);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkResetEvent")]
        public partial Result ResetEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkResetFences")]
        public unsafe partial Result ResetFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Parameter = "fenceCount"), Flow(FlowDirection.In)] Fence* pFences);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkResetFences")]
        public partial Result ResetFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Parameter = "fenceCount"), Flow(FlowDirection.In)] in Fence pFences);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetEvent")]
        public partial Result SetEvent([Count(Count = 0)] Device device, [Count(Count = 0)] Event @event);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUnmapMemory")]
        public partial void UnmapMemory([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSets")]
        public unsafe partial void UpdateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] uint descriptorWriteCount, [Count(Parameter = "descriptorWriteCount"), Flow(FlowDirection.In)] WriteDescriptorSet* pDescriptorWrites, [Count(Count = 0)] uint descriptorCopyCount, [Count(Parameter = "descriptorCopyCount"), Flow(FlowDirection.In)] CopyDescriptorSet* pDescriptorCopies);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSets")]
        public unsafe partial void UpdateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] uint descriptorWriteCount, [Count(Parameter = "descriptorWriteCount"), Flow(FlowDirection.In)] WriteDescriptorSet* pDescriptorWrites, [Count(Count = 0)] uint descriptorCopyCount, [Count(Parameter = "descriptorCopyCount"), Flow(FlowDirection.In)] in CopyDescriptorSet pDescriptorCopies);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSets")]
        public unsafe partial void UpdateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] uint descriptorWriteCount, [Count(Parameter = "descriptorWriteCount"), Flow(FlowDirection.In)] in WriteDescriptorSet pDescriptorWrites, [Count(Count = 0)] uint descriptorCopyCount, [Count(Parameter = "descriptorCopyCount"), Flow(FlowDirection.In)] CopyDescriptorSet* pDescriptorCopies);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUpdateDescriptorSets")]
        public partial void UpdateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] uint descriptorWriteCount, [Count(Parameter = "descriptorWriteCount"), Flow(FlowDirection.In)] in WriteDescriptorSet pDescriptorWrites, [Count(Count = 0)] uint descriptorCopyCount, [Count(Parameter = "descriptorCopyCount"), Flow(FlowDirection.In)] in CopyDescriptorSet pDescriptorCopies);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWaitForFences")]
        public unsafe partial Result WaitForFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Parameter = "fenceCount"), Flow(FlowDirection.In)] Fence* pFences, [Count(Count = 0)] Bool32 waitAll, [Count(Count = 0)] ulong timeout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkWaitForFences")]
        public partial Result WaitForFences([Count(Count = 0)] Device device, [Count(Count = 0)] uint fenceCount, [Count(Parameter = "fenceCount"), Flow(FlowDirection.In)] in Fence pFences, [Count(Count = 0)] Bool32 waitAll, [Count(Count = 0)] ulong timeout);

        /// <summary>To be documented.</summary>
        public unsafe Result BindBufferMemory2([Count(Count = 0)] Device device, [Count(Parameter = "bindInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<BindBufferMemoryInfo> pBindInfos)
        {
            // ImplicitCountSpanOverloader
            return BindBufferMemory2(device, (uint) pBindInfos.Length, in pBindInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result BindImageMemory2([Count(Count = 0)] Device device, [Count(Parameter = "bindInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<BindImageMemoryInfo> pBindInfos)
        {
            // ImplicitCountSpanOverloader
            return BindImageMemory2(device, (uint) pBindInfos.Length, in pBindInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe PhysicalDeviceFeatures2 GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceFeatures2 ret = default;
            GetPhysicalDeviceFeatures2(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public unsafe PhysicalDeviceMemoryProperties2 GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceMemoryProperties2 ret = default;
            GetPhysicalDeviceMemoryProperties2(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public unsafe PhysicalDeviceProperties2 GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceProperties2 ret = default;
            GetPhysicalDeviceProperties2(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindDescriptorSets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Count = 0)] uint descriptorSetCount, [Count(Parameter = "descriptorSetCount"), Flow(FlowDirection.In)] DescriptorSet* pDescriptorSets, [Count(Parameter = "dynamicOffsetCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> pDynamicOffsets)
        {
            // ImplicitCountSpanOverloader
            CmdBindDescriptorSets(commandBuffer, pipelineBindPoint, layout, firstSet, descriptorSetCount, pDescriptorSets, (uint) pDynamicOffsets.Length, in pDynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindDescriptorSets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Parameter = "descriptorSetCount"), Flow(FlowDirection.In)] ReadOnlySpan<DescriptorSet> pDescriptorSets, [Count(Count = 0)] uint dynamicOffsetCount, [Count(Parameter = "dynamicOffsetCount"), Flow(FlowDirection.In)] uint* pDynamicOffsets)
        {
            // ImplicitCountSpanOverloader
            CmdBindDescriptorSets(commandBuffer, pipelineBindPoint, layout, firstSet, (uint) pDescriptorSets.Length, in pDescriptorSets.GetPinnableReference(), dynamicOffsetCount, pDynamicOffsets);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindDescriptorSets([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint firstSet, [Count(Parameter = "descriptorSetCount"), Flow(FlowDirection.In)] ReadOnlySpan<DescriptorSet> pDescriptorSets, [Count(Parameter = "dynamicOffsetCount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> pDynamicOffsets)
        {
            // ImplicitCountSpanOverloader
            CmdBindDescriptorSets(commandBuffer, pipelineBindPoint, layout, firstSet, (uint) pDescriptorSets.Length, in pDescriptorSets.GetPinnableReference(), (uint) pDynamicOffsets.Length, in pDynamicOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers(commandBuffer, firstBinding, (uint) pOffsets.Length, pBuffers, in pOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers(commandBuffer, firstBinding, (uint) pBuffers.Length, in pBuffers.GetPinnableReference(), pOffsets);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBindVertexBuffers([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Parameter = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets)
        {
            // ImplicitCountSpanOverloader
            CmdBindVertexBuffers(commandBuffer, firstBinding, (uint) pOffsets.Length, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdBlitImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageBlit> pRegions, [Count(Count = 0)] Filter filter)
        {
            // ImplicitCountSpanOverloader
            CmdBlitImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, (uint) pRegions.Length, in pRegions.GetPinnableReference(), filter);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdClearAttachments([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(FlowDirection.In)] ClearAttachment* pAttachments, [Count(Parameter = "rectCount"), Flow(FlowDirection.In)] ReadOnlySpan<ClearRect> pRects)
        {
            // ImplicitCountSpanOverloader
            CmdClearAttachments(commandBuffer, attachmentCount, pAttachments, (uint) pRects.Length, in pRects.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdClearAttachments([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "attachmentCount"), Flow(FlowDirection.In)] ReadOnlySpan<ClearAttachment> pAttachments, [Count(Count = 0)] uint rectCount, [Count(Parameter = "rectCount"), Flow(FlowDirection.In)] ClearRect* pRects)
        {
            // ImplicitCountSpanOverloader
            CmdClearAttachments(commandBuffer, (uint) pAttachments.Length, in pAttachments.GetPinnableReference(), rectCount, pRects);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdClearAttachments([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "attachmentCount"), Flow(FlowDirection.In)] ReadOnlySpan<ClearAttachment> pAttachments, [Count(Parameter = "rectCount"), Flow(FlowDirection.In)] ReadOnlySpan<ClearRect> pRects)
        {
            // ImplicitCountSpanOverloader
            CmdClearAttachments(commandBuffer, (uint) pAttachments.Length, in pAttachments.GetPinnableReference(), (uint) pRects.Length, in pRects.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdClearColorImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ClearColorValue* pColor, [Count(Parameter = "rangeCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageSubresourceRange> pRanges)
        {
            // ImplicitCountSpanOverloader
            CmdClearColorImage(commandBuffer, image, imageLayout, pColor, (uint) pRanges.Length, in pRanges.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdClearColorImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] in ClearColorValue pColor, [Count(Parameter = "rangeCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageSubresourceRange> pRanges)
        {
            // ImplicitCountSpanOverloader
            CmdClearColorImage(commandBuffer, image, imageLayout, in pColor, (uint) pRanges.Length, in pRanges.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdClearDepthStencilImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] ClearDepthStencilValue* pDepthStencil, [Count(Parameter = "rangeCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageSubresourceRange> pRanges)
        {
            // ImplicitCountSpanOverloader
            CmdClearDepthStencilImage(commandBuffer, image, imageLayout, pDepthStencil, (uint) pRanges.Length, in pRanges.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdClearDepthStencilImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image image, [Count(Count = 0)] ImageLayout imageLayout, [Count(Count = 0), Flow(FlowDirection.In)] in ClearDepthStencilValue pDepthStencil, [Count(Parameter = "rangeCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageSubresourceRange> pRanges)
        {
            // ImplicitCountSpanOverloader
            CmdClearDepthStencilImage(commandBuffer, image, imageLayout, in pDepthStencil, (uint) pRanges.Length, in pRanges.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdCopyBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] ReadOnlySpan<BufferCopy> pRegions)
        {
            // ImplicitCountSpanOverloader
            CmdCopyBuffer(commandBuffer, srcBuffer, dstBuffer, (uint) pRegions.Length, in pRegions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdCopyBufferToImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer srcBuffer, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] ReadOnlySpan<BufferImageCopy> pRegions)
        {
            // ImplicitCountSpanOverloader
            CmdCopyBufferToImage(commandBuffer, srcBuffer, dstImage, dstImageLayout, (uint) pRegions.Length, in pRegions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdCopyImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageCopy> pRegions)
        {
            // ImplicitCountSpanOverloader
            CmdCopyImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, (uint) pRegions.Length, in pRegions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdCopyImageToBuffer([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Buffer dstBuffer, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] ReadOnlySpan<BufferImageCopy> pRegions)
        {
            // ImplicitCountSpanOverloader
            CmdCopyImageToBuffer(commandBuffer, srcImage, srcImageLayout, dstBuffer, (uint) pRegions.Length, in pRegions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdExecuteCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "commandBufferCount"), Flow(FlowDirection.In)] ReadOnlySpan<CommandBuffer> pCommandBuffers)
        {
            // ImplicitCountSpanOverloader
            CmdExecuteCommands(commandBuffer, (uint) pCommandBuffers.Length, in pCommandBuffers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, (uint) pImageMemoryBarriers.Length, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, (uint) pBufferMemoryBarriers.Length, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, pMemoryBarriers, (uint) pBufferMemoryBarriers.Length, in pBufferMemoryBarriers.GetPinnableReference(), (uint) pImageMemoryBarriers.Length, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, (uint) pMemoryBarriers.Length, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, (uint) pMemoryBarriers.Length, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, pBufferMemoryBarriers, (uint) pImageMemoryBarriers.Length, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, (uint) pMemoryBarriers.Length, in pMemoryBarriers.GetPinnableReference(), (uint) pBufferMemoryBarriers.Length, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdPipelineBarrier([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] DependencyFlags dependencyFlags, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags, (uint) pMemoryBarriers.Length, in pMemoryBarriers.GetPinnableReference(), (uint) pBufferMemoryBarriers.Length, in pBufferMemoryBarriers.GetPinnableReference(), (uint) pImageMemoryBarriers.Length, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdPushConstants<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] ShaderStageFlags stageFlags, [Count(Count = 0)] uint offset, [Count(Parameter = "size")] Span<T0> pValues) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CmdPushConstants(commandBuffer, layout, stageFlags, offset, (uint) (pValues.Length * Unsafe.SizeOf<T0>()), ref pValues.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdResolveImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Image srcImage, [Count(Count = 0)] ImageLayout srcImageLayout, [Count(Count = 0)] Image dstImage, [Count(Count = 0)] ImageLayout dstImageLayout, [Count(Parameter = "regionCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageResolve> pRegions)
        {
            // ImplicitCountSpanOverloader
            CmdResolveImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, (uint) pRegions.Length, in pRegions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetScissor([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstScissor, [Count(Parameter = "scissorCount"), Flow(FlowDirection.In)] ReadOnlySpan<Rect2D> pScissors)
        {
            // ImplicitCountSpanOverloader
            CmdSetScissor(commandBuffer, firstScissor, (uint) pScissors.Length, in pScissors.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetViewport([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Parameter = "viewportCount"), Flow(FlowDirection.In)] ReadOnlySpan<Viewport> pViewports)
        {
            // ImplicitCountSpanOverloader
            CmdSetViewport(commandBuffer, firstViewport, (uint) pViewports.Length, in pViewports.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdUpdateBuffer<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Parameter = "dataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CmdUpdateBuffer(commandBuffer, dstBuffer, dstOffset, (ulong) (pData.Length * Unsafe.SizeOf<T0>()), ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, (uint) pImageMemoryBarriers.Length, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, (uint) pBufferMemoryBarriers.Length, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, (uint) pBufferMemoryBarriers.Length, in pBufferMemoryBarriers.GetPinnableReference(), (uint) pImageMemoryBarriers.Length, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, (uint) pMemoryBarriers.Length, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, (uint) pMemoryBarriers.Length, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, pBufferMemoryBarriers, (uint) pImageMemoryBarriers.Length, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, (uint) pMemoryBarriers.Length, in pMemoryBarriers.GetPinnableReference(), (uint) pBufferMemoryBarriers.Length, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] Event* pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents(commandBuffer, eventCount, pEvents, srcStageMask, dstStageMask, (uint) pMemoryBarriers.Length, in pMemoryBarriers.GetPinnableReference(), (uint) pBufferMemoryBarriers.Length, in pBufferMemoryBarriers.GetPinnableReference(), (uint) pImageMemoryBarriers.Length, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents(commandBuffer, (uint) pEvents.Length, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents(commandBuffer, (uint) pEvents.Length, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, bufferMemoryBarrierCount, pBufferMemoryBarriers, (uint) pImageMemoryBarriers.Length, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents(commandBuffer, (uint) pEvents.Length, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, (uint) pBufferMemoryBarriers.Length, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Count = 0)] uint memoryBarrierCount, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] MemoryBarrier* pMemoryBarriers, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents(commandBuffer, (uint) pEvents.Length, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, memoryBarrierCount, pMemoryBarriers, (uint) pBufferMemoryBarriers.Length, in pBufferMemoryBarriers.GetPinnableReference(), (uint) pImageMemoryBarriers.Length, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents(commandBuffer, (uint) pEvents.Length, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, (uint) pMemoryBarriers.Length, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, pBufferMemoryBarriers, imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Count = 0)] uint bufferMemoryBarrierCount, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] BufferMemoryBarrier* pBufferMemoryBarriers, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents(commandBuffer, (uint) pEvents.Length, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, (uint) pMemoryBarriers.Length, in pMemoryBarriers.GetPinnableReference(), bufferMemoryBarrierCount, pBufferMemoryBarriers, (uint) pImageMemoryBarriers.Length, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Count = 0)] uint imageMemoryBarrierCount, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ImageMemoryBarrier* pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents(commandBuffer, (uint) pEvents.Length, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, (uint) pMemoryBarriers.Length, in pMemoryBarriers.GetPinnableReference(), (uint) pBufferMemoryBarriers.Length, in pBufferMemoryBarriers.GetPinnableReference(), imageMemoryBarrierCount, pImageMemoryBarriers);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "eventCount"), Flow(FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Count = 0)] PipelineStageFlags srcStageMask, [Count(Count = 0)] PipelineStageFlags dstStageMask, [Count(Parameter = "memoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<MemoryBarrier> pMemoryBarriers, [Count(Parameter = "bufferMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<BufferMemoryBarrier> pBufferMemoryBarriers, [Count(Parameter = "imageMemoryBarrierCount"), Flow(FlowDirection.In)] ReadOnlySpan<ImageMemoryBarrier> pImageMemoryBarriers)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents(commandBuffer, (uint) pEvents.Length, in pEvents.GetPinnableReference(), srcStageMask, dstStageMask, (uint) pMemoryBarriers.Length, in pMemoryBarriers.GetPinnableReference(), (uint) pBufferMemoryBarriers.Length, in pBufferMemoryBarriers.GetPinnableReference(), (uint) pImageMemoryBarriers.Length, in pImageMemoryBarriers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateComputePipelines(device, pipelineCache, (uint) pPipelines.Length, pCreateInfos, pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ComputePipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateComputePipelines(device, pipelineCache, (uint) pPipelines.Length, pCreateInfos, in pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<ComputePipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateComputePipelines(device, pipelineCache, (uint) pCreateInfos.Length, in pCreateInfos.GetPinnableReference(), pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<ComputePipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateComputePipelines(device, pipelineCache, (uint) pPipelines.Length, in pCreateInfos.GetPinnableReference(), pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<ComputePipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateComputePipelines(device, pipelineCache, (uint) pCreateInfos.Length, in pCreateInfos.GetPinnableReference(), in pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateComputePipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<ComputePipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateComputePipelines(device, pipelineCache, (uint) pPipelines.Length, in pCreateInfos.GetPinnableReference(), in pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] GraphicsPipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateGraphicsPipelines(device, pipelineCache, (uint) pPipelines.Length, pCreateInfos, pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] GraphicsPipelineCreateInfo* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateGraphicsPipelines(device, pipelineCache, (uint) pPipelines.Length, pCreateInfos, in pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<GraphicsPipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateGraphicsPipelines(device, pipelineCache, (uint) pCreateInfos.Length, in pCreateInfos.GetPinnableReference(), pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<GraphicsPipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateGraphicsPipelines(device, pipelineCache, (uint) pPipelines.Length, in pCreateInfos.GetPinnableReference(), pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<GraphicsPipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateGraphicsPipelines(device, pipelineCache, (uint) pCreateInfos.Length, in pCreateInfos.GetPinnableReference(), in pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateGraphicsPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<GraphicsPipelineCreateInfo> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateGraphicsPipelines(device, pipelineCache, (uint) pPipelines.Length, in pCreateInfos.GetPinnableReference(), in pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result FlushMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Parameter = "memoryRangeCount"), Flow(FlowDirection.In)] ReadOnlySpan<MappedMemoryRange> pMemoryRanges)
        {
            // ImplicitCountSpanOverloader
            return FlushMappedMemoryRanges(device, (uint) pMemoryRanges.Length, in pMemoryRanges.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void FreeCommandBuffers([Count(Count = 0)] Device device, [Count(Count = 0)] CommandPool commandPool, [Count(Parameter = "commandBufferCount"), Flow(FlowDirection.In)] ReadOnlySpan<CommandBuffer> pCommandBuffers)
        {
            // ImplicitCountSpanOverloader
            FreeCommandBuffers(device, commandPool, (uint) pCommandBuffers.Length, in pCommandBuffers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result FreeDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] DescriptorPool descriptorPool, [Count(Parameter = "descriptorSetCount"), Flow(FlowDirection.In)] ReadOnlySpan<DescriptorSet> pDescriptorSets)
        {
            // ImplicitCountSpanOverloader
            return FreeDescriptorSets(device, descriptorPool, (uint) pDescriptorSets.Length, in pDescriptorSets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe PhysicalDeviceFeatures GetPhysicalDeviceFeature([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceFeatures ret = default;
            GetPhysicalDeviceFeatures(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public unsafe PhysicalDeviceMemoryProperties GetPhysicalDeviceMemoryProperty([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceMemoryProperties ret = default;
            GetPhysicalDeviceMemoryProperties(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public unsafe PhysicalDeviceProperties GetPhysicalDeviceProperty([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceProperties ret = default;
            GetPhysicalDeviceProperties(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetQueryPoolResults<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount, [Count(Parameter = "dataSize")] Span<T0> pData, [Count(Count = 0)] ulong stride, [Count(Count = 0)] QueryResultFlags flags) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            return GetQueryPoolResults(device, queryPool, firstQuery, queryCount, (nuint) (pData.Length * Unsafe.SizeOf<T0>()), ref pData.GetPinnableReference(), stride, flags);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result InvalidateMappedMemoryRanges([Count(Count = 0)] Device device, [Count(Parameter = "memoryRangeCount"), Flow(FlowDirection.In)] ReadOnlySpan<MappedMemoryRange> pMemoryRanges)
        {
            // ImplicitCountSpanOverloader
            return InvalidateMappedMemoryRanges(device, (uint) pMemoryRanges.Length, in pMemoryRanges.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result MergePipelineCaches([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache dstCache, [Count(Parameter = "srcCacheCount"), Flow(FlowDirection.In)] ReadOnlySpan<PipelineCache> pSrcCaches)
        {
            // ImplicitCountSpanOverloader
            return MergePipelineCaches(device, dstCache, (uint) pSrcCaches.Length, in pSrcCaches.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result QueueBindSparse([Count(Count = 0)] Queue queue, [Count(Parameter = "bindInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<BindSparseInfo> pBindInfo, [Count(Count = 0)] Fence fence)
        {
            // ImplicitCountSpanOverloader
            return QueueBindSparse(queue, (uint) pBindInfo.Length, in pBindInfo.GetPinnableReference(), fence);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result QueueSubmit([Count(Count = 0)] Queue queue, [Count(Parameter = "submitCount"), Flow(FlowDirection.In)] ReadOnlySpan<SubmitInfo> pSubmits, [Count(Count = 0)] Fence fence)
        {
            // ImplicitCountSpanOverloader
            return QueueSubmit(queue, (uint) pSubmits.Length, in pSubmits.GetPinnableReference(), fence);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result ResetFences([Count(Count = 0)] Device device, [Count(Parameter = "fenceCount"), Flow(FlowDirection.In)] ReadOnlySpan<Fence> pFences)
        {
            // ImplicitCountSpanOverloader
            return ResetFences(device, (uint) pFences.Length, in pFences.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void UpdateDescriptorSets([Count(Count = 0)] Device device, [Count(Count = 0)] uint descriptorWriteCount, [Count(Parameter = "descriptorWriteCount"), Flow(FlowDirection.In)] WriteDescriptorSet* pDescriptorWrites, [Count(Parameter = "descriptorCopyCount"), Flow(FlowDirection.In)] ReadOnlySpan<CopyDescriptorSet> pDescriptorCopies)
        {
            // ImplicitCountSpanOverloader
            UpdateDescriptorSets(device, descriptorWriteCount, pDescriptorWrites, (uint) pDescriptorCopies.Length, in pDescriptorCopies.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void UpdateDescriptorSets([Count(Count = 0)] Device device, [Count(Parameter = "descriptorWriteCount"), Flow(FlowDirection.In)] ReadOnlySpan<WriteDescriptorSet> pDescriptorWrites, [Count(Count = 0)] uint descriptorCopyCount, [Count(Parameter = "descriptorCopyCount"), Flow(FlowDirection.In)] CopyDescriptorSet* pDescriptorCopies)
        {
            // ImplicitCountSpanOverloader
            UpdateDescriptorSets(device, (uint) pDescriptorWrites.Length, in pDescriptorWrites.GetPinnableReference(), descriptorCopyCount, pDescriptorCopies);
        }

        /// <summary>To be documented.</summary>
        public unsafe void UpdateDescriptorSets([Count(Count = 0)] Device device, [Count(Parameter = "descriptorWriteCount"), Flow(FlowDirection.In)] ReadOnlySpan<WriteDescriptorSet> pDescriptorWrites, [Count(Parameter = "descriptorCopyCount"), Flow(FlowDirection.In)] ReadOnlySpan<CopyDescriptorSet> pDescriptorCopies)
        {
            // ImplicitCountSpanOverloader
            UpdateDescriptorSets(device, (uint) pDescriptorWrites.Length, in pDescriptorWrites.GetPinnableReference(), (uint) pDescriptorCopies.Length, in pDescriptorCopies.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result WaitForFences([Count(Count = 0)] Device device, [Count(Parameter = "fenceCount"), Flow(FlowDirection.In)] ReadOnlySpan<Fence> pFences, [Count(Count = 0)] Bool32 waitAll, [Count(Count = 0)] ulong timeout)
        {
            // ImplicitCountSpanOverloader
            return WaitForFences(device, (uint) pFences.Length, in pFences.GetPinnableReference(), waitAll, timeout);
        }


        public Vk(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

