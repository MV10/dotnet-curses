using System;
using System.Text;
using Mindmagma.Curses.Interop;

// functions for working with curses windows (including stdscr)

namespace Mindmagma.Curses
{
    public static partial class NCurses
    {
        public static void Box(IntPtr window, char verticalChar, char horizontalChar)
        {
            int result = Native.box(window, verticalChar, horizontalChar);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Box));
        }

        public static void ClearWindow(IntPtr window)
        {
            int result = Native.wclear(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(ClearWindow));
        }

        public static void CopyWindow(IntPtr sourceWindow, IntPtr destinationWindow, int sourceRow, int sourceColumn, int destinationRow, int destinationColumn, int rowOffset, int columnOffset, bool type)
        {
            int result = Native.copywin(sourceWindow, destinationWindow, sourceRow, sourceColumn, destinationRow, destinationColumn, rowOffset, columnOffset, type);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(CopyWindow));
        }

        public static int DeleteWindow(IntPtr window)
        {
            int result = Native.delwin(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(DeleteWindow));
            return result;
        }

        public static IntPtr DeriveWindow(IntPtr window, int rows, int columns, int y, int x)
        {
            IntPtr result = Native.derwin(window, rows, columns, y, x);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(DeriveWindow));
            return result;
        }

        public static IntPtr DuplicateWindow(IntPtr window)
        {
            IntPtr result = Native.dupwin(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(DuplicateWindow));
            return result;
        }

        public static void GetMaxYX(IntPtr window, out int y, out int x)
        {
            y = Native.getmaxy(window);
            NativeExceptionHelper.ThrowOnFailure(y, nameof(GetMaxYX));
            x = Native.getmaxx(window);
            NativeExceptionHelper.ThrowOnFailure(x, nameof(GetMaxYX));
        }

        public static void GetYX(IntPtr window, out int y, out int x)
        {
            y = Native.getcury(window);
            NativeExceptionHelper.ThrowOnFailure(y, nameof(GetYX));
            x = Native.getcurx(window);
            NativeExceptionHelper.ThrowOnFailure(x, nameof(GetYX));
        }

        public static void Keypad(IntPtr window, bool enable)
        {
            int result = Native.keypad(window, enable);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Keypad));
        }

        public static int MoveWindowAddChar(IntPtr window, int y, int x, char c)
        {
            int result = Native.mvwaddch(window, y, x, c);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(MoveWindowAddChar));
            return result;
        }

        public static int MoveWindowAddString(IntPtr window, int y, int x, string message)
        {
            int result = Native.mvwaddstr(window, y, x, message);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(MoveWindowAddString));
            return result;
        }

        public static void MoveWindow(IntPtr window, int row, int column)
        {
            int result = Native.mvwin(window, row, column);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(MoveWindow));
        }

        public static int MoveWindowGetChar(IntPtr window, int y, int x)
        {
            int result = Native.mvwgetch(window, y, x);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(MoveWindowGetChar));
            return result;
        }

        public static uint MoveWindowInspectChar(IntPtr window, int y, int x)
        {
            uint result = Native.mvwinch(window, y, x);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(MoveWindowInspectChar));
            return result;
        }

        public static IntPtr NewWindow(int rows, int columns, int yOrigin, int xOrigin)
        {
            IntPtr result = Native.newwin(rows, columns, yOrigin, xOrigin);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(NewWindow));
            return result;
        }

        public static void NoDelay(IntPtr window, bool removeDelay)
        {
            int result = Native.nodelay(window, removeDelay);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(NoDelay));
        }

        public static void WindowTimeOut(IntPtr window, int delay)
        {
            int result = Native.wtimeout(window, delay);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowTimeOut));
        }

        public static void Overlay(IntPtr sourceWindow, IntPtr destinationWindow)
        {
            int result = Native.overlay(sourceWindow, destinationWindow);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Overlay));
        }

        public static void Overwrite(IntPtr sourceWindow, IntPtr destinationWindow)
        {
            int result = Native.overwrite(sourceWindow, destinationWindow);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Overwrite));
        }

        public static void Scroll(IntPtr window)
        {
            int result = Native.scroll(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Scroll));
        }

        public static void ScrollOk(IntPtr window, bool canScroll)
        {
            int result = Native.scrollok(window, canScroll);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(ScrollOk));
        }

        public static IntPtr SubWindow(IntPtr parent, int rows, int columns, int y, int x)
        {
            IntPtr result = Native.subwin(parent, rows, columns, y, x);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(SubWindow));
            return result;
        }

        public static void TouchLine(IntPtr window, int row, int column)
        {
            int result = Native.touchline(window, row, column);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(TouchLine));
        }

        public static int TouchWindow(IntPtr window)
        {
            int result = Native.touchwin(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(TouchWindow));
            return result;
        }

        public static int WindowAddChar(IntPtr window, int character)
        {
            int result = Native.waddch(window, character);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowAddChar));
            return result;
        }

        public static int WindowAddString(IntPtr window, string message)
        {
            int result = Native.waddstr(window, message);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowAddString));
            return result;
        }

        public static int WindowAttributeOn(IntPtr window, uint attributes)
        {
            int result = Native.wattron(window, attributes);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowAttributeOn));
            return result;
        }

        public static int WindowAttributeOff(IntPtr window, uint attributes)
        {
            int result = Native.wattroff(window, attributes);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowAttributeOff));
            return result;
        }

        public static int WindowAttributeSet(IntPtr window, uint attributes)
        {
            int result = Native.wattrset(window, attributes);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowAttributeSet));
            return result;
        }

        public static void WindowBackground(IntPtr window, uint ch)
        {
            int result = Native.wbkgd(window, ch);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowBackground));
        }

        public static void WindowBorder(IntPtr window, char leftSide, char rightSide, char topSide, char bottomSide, char topLeftHandCorner, char topRightHandCorner, char bottomLeftHandCorner, char bottomRightHandCorner)
        {
            int result = Native.wborder(window, leftSide, rightSide, topSide, bottomSide, topLeftHandCorner, topRightHandCorner, bottomLeftHandCorner, bottomRightHandCorner);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowBorder));
        }

        public static int WindowGetChar(IntPtr window)
        {
            int result = Native.wgetch(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowGetChar));
            return result;
        }

        public static uint WindowInspectChar(IntPtr window)
        {
            uint result = Native.winch(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowInspectChar));
            return result;
        }

        public static int WindowMove(IntPtr window, int row, int column)
        {
            int result = Native.wmove(window, row, column);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowMove));
            return result;
        }

        public static int WindowRefresh(IntPtr window)
        {
            int result = Native.wrefresh(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowRefresh));
            return result;
        }

        public static void WindowScrollLines(IntPtr window, int numberOfLines)
        {
            int result = Native.wscrl(window, numberOfLines);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowScrollLines));
        }
    }
}
