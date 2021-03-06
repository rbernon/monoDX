/*
 * Copyright 2020 Rémi Bernon for CodeWeavers
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of
 * this software and associated documentation files (the "Software"), to deal in
 * the Software without restriction, including without limitation the rights to
 * use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
 * the Software, and to permit persons to whom the Software is furnished to do so,
 * subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
 * FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
 * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
 * IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
 * CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

#include <windows.h>
#include "d3d9.h"

#include "wine/debug.h"

WINE_DEFAULT_DEBUG_CHANNEL(monodx);

static HMODULE d3d9;

static IDirect3D9 *(WINAPI *pDirect3DCreate9)(UINT version);

void CDECL d3d9_Create(IDirect3D9 **iface)
{
    WINE_TRACE("iface %p\n", iface);
    *iface = pDirect3DCreate9(D3D_SDK_VERSION);
    WINE_TRACE("created %p\n", *iface);
}

void CDECL d3d9_Release(IDirect3D9 *iface)
{
    WINE_TRACE("iface %p\n", iface);
    IDirect3D9_Release(iface);
}

UINT CDECL d3d9_GetAdapterCount(IDirect3D9 *iface)
{
    WINE_TRACE("iface %p\n", iface);
    return IDirect3D9_GetAdapterCount(iface);
}

UINT CDECL d3d9_GetAdapterDisplayModeCount(IDirect3D9 *iface, UINT adapter)
{
    WINE_TRACE("iface %p, adapter %u\n", iface, adapter);
    return IDirect3D9_GetAdapterModeCount(iface, adapter, D3DFMT_X8R8G8B8);
}

HRESULT CDECL d3d9_GetAdapterCurrentDisplayMode(IDirect3D9 *iface, UINT adapter, D3DDISPLAYMODE *mode)
{
    WINE_TRACE("iface %p, adapter %u, mode %p\n", iface, adapter, mode);
    return IDirect3D9_GetAdapterDisplayMode(iface, adapter, mode);
}

void CDECL d3d9_GetAdapterDisplayMode(IDirect3D9 *iface, UINT adapter, UINT index, D3DDISPLAYMODE *mode)
{
    WINE_TRACE("iface %p, adapter %u, index %u, mode %p\n", iface, adapter, index, mode);
    IDirect3D9_EnumAdapterModes(iface, adapter, D3DFMT_X8R8G8B8, index, mode);
}

void CDECL d3d9_GetDeviceCaps(IDirect3D9 *iface, UINT adapter, UINT type, D3DCAPS9 *caps)
{
    WINE_TRACE("iface %p, adapter %u, type %u, caps %p\n", iface, adapter, type, caps);
    IDirect3D9_GetDeviceCaps(iface, adapter, type, caps);
}

BOOL WINAPI DllMain(HINSTANCE instance, DWORD reason, void *res)
{
    WINE_TRACE("instance %p, reason %x, res %p\n", instance, reason, res);

    switch (reason)
    {
    case DLL_PROCESS_ATTACH:
        if (!(d3d9 = LoadLibraryA("d3d9"))) return FALSE;
        if (!(pDirect3DCreate9 = (void*)GetProcAddress(d3d9, "Direct3DCreate9"))) return FALSE;
        break;
    case DLL_PROCESS_DETACH:
        FreeLibrary(d3d9);
        break;
    }
    return TRUE;
}
