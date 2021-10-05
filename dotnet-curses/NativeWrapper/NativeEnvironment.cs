using System;
using System.Runtime.InteropServices;

#pragma warning disable IDE1006 // naming rule violation, methods must begin with uppercase

// startup/shutdown, trace (debugging), termcaps (terminal metadata), etc.

namespace Mindmagma.Curses.Interop
{
    internal static partial class Native
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool dt_can_change_color();
        private static dt_can_change_color call_can_change_color = NativeToDelegate<dt_can_change_color>("can_change_color");
        internal static bool can_change_color() => call_can_change_color();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_cbreak();
        private static dt_cbreak call_cbreak = NativeToDelegate<dt_cbreak>("cbreak");
        internal static int cbreak() => call_cbreak();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_endwin();
        private static dt_endwin call_endwin = NativeToDelegate<dt_endwin>("endwin");
        internal static int endwin() => call_endwin();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool dt_has_colors();
        private static dt_has_colors call_has_colors = NativeToDelegate<dt_has_colors>("has_colors");
        internal static bool has_colors() => call_has_colors();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr dt_initscr();
        private static dt_initscr call_initscr = NativeToDelegate<dt_initscr>("initscr");
        internal static IntPtr initscr() => call_initscr();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool dt_isendwin();
        private static dt_isendwin call_isendwin = NativeToDelegate<dt_isendwin>("isendwin");
        internal static bool isendwin() => call_isendwin();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_napms(int milliseconds);
        private static dt_napms call_napms = NativeToDelegate<dt_napms>("napms");
        internal static int napms(int milliseconds) => call_napms(milliseconds);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_nocbreak();
        private static dt_nocbreak call_nocbreak = NativeToDelegate<dt_nocbreak>("nocbreak");
        internal static int nocbreak() => call_nocbreak();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_noecho();
        private static dt_noecho call_noecho = NativeToDelegate<dt_noecho>("noecho");
        internal static int noecho() => call_noecho();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_noraw();
        private static dt_noraw call_noraw = NativeToDelegate<dt_noraw>("noraw");
        internal static int noraw() => call_noraw();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_raw();
        private static dt_raw call_raw = NativeToDelegate<dt_raw>("raw");
        internal static int raw() => call_raw();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_halfdelay(int tenths);
        private static dt_halfdelay call_halfdelay = NativeToDelegate<dt_halfdelay>("halfdelay");
        internal static int halfdelay(int tenths) => call_halfdelay(tenths);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_timeout(int delay);
        private static dt_timeout call_timeout = NativeToDelegate<dt_timeout>("timeout");
        internal static int timeout(int delay) => call_timeout(delay);
    }
}
