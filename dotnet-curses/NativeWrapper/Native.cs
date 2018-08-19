using System;
using System.Runtime.InteropServices;
using System.Text;

#pragma warning disable IDE1006 // naming rule violation, methods must begin with uppercase

namespace Mindmagma.Curses.Interop
{
    // http://invisible-island.net/ncurses/man/ncurses.3x.html#h3-Routine-Name-Index

    public static class Native
    {
        // Non-versioned file extensions (.dll, .so, .dylib) are optional,
        // all three OSes will search for the file in the same way. The
        // convention of specifying a version in OSX (libxyz.ver.dylib) and
        // Linux (libxyz.so.major.minor) requires the full filename. This
        // can be avoided by using a non-version symlink to point to the
        // desired versioned library file.

        #if RUNTIME_OSX
            const string cursesLib = "ncurses";
        #elif RUNTIME_LINUX
            const string cursesLib = "libncurses.so.5.9";
        #else // RUNTIME_WINDOWS
            const string cursesLib = "libncursesw6";
        #endif

        [DllImport(cursesLib)]
        public static extern int addch(int ch);

        [DllImport(cursesLib)]
        public static extern int assume_default_colors(int f, int b);

        [DllImport(cursesLib, CharSet = CharSet.Ansi)]
        public static extern int addstr(String str);

        [DllImport(cursesLib)]
        public static extern int attroff(uint attributes);

        [DllImport(cursesLib)]
        public static extern int attron(uint attributes);

        [DllImport(cursesLib)]
        public static extern int attrset(uint attributes);

        [DllImport(cursesLib)]
        public static extern int beep();

        [DllImport(cursesLib)]
        public static extern int bkgd(uint ch);

        [DllImport(cursesLib)]
        public static extern int box(IntPtr window, char verticalChar, char horizontalChar);

        [DllImport(cursesLib)]
        public static extern Boolean can_change_color();

        [DllImport(cursesLib)]
        public static extern int clear();

        public static int COLS()
        {
            return ExportedSymbol.GetInt(cursesLib, "COLS");
        }

        [DllImport(cursesLib)]
        public static extern int color_content(short color, out short red, out short green, out short blue);

        [DllImport(cursesLib)]
        public static extern uint COLOR_PAIR(int n);

        [DllImport(cursesLib)]
        public static extern int copywin(IntPtr sourceWindow, IntPtr destinationWindow, int sourceRow, int sourceColumn, int destinationRow, int destinationColumn, int rowOffset, int columnOffset, bool type);

        [DllImport(cursesLib)]
        public static extern int clrtobot();

        [DllImport(cursesLib)]
        public static extern int clrtoeol();

        [DllImport(cursesLib)]
        public static extern int delch();

        [DllImport(cursesLib)]
        public static extern int deleteln();

        [DllImport(cursesLib)]
        public static extern int delwin(IntPtr window);

        [DllImport(cursesLib)]
        public static extern IntPtr derwin(IntPtr window, int rows, int columns, int y, int x);

        [DllImport(cursesLib)]
        public static extern int doupdate();

        [DllImport(cursesLib)]
        public static extern IntPtr dupwin(IntPtr window);

        [DllImport(cursesLib)]
        public static extern int echo();

        [DllImport(cursesLib)]
        public static extern int endwin();

        [DllImport(cursesLib)]
        public static extern int erase();

        [DllImport(cursesLib)]
        public static extern int flash();

        [DllImport(cursesLib)]
        public static extern int flushinp();

        [DllImport(cursesLib)]
        public static extern int getch();

        [DllImport(cursesLib)]
        public static extern int getcurx(IntPtr window);

        [DllImport(cursesLib)]
        public static extern int getcury(IntPtr window);

        [DllImport(cursesLib)]
        public static extern int getmaxx(IntPtr window);

        [DllImport(cursesLib)]
        public static extern int getmaxy(IntPtr window);

        [DllImport(cursesLib)]
        public static extern int getmouse(out MouseEvent mouseEvent);

        [DllImport(cursesLib)]
        public static extern int getnstr(StringBuilder message, int numberOfCharacters);

        [DllImport(cursesLib)]
        public static extern int getstr(StringBuilder message);

        [DllImport(cursesLib)]
        public static extern Boolean has_colors();

        [DllImport(cursesLib)]
        public static extern int init_color(short color, short red, short green, short blue);

        [DllImport(cursesLib)]
        public static extern IntPtr initscr();

        [DllImport(cursesLib)]
        public static extern int init_pair(short color, short fg, short bg);

        [DllImport(cursesLib)]
        public static extern int insch(uint character);

        [DllImport(cursesLib)]
        public static extern int insertln();

        [DllImport(cursesLib)]
        public static extern Boolean isendwin();

        [DllImport(cursesLib)]
        public static extern int keypad(IntPtr window, bool enable);

        public static int LINES()
        {
            return ExportedSymbol.GetInt(cursesLib, "LINES");
        }

        [DllImport(cursesLib)]
        public static extern long mousemask(long newMask, out long oldmask);

        [DllImport(cursesLib)]
        public static extern int move(int y, int x);

        [DllImport(cursesLib)]
        public static extern int mvaddch(int row, int column, uint character);

        [DllImport(cursesLib)]
        public static extern int mvaddchnstr(int row, int column, uint character, int numberOfCharacters);

        [DllImport(cursesLib)]
        public static extern int mvaddchstr(int row, int column, uint character);

        [DllImport(cursesLib)]
        public static extern int mvaddnstr(int row, int column, uint character, int numberOfCharacters);

        [DllImport(cursesLib)]
        public static extern int mvaddstr(int row, int column, string message);

        [DllImport(cursesLib)]
        public static extern int mvwaddstr(IntPtr window, int y, int x, string message);

        [DllImport(cursesLib)]
        public static extern int mvwin(IntPtr window, int row, int column);

        [DllImport(cursesLib)]
        public static extern int napms(int milliseconds);

        [DllImport(cursesLib)]
        public static extern IntPtr newpad(int row, int column);

        [DllImport(cursesLib)]
        public static extern IntPtr newwin(int rows, int columns, int yOrigin, int xOrigin);

        [DllImport(cursesLib)]
        public static extern int nodelay(IntPtr window, bool removeDelay);

        [DllImport(cursesLib)]
        public static extern int noecho();

        [DllImport(cursesLib)]
        public static extern int overlay(IntPtr sourceWindow, IntPtr destinationWindow);

        [DllImport(cursesLib)]
        public static extern int overwrite(IntPtr sourceWindow, IntPtr destinationWindow);

        [DllImport(cursesLib)]
        public static extern short PAIR_NUMBER(uint n);

        [DllImport(cursesLib)]
        public static extern int pair_content(short pair, out short fg, out short bg);

        [DllImport(cursesLib)]
        public static extern int pechochar(IntPtr pad, int character);

        [DllImport(cursesLib)]
        public static extern int pnoutrefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn);

        [DllImport(cursesLib)]
        public static extern int prefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn);

        [DllImport(cursesLib)]
        public static extern int refresh();

        [DllImport(cursesLib)]
        public static extern int resize_term(int nlines, int ncols);

        [DllImport(cursesLib)]
        public static extern int scrl(int numberOfLines);

        [DllImport(cursesLib)]
        public static extern int scroll(IntPtr window);

        [DllImport(cursesLib)]
        public static extern int scrollok(IntPtr window, bool canScroll);

        [DllImport(cursesLib)]
        public static extern int curs_set(int cursorState);

        [DllImport(cursesLib)]
        public static extern int slk_clear();

        [DllImport(cursesLib)]
        public static extern int slk_init(int numberOfLabels);

        [DllImport(cursesLib)]
        public static extern int slk_refresh();

        [DllImport(cursesLib)]
        public static extern int slk_restore();

        [DllImport(cursesLib)]
        public static extern int slk_set(int labelNumber, string text, int position);

        [DllImport(cursesLib)]
        public static extern int start_color();

        [DllImport(cursesLib)]
        public static extern IntPtr subpad(IntPtr parent, int row, int column, int y, int x);

        [DllImport(cursesLib)]
        public static extern IntPtr subwin(IntPtr window, int rows, int colums, int y, int x);

        [DllImport(cursesLib)]
        public static extern int touchline(IntPtr window, int row, int column);

        [DllImport(cursesLib)]
        public static extern int touchwin(IntPtr window);

        [DllImport(cursesLib)]
        public static extern int ungetch(int character);

        [DllImport(cursesLib)]
        public static extern int use_default_colors();

        [DllImport(cursesLib)]
        public static extern int waddch(IntPtr window, int character);

        [DllImport(cursesLib, CharSet = CharSet.Ansi)]
        public static extern int waddstr(IntPtr window, string message);

        [DllImport(cursesLib, CharSet = CharSet.Ansi)]
        public static extern int waddnstr(IntPtr win, String str, int n);

        [DllImport(cursesLib)]
        public static extern int wbkgd(IntPtr window, uint ch);

        [DllImport(cursesLib)]
        public static extern int wborder(IntPtr window, char leftSide, char rightSide, char topSide, char bottomSide, char topLeftHandCorner, char topRightHandCorner, char bottomLeftHandCorner, char bottomRightHandCorner);

        [DllImport(cursesLib)]
        public static extern int wclear(IntPtr window);

        [DllImport(cursesLib)]
        public static extern int wgetch(IntPtr win);

        [DllImport(cursesLib)]
        public static extern int wrefresh(IntPtr win);

        [DllImport(cursesLib)]
        public static extern int wscrl(IntPtr window, int numberOfLines);
    }
}
