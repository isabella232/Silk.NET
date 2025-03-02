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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_pipeline_executable_properties")]
    public unsafe partial class KhrPipelineExecutableProperties : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_pipeline_executable_properties";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
        public unsafe partial Result GetPipelineExecutableInternalRepresentation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] uint* pInternalRepresentationCount, [Count(Parameter = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] PipelineExecutableInternalRepresentationKHR* pInternalRepresentations);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pInternalRepresentations = new(StructureType.PipelineExecutableInternalRepresentationKhr);")]
        [NativeApi(EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
        public unsafe partial Result GetPipelineExecutableInternalRepresentation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] uint* pInternalRepresentationCount, [Count(Parameter = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] out PipelineExecutableInternalRepresentationKHR pInternalRepresentations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
        public unsafe partial Result GetPipelineExecutableInternalRepresentation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] ref uint pInternalRepresentationCount, [Count(Parameter = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] PipelineExecutableInternalRepresentationKHR* pInternalRepresentations);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pInternalRepresentations = new(StructureType.PipelineExecutableInternalRepresentationKhr);")]
        [NativeApi(EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
        public unsafe partial Result GetPipelineExecutableInternalRepresentation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] ref uint pInternalRepresentationCount, [Count(Parameter = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] out PipelineExecutableInternalRepresentationKHR pInternalRepresentations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
        public unsafe partial Result GetPipelineExecutableInternalRepresentation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineExecutableInfoKHR pExecutableInfo, [Count(Count = 0)] uint* pInternalRepresentationCount, [Count(Parameter = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] PipelineExecutableInternalRepresentationKHR* pInternalRepresentations);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pInternalRepresentations = new(StructureType.PipelineExecutableInternalRepresentationKhr);")]
        [NativeApi(EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
        public unsafe partial Result GetPipelineExecutableInternalRepresentation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineExecutableInfoKHR pExecutableInfo, [Count(Count = 0)] uint* pInternalRepresentationCount, [Count(Parameter = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] out PipelineExecutableInternalRepresentationKHR pInternalRepresentations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
        public unsafe partial Result GetPipelineExecutableInternalRepresentation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineExecutableInfoKHR pExecutableInfo, [Count(Count = 0)] ref uint pInternalRepresentationCount, [Count(Parameter = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] PipelineExecutableInternalRepresentationKHR* pInternalRepresentations);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pInternalRepresentations = new(StructureType.PipelineExecutableInternalRepresentationKhr);")]
        [NativeApi(EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
        public partial Result GetPipelineExecutableInternalRepresentation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineExecutableInfoKHR pExecutableInfo, [Count(Count = 0)] ref uint pInternalRepresentationCount, [Count(Parameter = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] out PipelineExecutableInternalRepresentationKHR pInternalRepresentations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
        public unsafe partial Result GetPipelineExecutableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineInfoKHR* pPipelineInfo, [Count(Count = 0)] uint* pExecutableCount, [Count(Parameter = "pExecutableCount"), Flow(FlowDirection.Out)] PipelineExecutablePropertiesKHR* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.PipelineExecutablePropertiesKhr);")]
        [NativeApi(EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
        public unsafe partial Result GetPipelineExecutableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineInfoKHR* pPipelineInfo, [Count(Count = 0)] uint* pExecutableCount, [Count(Parameter = "pExecutableCount"), Flow(FlowDirection.Out)] out PipelineExecutablePropertiesKHR pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
        public unsafe partial Result GetPipelineExecutableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineInfoKHR* pPipelineInfo, [Count(Count = 0)] ref uint pExecutableCount, [Count(Parameter = "pExecutableCount"), Flow(FlowDirection.Out)] PipelineExecutablePropertiesKHR* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.PipelineExecutablePropertiesKhr);")]
        [NativeApi(EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
        public unsafe partial Result GetPipelineExecutableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineInfoKHR* pPipelineInfo, [Count(Count = 0)] ref uint pExecutableCount, [Count(Parameter = "pExecutableCount"), Flow(FlowDirection.Out)] out PipelineExecutablePropertiesKHR pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
        public unsafe partial Result GetPipelineExecutableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineInfoKHR pPipelineInfo, [Count(Count = 0)] uint* pExecutableCount, [Count(Parameter = "pExecutableCount"), Flow(FlowDirection.Out)] PipelineExecutablePropertiesKHR* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.PipelineExecutablePropertiesKhr);")]
        [NativeApi(EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
        public unsafe partial Result GetPipelineExecutableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineInfoKHR pPipelineInfo, [Count(Count = 0)] uint* pExecutableCount, [Count(Parameter = "pExecutableCount"), Flow(FlowDirection.Out)] out PipelineExecutablePropertiesKHR pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
        public unsafe partial Result GetPipelineExecutableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineInfoKHR pPipelineInfo, [Count(Count = 0)] ref uint pExecutableCount, [Count(Parameter = "pExecutableCount"), Flow(FlowDirection.Out)] PipelineExecutablePropertiesKHR* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.PipelineExecutablePropertiesKhr);")]
        [NativeApi(EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
        public partial Result GetPipelineExecutableProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineInfoKHR pPipelineInfo, [Count(Count = 0)] ref uint pExecutableCount, [Count(Parameter = "pExecutableCount"), Flow(FlowDirection.Out)] out PipelineExecutablePropertiesKHR pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
        public unsafe partial Result GetPipelineExecutableStatistic([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] uint* pStatisticCount, [Count(Parameter = "pStatisticCount"), Flow(FlowDirection.Out)] PipelineExecutableStatisticKHR* pStatistics);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pStatistics = new(StructureType.PipelineExecutableStatisticKhr);")]
        [NativeApi(EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
        public unsafe partial Result GetPipelineExecutableStatistic([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] uint* pStatisticCount, [Count(Parameter = "pStatisticCount"), Flow(FlowDirection.Out)] out PipelineExecutableStatisticKHR pStatistics);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
        public unsafe partial Result GetPipelineExecutableStatistic([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] ref uint pStatisticCount, [Count(Parameter = "pStatisticCount"), Flow(FlowDirection.Out)] PipelineExecutableStatisticKHR* pStatistics);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pStatistics = new(StructureType.PipelineExecutableStatisticKhr);")]
        [NativeApi(EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
        public unsafe partial Result GetPipelineExecutableStatistic([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] ref uint pStatisticCount, [Count(Parameter = "pStatisticCount"), Flow(FlowDirection.Out)] out PipelineExecutableStatisticKHR pStatistics);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
        public unsafe partial Result GetPipelineExecutableStatistic([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineExecutableInfoKHR pExecutableInfo, [Count(Count = 0)] uint* pStatisticCount, [Count(Parameter = "pStatisticCount"), Flow(FlowDirection.Out)] PipelineExecutableStatisticKHR* pStatistics);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pStatistics = new(StructureType.PipelineExecutableStatisticKhr);")]
        [NativeApi(EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
        public unsafe partial Result GetPipelineExecutableStatistic([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineExecutableInfoKHR pExecutableInfo, [Count(Count = 0)] uint* pStatisticCount, [Count(Parameter = "pStatisticCount"), Flow(FlowDirection.Out)] out PipelineExecutableStatisticKHR pStatistics);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
        public unsafe partial Result GetPipelineExecutableStatistic([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineExecutableInfoKHR pExecutableInfo, [Count(Count = 0)] ref uint pStatisticCount, [Count(Parameter = "pStatisticCount"), Flow(FlowDirection.Out)] PipelineExecutableStatisticKHR* pStatistics);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pStatistics = new(StructureType.PipelineExecutableStatisticKhr);")]
        [NativeApi(EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
        public partial Result GetPipelineExecutableStatistic([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PipelineExecutableInfoKHR pExecutableInfo, [Count(Count = 0)] ref uint pStatisticCount, [Count(Parameter = "pStatisticCount"), Flow(FlowDirection.Out)] out PipelineExecutableStatisticKHR pStatistics);

        public KhrPipelineExecutableProperties(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

