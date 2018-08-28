using System;
using System.Text;
using Mindmagma.Curses.Interop;

// functions for working with curses pads

namespace Mindmagma.Curses
{
    public static partial class NCurses
    {
        public static IntPtr NewPad(int row, int column)
        {
            IntPtr result = Native.newpad(row, column);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(NewPad));
            return result;
        }

        public static int PadEchoChar(IntPtr pad, int character)
        {
            int result = Native.pechochar(pad, character);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(PadEchoChar));
            return result;
        }

        public static void PadNOutRefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn)
        {
            int result = Native.pnoutrefresh(pad, padMinRow, padMinColumn, screenMinRow, screenMinColumn, screenMaxRow, screenMaxColumn);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(PadNOutRefresh));
        }

        public static void PadRefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn)
        {
            int result = Native.prefresh(pad, padMinRow, padMinColumn, screenMinRow, screenMinColumn, screenMaxRow, screenMaxColumn);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(PadRefresh));
        }

        public static IntPtr SubPad(IntPtr parent, int rows, int columns, int y, int x)
        {
            IntPtr result = Native.subpad(parent, rows, columns, y, x);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(SubPad));
            return result;
        }

    }
}
