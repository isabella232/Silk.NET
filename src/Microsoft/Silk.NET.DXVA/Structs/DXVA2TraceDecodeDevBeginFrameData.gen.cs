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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "DXVA2Trace_DecodeDevBeginFrameData")]
    public unsafe partial struct DXVA2TraceDecodeDevBeginFrameData
    {
        public DXVA2TraceDecodeDevBeginFrameData
        (
            Silk.NET.Core.Win32Extras.EventTraceHeader? wmiHeader = null,
            ulong? pObject = null,
            ulong? pRenderTarget = null,
            int? enter = null
        ) : this()
        {
            if (wmiHeader is not null)
            {
                WmiHeader = wmiHeader.Value;
            }

            if (pObject is not null)
            {
                PObject = pObject.Value;
            }

            if (pRenderTarget is not null)
            {
                PRenderTarget = pRenderTarget.Value;
            }

            if (enter is not null)
            {
                Enter = enter.Value;
            }
        }


        [NativeName("Type", "EVENT_TRACE_HEADER")]
        [NativeName("Type.Name", "EVENT_TRACE_HEADER")]
        [NativeName("Name", "wmiHeader")]
        public Silk.NET.Core.Win32Extras.EventTraceHeader WmiHeader;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "pObject")]
        public ulong PObject;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "pRenderTarget")]
        public ulong PRenderTarget;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enter")]
        public int Enter;
    }
}
