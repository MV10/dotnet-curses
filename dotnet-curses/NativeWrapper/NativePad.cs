using System;
using System.Runtime.InteropServices;
using System.Text;

#pragma warning disable IDE1006 // naming rule violation, methods must begin with uppercase

// functions for working with curses pads

namespace Mindmagma.Curses.Interop
{
    internal static partial class Native
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr dt_newpad(int row, int column);
        private static dt_newpad call_newpad = NativeToDelegate<dt_newpad>("newpad");
        internal static IntPtr newpad(int row, int column) => call_newpad(row, column);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_pechochar(IntPtr pad, int character);
        private static dt_pechochar call_pechochar = NativeToDelegate<dt_pechochar>("pechochar");
        internal static int pechochar(IntPtr pad, int character) => call_pechochar(pad, character);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_pnoutrefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn);
        private static dt_pnoutrefresh call_pnoutrefresh = NativeToDelegate<dt_pnoutrefresh>("pnoutrefresh");
        internal static int pnoutrefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn)
            => call_pnoutrefresh(pad, padMinRow, padMinColumn, screenMinRow, screenMinColumn, screenMaxRow, screenMaxColumn);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_prefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn);
        private static dt_prefresh call_prefresh = NativeToDelegate<dt_prefresh>("prefresh");
        internal static int prefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn)
            => call_prefresh(pad, padMinRow, padMinColumn, screenMinRow, screenMinColumn, screenMaxRow, screenMaxColumn);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr dt_subpad(IntPtr parent, int row, int column, int y, int x);
        private static dt_subpad call_subpad = NativeToDelegate<dt_subpad>("subpad");
        internal static IntPtr subpad(IntPtr parent, int row, int column, int y, int x) => call_subpad(parent, row, column, y, x);

    }
}
