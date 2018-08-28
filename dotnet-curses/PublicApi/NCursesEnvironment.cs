using System;
using System.Text;
using Mindmagma.Curses.Interop;

// trace (for debugging), termcaps (terminal metadata), etc.

namespace Mindmagma.Curses
{
    public static partial class NCurses
    {

        public static bool CanChangeColor()
        {
            return Native.can_change_color();
        }

        public static bool HasColors()
        {
            return Native.has_colors();
        }

        /// <summary>
        /// Writes debug information to the "trace" file in the current directory.
        /// WARNING - Some flags log multiple megabytes per second in rapid-read or rapid-update applications.
        /// </summary>
        /// <param name="flags"><see cref="CursesTrace"/ constants OR'd together (use the | operator)></param>
        public static void Trace(uint flags)
        {
            // http://invisible-island.net/ncurses/man/curs_trace.3x.html
            Native.trace(flags);
        }

    }
}
