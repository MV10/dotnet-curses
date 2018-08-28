using System.Runtime.InteropServices;

#pragma warning disable IDE1006 // naming rule violation, methods must begin with uppercase

// exported values (LINES, COLS, etc.)

namespace Mindmagma.Curses.Interop
{
    internal static partial class Native
    {

        internal static int COLS => MarshalInt("COLS");

        internal static int LINES => MarshalInt("LINES");
    }
}
