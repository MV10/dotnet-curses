using System;
using System.Text;
using Mindmagma.Curses.Interop;

// exported values (LINES, COLS, etc.)

namespace Mindmagma.Curses
{
    public static partial class NCurses
    {
        /// <summary>
        /// The number of columns visible. Maximum X position is one less (zero offset).
        /// </summary>
        public static int Columns => Native.COLS;

        /// <summary>
        /// The number of rows visible. Maximum Y position is one less (zero offset).
        /// </summary>
        public static int Lines => Native.LINES;
    }
}
