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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_ray_tracing")]
    public unsafe partial class NVRayTracing : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_ray_tracing";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindAccelerationStructureMemoryNV")]
        public unsafe partial Result BindAccelerationStructureMemory([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(FlowDirection.In)] BindAccelerationStructureMemoryInfoNV* pBindInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkBindAccelerationStructureMemoryNV")]
        public partial Result BindAccelerationStructureMemory([Count(Count = 0)] Device device, [Count(Count = 0)] uint bindInfoCount, [Count(Parameter = "bindInfoCount"), Flow(FlowDirection.In)] in BindAccelerationStructureMemoryInfoNV pBindInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureNV")]
        public unsafe partial void CmdBuildAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureInfoNV* pInfo, [Count(Count = 0)] Buffer instanceData, [Count(Count = 0)] ulong instanceOffset, [Count(Count = 0)] Bool32 update, [Count(Count = 0)] AccelerationStructureNV dst, [Count(Count = 0)] AccelerationStructureNV src, [Count(Count = 0)] Buffer scratch, [Count(Count = 0)] ulong scratchOffset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBuildAccelerationStructureNV")]
        public partial void CmdBuildAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureInfoNV pInfo, [Count(Count = 0)] Buffer instanceData, [Count(Count = 0)] ulong instanceOffset, [Count(Count = 0)] Bool32 update, [Count(Count = 0)] AccelerationStructureNV dst, [Count(Count = 0)] AccelerationStructureNV src, [Count(Count = 0)] Buffer scratch, [Count(Count = 0)] ulong scratchOffset);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCopyAccelerationStructureNV")]
        public partial void CmdCopyAccelerationStructure([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] AccelerationStructureNV dst, [Count(Count = 0)] AccelerationStructureNV src, [Count(Count = 0)] CopyAccelerationStructureModeKHR mode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysNV")]
        public partial void CmdTraceRays([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer raygenShaderBindingTableBuffer, [Count(Count = 0)] ulong raygenShaderBindingOffset, [Count(Count = 0)] Buffer missShaderBindingTableBuffer, [Count(Count = 0)] ulong missShaderBindingOffset, [Count(Count = 0)] ulong missShaderBindingStride, [Count(Count = 0)] Buffer hitShaderBindingTableBuffer, [Count(Count = 0)] ulong hitShaderBindingOffset, [Count(Count = 0)] ulong hitShaderBindingStride, [Count(Count = 0)] Buffer callableShaderBindingTableBuffer, [Count(Count = 0)] ulong callableShaderBindingOffset, [Count(Count = 0)] ulong callableShaderBindingStride, [Count(Count = 0)] uint width, [Count(Count = 0)] uint height, [Count(Count = 0)] uint depth);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesNV")]
        public unsafe partial void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(FlowDirection.In)] AccelerationStructureNV* pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesNV")]
        public partial void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint accelerationStructureCount, [Count(Parameter = "accelerationStructureCount"), Flow(FlowDirection.In)] in AccelerationStructureNV pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCompileDeferredNV")]
        public partial Result CompileDeferred([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint shader);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureNV")]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureNV* pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureNV")]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureNV pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureNV")]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureNV* pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureNV")]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureNV pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureNV")]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureNV* pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureNV")]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureNV pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureNV")]
        public unsafe partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] AccelerationStructureNV* pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateAccelerationStructureNV")]
        public partial Result CreateAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out AccelerationStructureNV pAccelerationStructure);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesNV")]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoNV* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesNV")]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoNV* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesNV")]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoNV* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesNV")]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoNV* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesNV")]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] in RayTracingPipelineCreateInfoNV pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesNV")]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] in RayTracingPipelineCreateInfoNV pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesNV")]
        public unsafe partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] in RayTracingPipelineCreateInfoNV pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateRayTracingPipelinesNV")]
        public partial Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Count = 0)] uint createInfoCount, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] in RayTracingPipelineCreateInfoNV pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] out Pipeline pPipelines);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyAccelerationStructureNV")]
        public unsafe partial void DestroyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureNV accelerationStructure, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyAccelerationStructureNV")]
        public partial void DestroyAccelerationStructure([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureNV accelerationStructure, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureHandleNV")]
        public unsafe partial Result GetAccelerationStructureHandle([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureNV accelerationStructure, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureHandleNV")]
        public partial Result GetAccelerationStructureHandle<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureNV accelerationStructure, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureMemoryRequirementsNV")]
        public unsafe partial void GetAccelerationStructureMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureMemoryRequirementsInfoNV* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2KHR* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetAccelerationStructureMemoryRequirementsNV")]
        public unsafe partial void GetAccelerationStructureMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AccelerationStructureMemoryRequirementsInfoNV* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2KHR pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAccelerationStructureMemoryRequirementsNV")]
        public unsafe partial void GetAccelerationStructureMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureMemoryRequirementsInfoNV pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryRequirements2KHR* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        [NativeApi(EntryPoint = "vkGetAccelerationStructureMemoryRequirementsNV")]
        public partial void GetAccelerationStructureMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in AccelerationStructureMemoryRequirementsInfoNV pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryRequirements2KHR pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupHandlesNV")]
        public unsafe partial Result GetRayTracingShaderGroupHandles([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetRayTracingShaderGroupHandlesNV")]
        public partial Result GetRayTracingShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Count = 0)] nuint dataSize, [Count(Parameter = "dataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        public unsafe Result BindAccelerationStructureMemory([Count(Count = 0)] Device device, [Count(Parameter = "bindInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<BindAccelerationStructureMemoryInfoNV> pBindInfos)
        {
            // ImplicitCountSpanOverloader
            return BindAccelerationStructureMemory(device, (uint) pBindInfos.Length, in pBindInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWriteAccelerationStructuresProperties([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "accelerationStructureCount"), Flow(FlowDirection.In)] ReadOnlySpan<AccelerationStructureNV> pAccelerationStructures, [Count(Count = 0)] QueryType queryType, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery)
        {
            // ImplicitCountSpanOverloader
            CmdWriteAccelerationStructuresProperties(commandBuffer, (uint) pAccelerationStructures.Length, in pAccelerationStructures.GetPinnableReference(), queryType, queryPool, firstQuery);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoNV* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateRayTracingPipelines(device, pipelineCache, (uint) pPipelines.Length, pCreateInfos, pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] RayTracingPipelineCreateInfoNV* pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateRayTracingPipelines(device, pipelineCache, (uint) pPipelines.Length, pCreateInfos, in pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoNV> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateRayTracingPipelines(device, pipelineCache, (uint) pCreateInfos.Length, in pCreateInfos.GetPinnableReference(), pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoNV> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateRayTracingPipelines(device, pipelineCache, (uint) pPipelines.Length, in pCreateInfos.GetPinnableReference(), pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoNV> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Pipeline* pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateRayTracingPipelines(device, pipelineCache, (uint) pCreateInfos.Length, in pCreateInfos.GetPinnableReference(), in pAllocator, pPipelines);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateRayTracingPipelines([Count(Count = 0)] Device device, [Count(Count = 0)] PipelineCache pipelineCache, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.In)] ReadOnlySpan<RayTracingPipelineCreateInfoNV> pCreateInfos, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Parameter = "createInfoCount"), Flow(FlowDirection.Out)] Span<Pipeline> pPipelines)
        {
            // ImplicitCountSpanOverloader
            return CreateRayTracingPipelines(device, pipelineCache, (uint) pPipelines.Length, in pCreateInfos.GetPinnableReference(), in pAllocator, out pPipelines.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetAccelerationStructureHandle<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] AccelerationStructureNV accelerationStructure, [Count(Parameter = "dataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            return GetAccelerationStructureHandle(device, accelerationStructure, (nuint) (pData.Length * Unsafe.SizeOf<T0>()), ref pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetRayTracingShaderGroupHandles<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint firstGroup, [Count(Count = 0)] uint groupCount, [Count(Parameter = "dataSize")] Span<T0> pData) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            return GetRayTracingShaderGroupHandles(device, pipeline, firstGroup, groupCount, (nuint) (pData.Length * Unsafe.SizeOf<T0>()), ref pData.GetPinnableReference());
        }

        public NVRayTracing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

