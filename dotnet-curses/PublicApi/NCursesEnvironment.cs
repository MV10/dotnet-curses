using System;
using System.Text;
using Mindmagma.Curses.Interop;

// startup/shutdown, trace (debugging), termcaps (terminal metadata), etc.

namespace Mindmagma.Curses
{
    public static partial class NCurses
    {

        public static bool CanChangeColor()
        {
            return Native.can_change_color();
        }

        /// <summary>
        /// Individual characters will be returned (rather than "cooked" line-input mode), but some control characters (such as CTRL+C) may still be processed internally.
        /// </summary>
        public static void CBreak()
        {
            int result = Native.cbreak();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(CBreak));
        }

        public static void EndWin()
        {
            int result = Native.endwin();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(EndWin));
        }

        public static bool HasColors()
        {
            return Native.has_colors();
        }

        public static IntPtr InitScreen()
        {
            IntPtr result = Native.initscr();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(InitScreen));
            return result;
        }

        public static bool IsEndWin()
        {
            return Native.isendwin();
        }

        public static int Nap(int milliseconds)
        {
            int result = Native.napms(milliseconds);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Nap));
            return result;
        }

        /// <summary>
        /// Returns the terminal to "cooked" line-input mode.
        /// </summary>
        public static void NoCBreak()
        {
            int result = Native.nocbreak();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(NoCBreak));
        }

        public static void NoEcho()
        {
            int result = Native.noecho();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(NoEcho));
        }

        /// <summary>
        /// Returns the terminal to "cooked" line-input mode.
        /// </summary>
        public static void NoRaw()
        {
            int result = Native.noraw();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(NoRaw));
        }

        /// <summary>
        /// Individual characters will be returned (rather than "cooked" line-input mode) with no internal processing of control characters.
        /// </summary>
        public static void Raw()
        {
            int result = Native.raw();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Raw));
        }
    }
}
