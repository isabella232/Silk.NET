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
    [NativeName("Name", "VkPhysicalDeviceSubpassShadingPropertiesHUAWEI")]
    public unsafe partial struct PhysicalDeviceSubpassShadingPropertiesHUAWEI
    {
        public PhysicalDeviceSubpassShadingPropertiesHUAWEI
        (
            StructureType? sType = StructureType.PhysicalDeviceSubpassShadingPropertiesHuawei,
            void* pNext = null,
            uint? maxSubpassShadingWorkgroupSizeAspectRatio = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (maxSubpassShadingWorkgroupSizeAspectRatio is not null)
            {
                MaxSubpassShadingWorkgroupSizeAspectRatio = maxSubpassShadingWorkgroupSizeAspectRatio.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSubpassShadingWorkgroupSizeAspectRatio")]
        public uint MaxSubpassShadingWorkgroupSizeAspectRatio;
    }
}
