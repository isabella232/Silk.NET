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
    [Guid("95f4edf4-6e03-4cd7-be1b-3075d665aa52")]
    [NativeName("Name", "IDXVAHD_VideoProcessor")]
    public unsafe partial struct IDXVAHDVideoProcessor
    {
        public static readonly Guid Guid = new("95f4edf4-6e03-4cd7-be1b-3075d665aa52");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXVAHDVideoProcessor val)
            => Unsafe.As<IDXVAHDVideoProcessor, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXVAHDVideoProcessor
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXVAHDVideoProcessor*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVideoProcessBltState(HDBltState State, uint DataSize, void* pData)
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, HDBltState, uint, void*, int>)LpVtbl[3])(@this, State, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVideoProcessBltState<T0>(HDBltState State, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, HDBltState, uint, T0*, int>)LpVtbl[3])(@this, State, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessBltState(HDBltState State, uint DataSize, void* pData)
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, HDBltState, uint, void*, int>)LpVtbl[4])(@this, State, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessBltState<T0>(HDBltState State, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, HDBltState, uint, T0*, int>)LpVtbl[4])(@this, State, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVideoProcessStreamState(uint StreamNumber, HDStreamState State, uint DataSize, void* pData)
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, uint, HDStreamState, uint, void*, int>)LpVtbl[5])(@this, StreamNumber, State, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVideoProcessStreamState<T0>(uint StreamNumber, HDStreamState State, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, uint, HDStreamState, uint, T0*, int>)LpVtbl[5])(@this, StreamNumber, State, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessStreamState(uint StreamNumber, HDStreamState State, uint DataSize, void* pData)
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, uint, HDStreamState, uint, void*, int>)LpVtbl[6])(@this, StreamNumber, State, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVideoProcessStreamState<T0>(uint StreamNumber, HDStreamState State, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, uint, HDStreamState, uint, T0*, int>)LpVtbl[6])(@this, StreamNumber, State, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBltHD(Silk.NET.Direct3D9.IDirect3DSurface9* pOutputSurface, uint OutputFrame, uint StreamCount, HDStreamData* pStreams)
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int>)LpVtbl[7])(@this, pOutputSurface, OutputFrame, StreamCount, pStreams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBltHD(Silk.NET.Direct3D9.IDirect3DSurface9* pOutputSurface, uint OutputFrame, uint StreamCount, ref HDStreamData pStreams)
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HDStreamData* pStreamsPtr = &pStreams)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int>)LpVtbl[7])(@this, pOutputSurface, OutputFrame, StreamCount, pStreamsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessBltHD(ref Silk.NET.Direct3D9.IDirect3DSurface9 pOutputSurface, uint OutputFrame, uint StreamCount, HDStreamData* pStreams)
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pOutputSurfacePtr = &pOutputSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int>)LpVtbl[7])(@this, pOutputSurfacePtr, OutputFrame, StreamCount, pStreams);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessBltHD(ref Silk.NET.Direct3D9.IDirect3DSurface9 pOutputSurface, uint OutputFrame, uint StreamCount, ref HDStreamData pStreams)
        {
            var @this = (IDXVAHDVideoProcessor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pOutputSurfacePtr = &pOutputSurface)
            {
                fixed (HDStreamData* pStreamsPtr = &pStreams)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXVAHDVideoProcessor*, Silk.NET.Direct3D9.IDirect3DSurface9*, uint, uint, HDStreamData*, int>)LpVtbl[7])(@this, pOutputSurfacePtr, OutputFrame, StreamCount, pStreamsPtr);
                }
            }
            return ret;
        }

    }
}
