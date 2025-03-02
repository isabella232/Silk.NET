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
    [NativeName("Name", "VkBufferCollectionCreateInfoFUCHSIA")]
    public unsafe partial struct BufferCollectionCreateInfoFUCHSIA
    {
        public BufferCollectionCreateInfoFUCHSIA
        (
            StructureType? sType = StructureType.BufferCollectionCreateInfoFuchsia,
            void* pNext = null,
            nint? collectionToken = null
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

            if (collectionToken is not null)
            {
                CollectionToken = collectionToken.Value;
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
        [NativeName("Type", "zx_handle_t")]
        [NativeName("Type.Name", "zx_handle_t")]
        [NativeName("Name", "collectionToken")]
        public nint CollectionToken;
    }
}
