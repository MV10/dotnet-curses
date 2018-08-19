using System;
using System.Text;

namespace Mindmagma.Curses
{
    public class NCurses
    {
        public static int AddChar(int ch)
        {
            int result = Native.addch(ch);
            NativeExceptionHelper.ThrowOnError(result, nameof(AddChar));
            return result;
        }

        public static int AddString(string stringToAdd)
        {
            int result = Native.addstr(stringToAdd);
            NativeExceptionHelper.ThrowOnError(result, nameof(AddString));
            return result;
        }

        public static void AssumeDefaultColors(int f, int b)
        {
            int result = Native.assume_default_colors(f, b);
            NativeExceptionHelper.ThrowOnError(result, nameof(AssumeDefaultColors));
        }

        public static void AttributeOff(uint attributes)
        {
            int result = Native.attroff(attributes);
            NativeExceptionHelper.ThrowOnError(result, nameof(AttributeOff));
        }

        public static void AttributeOff(CursesAttribute attribute)
        {
            AttributeOff((uint)attribute);
        }

        public static void AttributeOn(uint attributes)
        {
            int result = Native.attron(attributes);
            NativeExceptionHelper.ThrowOnError(result, nameof(AttributeOn));
        }

        public static void AttributeOn(CursesAttribute attribute)
        {
            AttributeOn((uint)attribute);
        }

        public static void AttributeSet(uint attributes)
        {
            int result = Native.attrset(attributes);
            NativeExceptionHelper.ThrowOnError(result, nameof(AttributeSet));
        }

        public static void AttributeSet(CursesAttribute attribute)
        {
            AttributeSet((uint)attribute);
        }

        public static void Background(uint ch)
        {
            int result = Native.bkgd(ch);
            NativeExceptionHelper.ThrowOnError(result, nameof(Background));
        }

        public static void Beep()
        {
            int result = Native.beep();
            NativeExceptionHelper.ThrowOnError(result, nameof(Beep));
        }

        public static void Box(IntPtr window, char verticalChar, char horizontalChar)
        {
            int result = Native.box(window, verticalChar, horizontalChar);
            NativeExceptionHelper.ThrowOnError(result, nameof(Box));
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
            NativeExceptionHelper.ThrowOnError(result, nameof(Clear));
        }

        public static void ClearToEndOfLine()
        {
            int result = Native.clrtoeol();
            NativeExceptionHelper.ThrowOnError(result, nameof(ClearToEndOfLine));
        }

        public static void ClearToBottom()
        {
            int result = Native.clrtobot();
            NativeExceptionHelper.ThrowOnError(result, nameof(ClearToBottom));
        }

        public static void ClearWindow(IntPtr window)
        {
            int result = Native.wclear(window);
            NativeExceptionHelper.ThrowOnError(result, nameof(ClearWindow));
        }

        public static void ColorContent(short color, out short red, out short green, out short blue)
        {
            int result = Native.color_content(color, out red, out green, out blue);
            NativeExceptionHelper.ThrowOnError(result, nameof(ColorContent));
        }

        public static uint ColorPair(int pairNumber)
        {
            return Native.COLOR_PAIR(pairNumber);
        }

        public static void CopyWindow(IntPtr sourceWindow, IntPtr destinationWindow, int sourceRow, int sourceColumn, int destinationRow, int destinationColumn, int rowOffset, int columnOffset, bool type)
        {
            int result = Native.copywin(sourceWindow, destinationWindow, sourceRow, sourceColumn, destinationRow, destinationColumn, rowOffset, columnOffset, type);
            NativeExceptionHelper.ThrowOnError(result, nameof(CopyWindow));
        }

        public static void DeleteChar()
        {
            int result = Native.delch();
            NativeExceptionHelper.ThrowOnError(result, nameof(DeleteChar));
        }

        public static void DeleteLine()
        {
            int result = Native.deleteln();
            NativeExceptionHelper.ThrowOnError(result, nameof(DeleteLine));
        }

        public static int DeleteWindow(IntPtr window)
        {
            int result = Native.delwin(window);
            NativeExceptionHelper.ThrowOnError(result, nameof(DeleteWindow));
            return result;
        }

        public static IntPtr DeriveWindow(IntPtr window, int rows, int columns, int y, int x)
        {
            IntPtr result = Native.derwin(window, rows, columns, y, x);
            NativeExceptionHelper.ThrowOnNullPointer(result, nameof(DeriveWindow));
            return result;
        }

        public static void DoUpdate()
        {
            int result = Native.doupdate();
            NativeExceptionHelper.ThrowOnError(result, nameof(DoUpdate));
        }

        public static IntPtr DuplicateWindow(IntPtr window)
        {
            IntPtr result = Native.dupwin(window);
            NativeExceptionHelper.ThrowOnNullPointer(result, nameof(DuplicateWindow));
            return result;
        }

        public static void Echo()
        {
            int result = Native.echo();
            NativeExceptionHelper.ThrowOnError(result, nameof(Echo));
        }

        public static void EndWin()
        {
            int result = Native.endwin();
            NativeExceptionHelper.ThrowOnError(result, nameof(EndWin));
        }

        public static void Erase()
        {
            int result = Native.erase();
            NativeExceptionHelper.ThrowOnError(result, nameof(Erase));
        }

        public static void Flash()
        {
            int result = Native.flash();
            NativeExceptionHelper.ThrowOnError(result, nameof(Flash));
        }

        public static void FlushInputBuffer()
        {
            int result = Native.flushinp();
            NativeExceptionHelper.ThrowOnError(result, nameof(FlushInputBuffer));
        }

        public static int GetChar()
        {
            int result = Native.getch(); // -1 is no character buffered, not ERR
            return result;
        }

        public static void GetMaxYX(IntPtr window, out int y, out int x)
        {
            y = Native.getmaxy(window);
            NativeExceptionHelper.ThrowOnError(y, nameof(GetMaxYX));
            x = Native.getmaxx(window);
            NativeExceptionHelper.ThrowOnError(x, nameof(GetMaxYX));
        }

        public static void GetMouse(out MouseEvent mouseEvent)
        {
            int result = Native.getmouse(out mouseEvent);
            NativeExceptionHelper.ThrowOnError(result, nameof(GetMouse));
        }

        public static void GetString(StringBuilder message, int numberOfCharacters)
        {
            int result = Native.getnstr(message, numberOfCharacters);
            NativeExceptionHelper.ThrowOnError(result, nameof(GetString));
        }

        public static void GetString(StringBuilder message)
        {
            int result = Native.getstr(message);
            NativeExceptionHelper.ThrowOnError(result, nameof(GetString));
        }

        public static void GetYX(IntPtr window, out int y, out int x)
        {
            y = Native.getcury(window);
            NativeExceptionHelper.ThrowOnError(y, nameof(GetYX));
            x = Native.getcurx(window);
            NativeExceptionHelper.ThrowOnError(x, nameof(GetYX));
        }

        public static bool HasColors()
        {
            return Native.has_colors();
        }

        public static void InitColor(short color, short red, short green, short blue)
        {
            int result = Native.init_color(color, red, green, blue);
            NativeExceptionHelper.ThrowOnError(result, nameof(InitColor));
        }

        public static int InitPair(short color, short foreground, short background)
        {
            int result = Native.init_pair(color, foreground, background);
            NativeExceptionHelper.ThrowOnError(result, nameof(InitPair));
            return result;
        }

        public static IntPtr InitScreen()
        {
            IntPtr result = Native.initscr();
            NativeExceptionHelper.ThrowOnNullPointer(result, nameof(InitScreen));
            return result;
        }

        public static void InsertChar(uint character)
        {
            int result = Native.insch(character);
            NativeExceptionHelper.ThrowOnError(result, nameof(InsertChar));
        }

        public static void InsertLine()
        {
            int result = Native.insertln();
            NativeExceptionHelper.ThrowOnError(result, nameof(InsertLine));
        }

        public static bool IsEndWin()
        {
            return Native.isendwin();
        }

        public static void Keypad(IntPtr window, bool enable)
        {
            int result = Native.keypad(window, enable);
            NativeExceptionHelper.ThrowOnError(result, nameof(Keypad));
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
            NativeExceptionHelper.ThrowOnError(result, nameof(Move));
            return result;
        }

        public static int MoveAddChar(int y, int x, uint character)
        {
            int result = Native.mvaddch(y, x, character);
            NativeExceptionHelper.ThrowOnError(result, nameof(MoveAddChar));
            return result;
        }

        public static int MoveAddString(int y, int x, string message)
        {
            int result = Native.mvaddstr(y, x, message);
            NativeExceptionHelper.ThrowOnError(result, nameof(MoveAddString));
            return result;
        }

        public static int MoveWindowAddString(IntPtr window, int y, int x, string message)
        {
            int result = Native.mvwaddstr(window, y, x, message);
            NativeExceptionHelper.ThrowOnError(result, nameof(MoveWindowAddString));
            return result;
        }

        public static void MoveWindow(IntPtr window, int row, int column)
        {
            int result = Native.mvwin(window, row, column);
            NativeExceptionHelper.ThrowOnError(result, nameof(MoveWindow));
        }

        public static int Nap(int milliseconds)
        {
            int result = Native.napms(milliseconds);
            NativeExceptionHelper.ThrowOnError(result, nameof(Nap));
            return result;
        }

        public static IntPtr NewPad(int row, int column)
        {
            IntPtr result = Native.newpad(row, column);
            NativeExceptionHelper.ThrowOnNullPointer(result, nameof(NewPad));
            return result;
        }

        public static IntPtr NewWindow(int rows, int columns, int yOrigin, int xOrigin)
        {
            IntPtr result = Native.newwin(rows, columns, yOrigin, xOrigin);
            NativeExceptionHelper.ThrowOnNullPointer(result, nameof(NewWindow));
            return result;
        }

        public static void NoDelay(IntPtr window, bool removeDelay)
        {
            int result = Native.nodelay(window, removeDelay);
            NativeExceptionHelper.ThrowOnError(result, nameof(NoDelay));
        }

        public static void NoEcho()
        {
            int result = Native.noecho();
            NativeExceptionHelper.ThrowOnError(result, nameof(NoEcho));
        }

        public static void Overlay(IntPtr sourceWindow, IntPtr destinationWindow)
        {
            int result = Native.overlay(sourceWindow, destinationWindow);
            NativeExceptionHelper.ThrowOnError(result, nameof(Overlay));
        }

        public static void Overwrite(IntPtr sourceWindow, IntPtr destinationWindow)
        {
            int result = Native.overwrite(sourceWindow, destinationWindow);
            NativeExceptionHelper.ThrowOnError(result, nameof(Overwrite));
        }

        public static void PadNOutRefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn)
        {
            int result = Native.pnoutrefresh(pad, padMinRow, padMinColumn, screenMinRow, screenMinColumn, screenMaxRow, screenMaxColumn);
            NativeExceptionHelper.ThrowOnError(result, nameof(PadNOutRefresh));
        }

        public static void PadRefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn)
        {
            int result = Native.prefresh(pad, padMinRow, padMinColumn, screenMinRow, screenMinColumn, screenMaxRow, screenMaxColumn);
            NativeExceptionHelper.ThrowOnError(result, nameof(PadRefresh));
        }

        public static void PairContent(short pair, out short fg, out short bg)
        {
            int result = Native.pair_content(pair, out fg, out bg);
            NativeExceptionHelper.ThrowOnError(result, nameof(PairContent));
        }

        public static int PadEchoChar(IntPtr pad, int character)
        {
            int result = Native.pechochar(pad, character);
            NativeExceptionHelper.ThrowOnError(result, nameof(PadEchoChar));
            return result;
        }

        public static short PairNumber(uint pairNumber)
        {
            return Native.PAIR_NUMBER(pairNumber);
        }

        public static int Refresh()
        {
            int result = Native.refresh();
            NativeExceptionHelper.ThrowOnError(result, nameof(Refresh));
            return result;
        }

        public static void ResizeTerminal(int numberOfLines, int numberOfColumns)
        {
            int result = Native.resize_term(numberOfLines, numberOfColumns);
            NativeExceptionHelper.ThrowOnError(result, nameof(ResizeTerminal));
        }

        public static void ScrollLines(int numberOfLines)
        {
            int result = Native.scrl(numberOfLines);
            NativeExceptionHelper.ThrowOnError(result, nameof(ScrollLines));
        }

        public static void Scroll(IntPtr window)
        {
            int result = Native.scroll(window);
            NativeExceptionHelper.ThrowOnError(result, nameof(Scroll));
        }

        public static void ScrollOk(IntPtr window, bool canScroll)
        {
            int result = Native.scrollok(window, canScroll);
            NativeExceptionHelper.ThrowOnError(result, nameof(ScrollOk));
        }

        public static int SetCursor(CursesCursorState cursorState)
        {
            int result = Native.curs_set((int)cursorState);
            NativeExceptionHelper.ThrowOnError(result, nameof(SetCursor));
            return result;
        }

        public static void SoftKeyLabelsClear()
        {
            int result = Native.slk_clear();
            NativeExceptionHelper.ThrowOnError(result, nameof(SoftKeyLabelsClear));
        }

        public static void SoftKeyLabelSet(int labelNumber, string text, CursesSoftKeyLabelPosition position)
        {
            int result = Native.slk_set(labelNumber, text, (int)position);
            NativeExceptionHelper.ThrowOnError(result, nameof(SoftKeyLabelSet));
        }

        public static void SoftKeyLabelsInit(int numberOfLabels)
        {
            int result = Native.slk_init(numberOfLabels);
            NativeExceptionHelper.ThrowOnError(result, nameof(SoftKeyLabelsInit));
        }

        public static void SoftKeyLabelsRefresh()
        {
            int result = Native.slk_refresh();
            NativeExceptionHelper.ThrowOnError(result, nameof(SoftKeyLabelsRefresh));
        }

        public static void SoftKeyLabelsRestore()
        {
            int result = Native.slk_restore();
            NativeExceptionHelper.ThrowOnError(result, nameof(SoftKeyLabelsRestore));
        }

        public static void StartColor()
        {
            int result = Native.start_color();
            NativeExceptionHelper.ThrowOnError(result, nameof(StartColor));
        }

        public static IntPtr SubPad(IntPtr parent, int rows, int columns, int y, int x)
        {
            IntPtr result = Native.subpad(parent, rows, columns, y, x);
            NativeExceptionHelper.ThrowOnNullPointer(result, nameof(SubPad));
            return result;
        }

        public static IntPtr SubWindow(IntPtr parent, int rows, int columns, int y, int x)
        {
            IntPtr result = Native.subwin(parent, rows, columns, y, x);
            NativeExceptionHelper.ThrowOnNullPointer(result, nameof(SubWindow));
            return result;
        }

        public static void TouchLine(IntPtr window, int row, int column)
        {
            int result = Native.touchline(window, row, column);
            NativeExceptionHelper.ThrowOnError(result, nameof(TouchLine));
        }

        public static int TouchWindow(IntPtr window)
        {
            int result = Native.touchwin(window);
            NativeExceptionHelper.ThrowOnError(result, nameof(TouchWindow));
            return result;
        }

        public static int UngetChar(int character)
        {
            return Native.ungetch(character);
        }

        public static void UseDefaultColors()
        {
            int result = Native.use_default_colors();
            NativeExceptionHelper.ThrowOnError(result, nameof(UseDefaultColors));
        }

        public static int WindowAddChar(IntPtr window, int character)
        {
            int result = Native.waddch(window, character);
            NativeExceptionHelper.ThrowOnError(result, nameof(WindowAddChar));
            return result;
        }

        public static int WindowAddString(IntPtr window, string message)
        {
            int result = Native.waddstr(window, message);
            NativeExceptionHelper.ThrowOnError(result, nameof(WindowAddString));
            return result;
        }

        public static void WindowBackground(IntPtr window, uint ch)
        {
            int result = Native.wbkgd(window, ch);
            NativeExceptionHelper.ThrowOnError(result, nameof(WindowBackground));
        }

        public static void WindowBorder(IntPtr window, char leftSide, char rightSide, char topSide, char bottomSide, char topLeftHandCorner, char topRightHandCorner, char bottomLeftHandCorner, char bottomRightHandCorner)
        {
            int result = Native.wborder(window, leftSide, rightSide, topSide, bottomSide, topLeftHandCorner, topRightHandCorner, bottomLeftHandCorner, bottomRightHandCorner);
            NativeExceptionHelper.ThrowOnError(result, nameof(WindowBorder));
        }

        public static int WindowGetChar(IntPtr window)
        {
            int result = Native.wgetch(window);
            NativeExceptionHelper.ThrowOnError(result, nameof(WindowGetChar));
            return result;
        }

        public static int WindowRefresh(IntPtr window)
        {
            int result = Native.wrefresh(window);
            NativeExceptionHelper.ThrowOnError(result, nameof(WindowRefresh));
            return result;
        }

        public static void WindowScrollLines(IntPtr window, int numberOfLines)
        {
            int result = Native.wscrl(window, numberOfLines);
            NativeExceptionHelper.ThrowOnError(result, nameof(WindowScrollLines));
        }
    }
}
