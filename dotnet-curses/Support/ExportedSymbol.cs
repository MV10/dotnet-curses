using System;
using System.Runtime.InteropServices;

namespace Mindmagma.Curses.Interop
{
    // .NET's DllImport attribute only supports function references.
    // Accessing exported data (constants or variables) requires jumping
    // through a considerably more complex set of hoops.

    // How to do this in Windows:
    // https://limbioliong.wordpress.com/2011/11/11/accessing-exported-data-from-a-dll-in-managed-code/
    // https://social.msdn.microsoft.com/Forums/vstudio/en-US/40d6b660-83ef-4a7e-82da-afc856effed1/c-pinvoke-how-to-access-exported-constantsvariables-without-using-getprocaddress?forum=clr

    // Request to support this in .NET:
    // https://github.com/dotnet/corefx/issues/31836

    // How to do this in POSIX:
    // https://stackoverflow.com/a/13492645/152997

    // TODO use RuntimeInformation.IsOsPlatform() rather than compile-time flags?
    // https://github.com/dotnet/core/issues/1349#issuecomment-373073089

    internal static class ExportedSymbol
    {

#if RUNTIME_LINUX || RUNTIME_OSX
 
        [DllImport("libdl.so")]
        internal static extern IntPtr dlopen(string filename, int flags);

        [DllImport("libdl.so")]
        internal static extern IntPtr dlsym(IntPtr handle, string symbol);

        const int RTLD_NOW = 2; // dlopen flag 

        internal static int GetInt(string library, string symbolName)
        {
            IntPtr handle = dlopen(library, RTLD_NOW);
            NativeExceptionHelper.ThrowOnNullPointer(handle, "NativeData.GetValue");
            IntPtr address = dlsym(handle, symbolName);
            NativeExceptionHelper.ThrowOnNullPointer(address, "NativeData.GetValue");
            return (int)Marshal.PtrToStructure(address, typeof(int));
        }

#else // RUNTIME_WINDOWS

        // GetModuleHandle does not increment the reference count, so FreeLibrary is not needed.
        // LoadLibrary is not needed because pinvoke will have already loaded the library.
        // Technically since the ref count is not incremented, this is not thread-safe.

        //[DllImport("Kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        //private static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)]string lpFileName);

        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern IntPtr GetModuleHandle([MarshalAs(UnmanagedType.LPStr)]string lpFileName);

        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern IntPtr GetProcAddress(IntPtr hModule, [MarshalAs(UnmanagedType.LPStr)] string lpProcName);

        //[DllImport("Kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //private static extern bool FreeLibrary(IntPtr hModule);

        internal static int GetInt(string library, string symbolName)
        {
            IntPtr dll = GetModuleHandle(library);
            NativeExceptionHelper.ThrowOnFailure(dll, "NativeData.GetValue");
            IntPtr address = GetProcAddress(dll, symbolName);
            NativeExceptionHelper.ThrowOnFailure(address, "NativeData.GetValue");
            return (int)Marshal.PtrToStructure(address, typeof(int));
        }

#endif
    }
}
