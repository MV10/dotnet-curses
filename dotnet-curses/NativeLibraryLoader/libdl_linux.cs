using System;
using System.Runtime.InteropServices;

namespace NativeLibraryLoader
{
    internal static class libdl_linux
    {
        // originally just "libdl"
        // https://github.com/mellinoe/nativelibraryloader/issues/2
        private const string LibName = "libdl.so.2";

        public const int RTLD_NOW = 0x002;

        [DllImport(LibName)]
        public static extern IntPtr dlopen(string fileName, int flags);

        [DllImport(LibName)]
        public static extern IntPtr dlsym(IntPtr handle, string name);

        [DllImport(LibName)]
        public static extern int dlclose(IntPtr handle);

        [DllImport(LibName)]
        public static extern string dlerror();
    }
}
