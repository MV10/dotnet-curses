using System.Text;
using Mindmagma.Curses.Interop;

// common functions

namespace Mindmagma.Curses
{
    public static partial class NCurses
    {
        public static int AddChar(int ch)
        {
            int result = Native.addch(ch);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(AddChar));
            return result;
        }

        public static int AddString(string stringToAdd)
        {
            int result = Native.addstr(stringToAdd);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(AddString));
            return result;
        }

        public static void AssumeDefaultColors(int f, int b)
        {
            int result = Native.assume_default_colors(f, b);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(AssumeDefaultColors));
        }

        public static void AttributeOff(uint attributes)
        {
            int result = Native.attroff(attributes);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(AttributeOff));
        }

        public static void AttributeOn(uint attributes)
        {
            int result = Native.attron(attributes);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(AttributeOn));
        }

        public static void AttributeSet(uint attributes)
        {
            int result = Native.attrset(attributes);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(AttributeSet));
        }

        public static void Background(uint ch)
        {
            int result = Native.bkgd(ch);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Background));
        }

        public static void Beep()
        {
            int result = Native.beep();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Beep));
        }

        public static void Clear()
        {
            int result = Native.clear();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Clear));
        }

        public static void ClearToEndOfLine()
        {
            int result = Native.clrtoeol();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(ClearToEndOfLine));
        }

        public static void ClearToBottom()
        {
            int result = Native.clrtobot();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(ClearToBottom));
        }

        public static void ColorContent(short color, out short red, out short green, out short blue)
        {
            int result = Native.color_content(color, out red, out green, out blue);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(ColorContent));
        }

        public static uint ColorPair(int pairNumber)
        {
            return Native.COLOR_PAIR(pairNumber);
        }

        public static void DeleteChar()
        {
            int result = Native.delch();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(DeleteChar));
        }

        public static void DeleteLine()
        {
            int result = Native.deleteln();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(DeleteLine));
        }

        public static void DoUpdate()
        {
            int result = Native.doupdate();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(DoUpdate));
        }

        public static void Echo()
        {
            int result = Native.echo();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Echo));
        }

        public static void Erase()
        {
            int result = Native.erase();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Erase));
        }

        public static void Flash()
        {
            int result = Native.flash();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Flash));
        }

        public static void FlushInputBuffer()
        {
            int result = Native.flushinp();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(FlushInputBuffer));
        }

        public static int GetChar()
        {
            int result = Native.getch(); // -1 is no character buffered, not ERR
            return result;
        }

        public static void GetMouse(out MouseEvent mouseEvent)
        {
            int result = Native.getmouse(out mouseEvent);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(GetMouse));
        }

        public static void GetString(StringBuilder message, int numberOfCharacters)
        {
            int result = Native.getnstr(message, numberOfCharacters);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(GetString));
        }

        public static void GetString(StringBuilder message)
        {
            int result = Native.getstr(message);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(GetString));
        }

        public static void InitColor(short color, short red, short green, short blue)
        {
            int result = Native.init_color(color, red, green, blue);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(InitColor));
        }

        public static int InitPair(short color, short foreground, short background)
        {
            int result = Native.init_pair(color, foreground, background);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(InitPair));
            return result;
        }

        public static void InsertChar(uint character)
        {
            int result = Native.insch(character);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(InsertChar));
        }

        public static void InsertLine()
        {
            int result = Native.insertln();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(InsertLine));
        }

        public static uint MouseMask(uint newMask, out uint oldMask)
        {
            return Native.mousemask(newMask, out oldMask);
        }

        public static int Move(int y, int x)
        {
            int result = Native.move(y, x);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Move));
            return result;
        }

        public static int MoveAddChar(int y, int x, uint character)
        {
            int result = Native.mvaddch(y, x, character);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(MoveAddChar));
            return result;
        }

        public static int MoveAddString(int y, int x, string message)
        {
            int result = Native.mvaddstr(y, x, message);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(MoveAddString));
            return result;
        }

        public static void PairContent(short pair, out short fg, out short bg)
        {
            int result = Native.pair_content(pair, out fg, out bg);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(PairContent));
        }

        public static short PairNumber(uint pairNumber)
        {
            return Native.PAIR_NUMBER(pairNumber);
        }

        public static int Refresh()
        {
            int result = Native.refresh();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Refresh));
            return result;
        }

        public static void ResizeTerminal(int numberOfLines, int numberOfColumns)
        {
            int result = Native.resize_term(numberOfLines, numberOfColumns);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(ResizeTerminal));
        }

        public static void ScrollLines(int numberOfLines)
        {
            int result = Native.scrl(numberOfLines);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(ScrollLines));
        }

        public static int SetCursor(int cursorState)
        {
            int result = Native.curs_set(cursorState);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(SetCursor));
            return result;
        }

        public static void SoftKeyLabelsClear()
        {
            int result = Native.slk_clear();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(SoftKeyLabelsClear));
        }

        public static void SoftKeyLabelSet(int labelNumber, string text, int cursesSoftKeyLabelPosition)
        {
            int result = Native.slk_set(labelNumber, text, cursesSoftKeyLabelPosition);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(SoftKeyLabelSet));
        }

        public static void SoftKeyLabelsInit(int numberOfLabels)
        {
            int result = Native.slk_init(numberOfLabels);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(SoftKeyLabelsInit));
        }

        public static void SoftKeyLabelsRefresh()
        {
            int result = Native.slk_refresh();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(SoftKeyLabelsRefresh));
        }

        public static void SoftKeyLabelsRestore()
        {
            int result = Native.slk_restore();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(SoftKeyLabelsRestore));
        }

        public static void StartColor()
        {
            int result = Native.start_color();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(StartColor));
        }

        public static int UngetChar(int character)
        {
            return Native.ungetch(character);
        }

        public static void UseDefaultColors()
        {
            int result = Native.use_default_colors();
            NativeExceptionHelper.ThrowOnFailure(result, nameof(UseDefaultColors));
        }

    }
}
