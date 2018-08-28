using System.Runtime.InteropServices;

#pragma warning disable IDE1006 // naming rule violation, methods must begin with uppercase

// trace (for debugging), termcaps (terminal metadata), etc.

namespace Mindmagma.Curses.Interop
{
    internal static partial class Native
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool type_can_change_color();
        private static type_can_change_color sym_can_change_color = LoadFunction<type_can_change_color>("can_change_color");
        internal static bool can_change_color() => sym_can_change_color();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool type_has_colors();
        private static type_has_colors sym_has_colors = LoadFunction<type_has_colors>("has_colors");
        internal static bool has_colors() => sym_has_colors();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void type_trace(uint flags);
        private static type_trace sym_trace = LoadFunction<type_trace>("trace");
        internal static void trace(uint flags) => sym_trace(flags);
    }
}
