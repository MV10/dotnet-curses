using System.Runtime.InteropServices;

namespace Mindmagma.Curses
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MouseEvent
    {
        [MarshalAs(UnmanagedType.I2)]
        public short id;

        [MarshalAs(UnmanagedType.I4)]
        public int x;

        [MarshalAs(UnmanagedType.I4)]
        public int y;

        [MarshalAs(UnmanagedType.I4)]
        public int z;

        [MarshalAs(UnmanagedType.I8)]
        public long bstate;
    }
}

