using System;
using System.Text;

namespace Mindmagma.Curses
{
    public class NCurses
    {
        // TODO fix function names in error messages

        public static int AddChar(int ch)
        {
            int result = Native.addch(ch);
            NativeExceptionHelper.ThrowOnError(result, "AddChar");
            return result;
        }

        public static int AddString(string stringToAdd)
        {
            int result = Native.addstr(stringToAdd);
            NativeExceptionHelper.ThrowOnError(result, "AddStr");
            return result;
        }

        public static void AssumeDefaultColors(int f, int b)
        {
            int result = Native.assume_default_colors(f, b);
            NativeExceptionHelper.ThrowOnError(result, "AssumeDefaultColors");
        }

        public static void AttributeOff(uint attributes)
        {
            int result = Native.attroff(attributes);
            NativeExceptionHelper.ThrowOnError(result, "AttributeOff");
        }

        public static void AttributeOff(CursesAttribute attribute)
        {
            AttributeOff((uint)attribute);
        }

        public static void AttributeOn(uint attributes)
        {
            int result = Native.attron(attributes);
            NativeExceptionHelper.ThrowOnError(result, "AttributeOn");
        }

        public static void AttributeOn(CursesAttribute attribute)
        {
            AttributeOn((uint)attribute);
        }

        public static void AttributeSet(uint attributes)
        {
            int result = Native.attrset(attributes);
            NativeExceptionHelper.ThrowOnError(result, "AttributeSet");
        }

        public static void AttributeSet(CursesAttribute attribute)
        {
            AttributeSet((uint)attribute);
        }

        public static void Background(uint ch)
        {
            int result = Native.bkgd(ch);
            NativeExceptionHelper.ThrowOnError(result, "Background");
        }

        public static void Beep()
        {
            int result = Native.beep();
            NativeExceptionHelper.ThrowOnError(result, "Beep");
        }

        public static void Box(IntPtr window, char verticalChar, char horizontalChar)
        {
            int result = Native.box(window, verticalChar, horizontalChar);
            NativeExceptionHelper.ThrowOnError(result, "Box");
        }

        public static bool CanChangeColor()
        {
            return Native.can_change_color();
        }

        public static int Columns()
        {
            return Native.COLS();
        }

        public static void Clear()
        {
            int result = Native.clear();
            NativeExceptionHelper.ThrowOnError(result, "Clear");
        }

        public static void ClearToEndOfLine()
        {
            int result = Native.clrtoeol();
            NativeExceptionHelper.ThrowOnError(result, "ClearToEndOfLine");
        }

        public static void ClearToBottom()
        {
            int result = Native.clrtobot();
            NativeExceptionHelper.ThrowOnError(result, "ClearToBottom");
        }

        public static void ClearWindow(IntPtr window)
        {
            int result = Native.wclear(window);
            NativeExceptionHelper.ThrowOnError(result, "ClearWindow");
        }

        public static void ColorContent(short color, out short red, out short green, out short blue)
        {
            int result = Native.color_content(color, out red, out green, out blue);
            NativeExceptionHelper.ThrowOnError(result, "ColorContent");
        }

        public static uint ColorPair(int pairNumber)
        {
            return Native.COLOR_PAIR(pairNumber);
        }

        public static void CopyWindow(IntPtr sourceWindow, IntPtr destinationWindow, int sourceRow, int sourceColumn, int destinationRow, int destinationColumn, int rowOffset, int columnOffset, bool type)
        {
            int result = Native.copywin(sourceWindow, destinationWindow, sourceRow, sourceColumn, destinationRow, destinationColumn, rowOffset, columnOffset, type);
            NativeExceptionHelper.ThrowOnError(result, "CopyWindow");
        }

        public static void DeleteChar()
        {
            int result = Native.delch();
            NativeExceptionHelper.ThrowOnError(result, "DeleteCharacter");
        }

        public static void DeleteLine()
        {
            int result = Native.deleteln();
            NativeExceptionHelper.ThrowOnError(result, "DeleteLine");
        }

        public static int DeleteWindow(IntPtr window)
        {
            int result = Native.delwin(window);
            return result;
        }

        public static IntPtr DeriveWindow(IntPtr window, int rows, int columns, int y, int x)
        {
            IntPtr result = Native.derwin(window, rows, columns, y, x);
            NativeExceptionHelper.ThrowOnNullPointer(result, "DerWindow");
            return result;
        }

        public static void DoUpdate()
        {
            int result = Native.doupdate();
            NativeExceptionHelper.ThrowOnError(result, "DoUpdate");
        }

        public static IntPtr DuplicateWindow(IntPtr window)
        {
            IntPtr result = Native.dupwin(window);
            NativeExceptionHelper.ThrowOnNullPointer(result, "DuplicateWindow");
            return result;
        }

        public static void Echo()
        {
            int result = Native.echo();
            NativeExceptionHelper.ThrowOnError(result, "Echo");
        }

        public static void EndWin()
        {
            int result = Native.endwin();
            NativeExceptionHelper.ThrowOnError(result, "EndWin");
        }

        public static void Erase()
        {
            int result = Native.erase();
            NativeExceptionHelper.ThrowOnError(result, "Erase");
        }

        public static void Flash()
        {
            int result = Native.flash();
            NativeExceptionHelper.ThrowOnError(result, "Flash");
        }

        public static void FlushInputBuffer()
        {
            int result = Native.flushinp();
            NativeExceptionHelper.ThrowOnError(result, "FlushInputBuffer");
        }

        public static int GetChar()
        {
            int result = Native.getch();
            return result;
        }

        public static void GetMaxYX(IntPtr window, out int y, out int x)
        {
            y = Native.getmaxy(window);
            NativeExceptionHelper.ThrowOnError(y, "GetMaxYX");
            x = Native.getmaxx(window);
            NativeExceptionHelper.ThrowOnError(x, "GetMaxYX");
        }

        public static void GetMouse(out MouseEvent mouseEvent)
        {
            int result = Native.getmouse(out mouseEvent);
            NativeExceptionHelper.ThrowOnError(result, "GetMouse");
        }

        public static void GetString(StringBuilder message, int numberOfCharacters)
        {
            int result = Native.getnstr(message, numberOfCharacters);
            NativeExceptionHelper.ThrowOnError(result, "GetNString");
        }

        public static void GetString(StringBuilder message)
        {
            int result = Native.getstr(message);
            NativeExceptionHelper.ThrowOnError(result, "Getstring");
        }

        public static void GetYX(IntPtr window, out int y, out int x)
        {
            y = Native.getcury(window);
            NativeExceptionHelper.ThrowOnError(y, "GetYX");
            x = Native.getcurx(window);
            NativeExceptionHelper.ThrowOnError(x, "GetYX");
        }

        public static bool HasColors()
        {
            return Native.has_colors();
        }

        public static void InitColor(short color, short red, short green, short blue)
        {
            int result = Native.init_color(color, red, green, blue);
            NativeExceptionHelper.ThrowOnError(result, "InitColor");
        }

        public static int InitPair(short color, short foreground, short background)
        {
            int result = Native.init_pair(color, foreground, background);
            NativeExceptionHelper.ThrowOnError(result, "InitPair");
            return result;
        }

        public static IntPtr InitScreen()
        {
            IntPtr result = Native.initscr();
            NativeExceptionHelper.ThrowOnNullPointer(result, "InitScreen");
            return result;
        }

        public static void InsertChar(uint character)
        {
            int result = Native.insch(character);
            NativeExceptionHelper.ThrowOnError(result, "InsertCharacter");
        }

        public static void InsertLine()
        {
            int result = Native.insertln();
            NativeExceptionHelper.ThrowOnError(result, "InsertLine");
        }

        public static bool IsEndWin()
        {
            return Native.isendwin();
        }

        public static void Keypad(IntPtr window, bool enable)
        {
            int result = Native.keypad(window, enable);
            NativeExceptionHelper.ThrowOnError(result, "Keypad");
        }

        public static int Lines()
        {
            return Native.LINES();
        }

        public static long MouseMask(long newMask, out long oldMask)
        {
            return Native.mousemask(newMask, out oldMask);
        }

        public static int Move(int y, int x)
        {
            int result = Native.move(y, x);
            NativeExceptionHelper.ThrowOnError(result, "Move");
            return result;
        }

        public static int MoveAddChar(int y, int x, uint character)
        {
            int result = Native.mvaddch(y, x, character);
            NativeExceptionHelper.ThrowOnError(result, "MoveAddCharacter");
            return result;
        }

        public static int MoveAddString(int y, int x, string message)
        {
            int result = Native.mvaddstr(y, x, message);
            NativeExceptionHelper.ThrowOnError(result, "MoveAddString");
            return result;
        }

        public static int MoveWindowAddString(IntPtr window, int y, int x, string message)
        {
            int result = Native.mvwaddstr(window, y, x, message);
            NativeExceptionHelper.ThrowOnError(result, "MoveWAddString");
            return result;
        }

        public static void MoveWindow(IntPtr window, int row, int column)
        {
            int result = Native.mvwin(window, row, column);
            NativeExceptionHelper.ThrowOnError(result, "MoveWindow");
        }

        public static int Nap(int milliseconds)
        {
            int result = Native.napms(milliseconds);
            NativeExceptionHelper.ThrowOnError(result, "NapMilliseconds");
            return result;
        }

        public static IntPtr NewPad(int row, int column)
        {
            IntPtr result = Native.newpad(row, column);
            NativeExceptionHelper.ThrowOnNullPointer(result, "NewPad");
            return result;
        }

        public static IntPtr NewWindow(int rows, int columns, int yOrigin, int xOrigin)
        {
            IntPtr result = Native.newwin(rows, columns, yOrigin, xOrigin);
            NativeExceptionHelper.ThrowOnNullPointer(result, "NewWindow");
            return result;
        }

        public static void NoDelay(IntPtr window, bool removeDelay)
        {
            int result = Native.nodelay(window, removeDelay);
            NativeExceptionHelper.ThrowOnError(result, "NoDelay");
        }

        public static void NoEcho()
        {
            int result = Native.noecho();
            NativeExceptionHelper.ThrowOnError(result, "NoEcho");
        }

        public static void Overlay(IntPtr sourceWindow, IntPtr destinationWindow)
        {
            int result = Native.overlay(sourceWindow, destinationWindow);
            NativeExceptionHelper.ThrowOnError(result, "Overlay");
        }

        public static void Overwrite(IntPtr sourceWindow, IntPtr destinationWindow)
        {
            int result = Native.overwrite(sourceWindow, destinationWindow);
            NativeExceptionHelper.ThrowOnError(result, "Overwrite");
        }

        public static void PadNOutRefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn)
        {
            int result = Native.pnoutrefresh(pad, padMinRow, padMinColumn, screenMinRow, screenMinColumn, screenMaxRow, screenMaxColumn);
            NativeExceptionHelper.ThrowOnError(result, "PadNOutRefresh");
        }

        public static void PadRefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn)
        {
            int result = Native.prefresh(pad, padMinRow, padMinColumn, screenMinRow, screenMinColumn, screenMaxRow, screenMaxColumn);
            NativeExceptionHelper.ThrowOnError(result, "PadRefresh");
        }

        public static void PairContent(short pair, out short fg, out short bg)
        {
            int result = Native.pair_content(pair, out fg, out bg);
            NativeExceptionHelper.ThrowOnError(result, "PairContent");
        }

        public static int PadEchoChar(IntPtr pad, int character)
        {
            int result = Native.pechochar(pad, character);
            NativeExceptionHelper.ThrowOnError(result, "PadEchoChar");
            return result;
        }

        public static short PairNumber(uint pairNumber)
        {
            return Native.PAIR_NUMBER(pairNumber);
        }

        public static int Refresh()
        {
            int result = Native.refresh();
            NativeExceptionHelper.ThrowOnError(result, "Refresh");
            return result;
        }

        public static void ResizeTerminal(int numberOfLines, int numberOfColumns)
        {
            int result = Native.resize_term(numberOfLines, numberOfColumns);
            NativeExceptionHelper.ThrowOnError(result, "ResizeTerminal");
        }

        public static void ScrollLines(int numberOfLines)
        {
            int result = Native.scrl(numberOfLines);
            NativeExceptionHelper.ThrowOnError(result, "NumberOfLInes");
        }

        public static void Scroll(IntPtr window)
        {
            int result = Native.scroll(window);
            NativeExceptionHelper.ThrowOnError(result, "Scroll");
        }

        public static void ScrollOk(IntPtr window, bool canScroll)
        {
            int result = Native.scrollok(window, canScroll);
            NativeExceptionHelper.ThrowOnError(result, "ScrollOk");
        }

        public static int SetCursor(CursesCursorState cursorState)
        {
            int result = Native.curs_set((int)cursorState);
            return result;
        }

        public static void SoftKeyLabelsClear()
        {
            int result = Native.slk_clear();
            NativeExceptionHelper.ThrowOnError(result, "ClearSoftKeyLabels");
        }

        public static void SoftKeyLabelsInit(int numberOfLabels)
        {
            int result = Native.slk_init(numberOfLabels);
            NativeExceptionHelper.ThrowOnError(result, "InitSoftLabelKeys");
        }

        public static void SoftKeyLabelsRefresh()
        {
            int result = Native.slk_refresh();
            NativeExceptionHelper.ThrowOnError(result, "RefreshSoftKeyLabels");
        }

        public static void SoftKeyLabelsRestore()
        {
            int result = Native.slk_restore();
            NativeExceptionHelper.ThrowOnError(result, "RestoreSoftKeyLabels");
        }

        public static void SoftKeyLabelSet(int labelNumber, string text, CursesSoftKeyLabelPosition position)
        {
            int result = Native.slk_set(labelNumber, text, (int)position);
            NativeExceptionHelper.ThrowOnError(result, "SetSoftKeyLabel");
        }

        public static void StartColor()
        {
            int result = Native.start_color();
            NativeExceptionHelper.ThrowOnError(result, "StartColour");
        }

        public static IntPtr SubPad(IntPtr parent, int rows, int columns, int y, int x)
        {
            IntPtr result = Native.subpad(parent, rows, columns, y, x);
            NativeExceptionHelper.ThrowOnNullPointer(result, "SubPad");
            return result;
        }

        public static IntPtr SubWindow(IntPtr parent, int rows, int columns, int y, int x)
        {
            IntPtr result = Native.subwin(parent, rows, columns, y, x);
            NativeExceptionHelper.ThrowOnNullPointer(result, "SubWindow");
            return result;
        }

        public static void TouchLine(IntPtr window, int row, int column)
        {
            int result = Native.touchline(window, row, column);
            NativeExceptionHelper.ThrowOnError(result, "TouchLine");
        }

        public static int TouchWindow(IntPtr window)
        {
            int result = Native.touchwin(window);
            NativeExceptionHelper.ThrowOnError(result, "TouchWindow");
            return result;
        }

        public static int UngetChar(int character)
        {
            return Native.ungetch(character);
        }

        public static void UseDefaultColors()
        {
            int result = Native.use_default_colors();
            NativeExceptionHelper.ThrowOnError(result, "UseDefaultColors");
        }

        public static int WindowAddChar(IntPtr window, int character)
        {
            int result = Native.waddch(window, character);
            NativeExceptionHelper.ThrowOnError(result, "WAddChar");
            return result;
        }

        public static int WindowAddString(IntPtr window, string message)
        {
            int result = Native.waddstr(window, message);
            NativeExceptionHelper.ThrowOnError(result, "WAddStr");
            return result;
        }

        public static void WindowBackground(IntPtr window, uint ch)
        {
            int result = Native.wbkgd(window, ch);
            NativeExceptionHelper.ThrowOnError(result, "WindowBackground");
        }

        public static void WindowBorder(IntPtr window, char leftSide, char rightSide, char topSide, char bottomSide, char topLeftHandCorner, char topRightHandCorner, char bottomLeftHandCorner, char bottomRightHandCorner)
        {
            int result = Native.wborder(window, leftSide, rightSide, topSide, bottomSide, topLeftHandCorner, topRightHandCorner, bottomLeftHandCorner, bottomRightHandCorner);
            NativeExceptionHelper.ThrowOnError(result, "WindowBorder");
        }

        public static int WindowGetChar(IntPtr window)
        {
            int result = Native.wgetch(window);
            NativeExceptionHelper.ThrowOnError(result, "WGetChar");
            return result;
        }

        public static int WindowRefresh(IntPtr window)
        {
            int result = Native.wrefresh(window);
            NativeExceptionHelper.ThrowOnError(result, "WRefresh");
            return result;
        }

        public static void WindowScrollLines(IntPtr window, int numberOfLines)
        {
            int result = Native.wscrl(window, numberOfLines);
            NativeExceptionHelper.ThrowOnError(result, "WScrollNLInes");
        }
    }
}
