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
    [Guid("f2b0810a-fd00-43c9-918c-df94e2d8ef7d")]
    [NativeName("Name", "IDirectXVideoDecoder")]
    public unsafe partial struct IDirectXVideoDecoder
    {
        public static readonly Guid Guid = new("f2b0810a-fd00-43c9-918c-df94e2d8ef7d");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirectXVideoDecoder val)
            => Unsafe.As<IDirectXVideoDecoder, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirectXVideoDecoder
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
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoder*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderService(IDirectXVideoDecoderService** ppService)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, IDirectXVideoDecoderService**, int>)LpVtbl[3])(@this, ppService);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoDecoderService(ref IDirectXVideoDecoderService* ppService)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirectXVideoDecoderService** ppServicePtr = &ppService)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, IDirectXVideoDecoderService**, int>)LpVtbl[3])(@this, ppServicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfaces);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
            {
                fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfaces);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(Guid* pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                    {
                        fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuid, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfaces);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                    {
                        fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDesc, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfaces);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargets, pNumSurfacesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfaces);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                    {
                        fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfig, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfaces);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                    {
                        fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargets, pNumSurfacesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, uint* pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                    {
                        fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfaces);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCreationParameters(ref Guid pDeviceGuid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9** pDecoderRenderTargets, ref uint pNumSurfaces)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pDeviceGuidPtr = &pDeviceGuid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                    {
                        fixed (Silk.NET.Direct3D9.IDirect3DSurface9*** pDecoderRenderTargetsPtr = &pDecoderRenderTargets)
                        {
                            fixed (uint* pNumSurfacesPtr = &pNumSurfaces)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9***, uint*, int>)LpVtbl[4])(@this, pDeviceGuidPtr, pVideoDescPtr, pConfigPtr, pDecoderRenderTargetsPtr, pNumSurfacesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint BufferType, void** ppBuffer, uint* pBufferSize)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBuffer, pBufferSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint BufferType, void** ppBuffer, ref uint pBufferSize)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pBufferSizePtr = &pBufferSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBuffer, pBufferSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint BufferType, ref void* ppBuffer, uint* pBufferSize)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppBufferPtr = &ppBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBufferPtr, pBufferSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint BufferType, ref void* ppBuffer, ref uint pBufferSize)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppBufferPtr = &ppBuffer)
            {
                fixed (uint* pBufferSizePtr = &pBufferSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, uint, void**, uint*, int>)LpVtbl[5])(@this, BufferType, ppBufferPtr, pBufferSizePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReleaseBuffer(uint BufferType)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, uint, int>)LpVtbl[6])(@this, BufferType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginFrame(Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, void* pvPVPData)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)LpVtbl[7])(@this, pRenderTarget, pvPVPData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginFrame<T0>(Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTarget, ref T0 pvPVPData) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (T0* pvPVPDataPtr = &pvPVPData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, T0*, int>)LpVtbl[7])(@this, pRenderTarget, pvPVPDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginFrame(ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, void* pvPVPData)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, void*, int>)LpVtbl[7])(@this, pRenderTargetPtr, pvPVPData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginFrame<T0>(ref Silk.NET.Direct3D9.IDirect3DSurface9 pRenderTarget, ref T0 pvPVPData) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9* pRenderTargetPtr = &pRenderTarget)
            {
                fixed (T0* pvPVPDataPtr = &pvPVPData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, Silk.NET.Direct3D9.IDirect3DSurface9*, T0*, int>)LpVtbl[7])(@this, pRenderTargetPtr, pvPVPDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndFrame(void** pHandleComplete)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, void**, int>)LpVtbl[8])(@this, pHandleComplete);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndFrame(ref void* pHandleComplete)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pHandleCompletePtr = &pHandleComplete)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, void**, int>)LpVtbl[8])(@this, pHandleCompletePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Execute(DXVA2DecodeExecuteParams* pExecuteParams)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, DXVA2DecodeExecuteParams*, int>)LpVtbl[9])(@this, pExecuteParams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Execute(ref DXVA2DecodeExecuteParams pExecuteParams)
        {
            var @this = (IDirectXVideoDecoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2DecodeExecuteParams* pExecuteParamsPtr = &pExecuteParams)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoder*, DXVA2DecodeExecuteParams*, int>)LpVtbl[9])(@this, pExecuteParamsPtr);
            }
            return ret;
        }

    }
}
