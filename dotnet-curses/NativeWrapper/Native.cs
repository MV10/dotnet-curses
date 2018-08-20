using System;
using System.Runtime.InteropServices;
using System.Text;
using NativeLibraryLoader;

#pragma warning disable IDE1006 // naming rule violation, methods must begin with uppercase

// ncurses export list
// http://invisible-island.net/ncurses/man/ncurses.3x.html#h3-Routine-Name-Index

// depends upon this project until .NET adds this capability
// https://github.com/mellinoe/nativelibraryloader
// https://github.com/dotnet/corefx/issues/17135



namespace Mindmagma.Curses.Interop
{
    internal static class Native
    {
        private static readonly NativeLibrary sym_ncurses = LoadLibrary();
        private static NativeLibrary LoadLibrary()
        {
            string[] names;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                names = new[] { "libncursesw6.dll" };
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                names = new[]
                {
                    "libncurses.so.5.9",
                    "libncurses.so"
                };
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                names = new[]
                {
                    "ncurses.dylib"
                };
            }
            else
            {
                throw new Exception("Unsupported OSPlatform, can't locate ncurses library.");
            }

            NativeLibrary lib = new NativeLibrary(names);
            return lib;
        }

        private static T LoadFunction<T>(string methodName)
        {
            return sym_ncurses.LoadFunction<T>(methodName);
        }

        private static int GetInt(string exportedSymbolName)
        {
            IntPtr address = sym_ncurses.LoadFunction(exportedSymbolName);
            return (int)Marshal.PtrToStructure(address, typeof(int));
        }

        // Exported data
        internal static int COLS => GetInt("COLS");
        internal static int LINES => GetInt("LINES");

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_addch(int ch);
        private static type_addch sym_addch = LoadFunction<type_addch>("addch");
        internal static int addch(int ch) => sym_addch(ch);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_assume_default_colors(int f, int b);
        private static type_assume_default_colors sym_assume_default_colors = LoadFunction <type_assume_default_colors>("assume_default_colors");
        internal static int assume_default_colors(int f, int b) => sym_assume_default_colors(f, b);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int type_addstr(String str);
        private static type_addstr sym_addstr = LoadFunction <type_addstr>("addstr");
        internal static int addstr(string str) => sym_addstr(str);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_attroff(uint attributes);
        private static type_attroff sym_attroff = LoadFunction <type_attroff>("attroff");
        internal static int attroff(uint attributes) => sym_attroff(attributes);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_attron(uint attributes);
        private static type_attron sym_attron = LoadFunction <type_attron>("attron");
        internal static int attron(uint attributes) => sym_attron(attributes);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_attrset(uint attributes);
        private static type_attrset sym_attrset = LoadFunction <type_attrset>("attrset");
        internal static int attrset(uint attributes) => sym_attrset(attributes);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_beep();
        private static type_beep sym_beep = LoadFunction <type_beep>("beep");
        internal static int beep() => sym_beep();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_bkgd(uint ch);
        private static type_bkgd sym_bkgd = LoadFunction <type_bkgd>("bkgd");
        internal static int bkgd(uint ch) => sym_bkgd(ch);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_box(IntPtr window, char verticalChar, char horizontalChar);
        private static type_box sym_box = LoadFunction <type_box>("box");
        internal static int box(IntPtr window, char verticalChar, char horizontalChar) => sym_box(window, verticalChar, horizontalChar);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool type_can_change_color();
        private static type_can_change_color sym_can_change_color = LoadFunction <type_can_change_color>("can_change_color");
        internal static bool can_change_color() => sym_can_change_color();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_clear();
        private static type_clear sym_clear = LoadFunction <type_clear>("clear");
        internal static int clear() => sym_clear();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_color_content(short color, out short red, out short green, out short blue);
        private static type_color_content sym_color_content = LoadFunction <type_color_content>("color_content");
        internal static int color_content(short color, out short red, out short green, out short blue) => sym_color_content(color, out red, out green, out blue);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate uint type_COLOR_PAIR(int n);
        private static type_COLOR_PAIR sym_COLOR_PAIR = LoadFunction <type_COLOR_PAIR>("COLOR_PAIR");
        internal static uint COLOR_PAIR(int n) => sym_COLOR_PAIR(n);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_copywin(IntPtr sourceWindow, IntPtr destinationWindow, int sourceRow, int sourceColumn, int destinationRow, int destinationColumn, int rowOffset, int columnOffset, bool type);
        private static type_copywin sym_copywin = LoadFunction <type_copywin>("copywin");
        internal static int copywin(IntPtr sourceWindow, IntPtr destinationWindow, int sourceRow, int sourceColumn, int destinationRow, int destinationColumn, int rowOffset, int columnOffset, bool type) 
            => sym_copywin(sourceWindow, destinationWindow, sourceRow, sourceColumn, destinationRow, destinationColumn, rowOffset, columnOffset, type);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_clrtobot();
        private static type_clrtobot sym_clrtobot = LoadFunction <type_clrtobot>("clrtobot");
        internal static int clrtobot() => sym_clrtobot();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_clrtoeol();
        private static type_clrtoeol sym_clrtoeol = LoadFunction <type_clrtoeol>("clrtoeol");
        internal static int clrtoeol() => sym_clrtoeol();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_delch();
        private static type_delch sym_delch = LoadFunction <type_delch>("delch");
        internal static int delch() => sym_delch();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_deleteln();
        private static type_deleteln sym_deleteln = LoadFunction <type_deleteln>("deleteln");
        internal static int deleteln() => sym_deleteln();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_delwin(IntPtr window);
        private static type_delwin sym_delwin = LoadFunction <type_delwin>("delwin");
        internal static int delwin(IntPtr window) => sym_delwin(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr type_derwin(IntPtr window, int rows, int columns, int y, int x);
        private static type_derwin sym_derwin = LoadFunction <type_derwin>("derwin");
        internal static IntPtr derwin(IntPtr window, int rows, int columns, int y, int x) => sym_derwin(window, rows, columns, y, x);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_doupdate();
        private static type_doupdate sym_doupdate = LoadFunction <type_doupdate>("doupdate");
        internal static int doupdate() => sym_doupdate();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr type_dupwin(IntPtr window);
        private static type_dupwin sym_dupwin = LoadFunction <type_dupwin>("dupwin");
        internal static IntPtr dupwin(IntPtr window) => sym_dupwin(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_echo();
        private static type_echo sym_echo = LoadFunction <type_echo>("echo");
        internal static int echo() => sym_echo();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_endwin();
        private static type_endwin sym_endwin = LoadFunction <type_endwin>("endwin");
        internal static int endwin() => sym_endwin();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_erase();
        private static type_erase sym_erase = LoadFunction <type_erase>("erase");
        internal static int erase() => sym_erase();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_flash();
        private static type_flash sym_flash = LoadFunction <type_flash>("flash");
        internal static int flash() => sym_flash();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_flushinp();
        private static type_flushinp sym_flushinp = LoadFunction <type_flushinp>("flushinp");
        internal static int flushinp() => sym_flushinp();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_getch();
        private static type_getch sym_getch = LoadFunction <type_getch>("getch");
        internal static int getch() => sym_getch();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_getcurx(IntPtr window);
        private static type_getcurx sym_getcurx = LoadFunction <type_getcurx>("getcurx");
        internal static int getcurx(IntPtr window) => sym_getcurx(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_getcury(IntPtr window);
        private static type_getcury sym_getcury = LoadFunction <type_getcury>("getcury");
        internal static int getcury(IntPtr window) => sym_getcury(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_getmaxx(IntPtr window);
        private static type_getmaxx sym_getmaxx = LoadFunction <type_getmaxx>("getmaxx");
        internal static int getmaxx(IntPtr window) => sym_getmaxx(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_getmaxy(IntPtr window);
        private static type_getmaxy sym_getmaxy = LoadFunction <type_getmaxy>("getmaxy");
        internal static int getmaxy(IntPtr window) => sym_getmaxy(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_getmouse(out MouseEvent mouseEvent);
        private static type_getmouse sym_getmouse = LoadFunction <type_getmouse>("getmouse");
        internal static int getmouse(out MouseEvent mouseEvent) => sym_getmouse(out mouseEvent);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_getnstr(StringBuilder message, int numberOfCharacters);
        private static type_getnstr sym_getnstr = LoadFunction <type_getnstr>("getnstr");
        internal static int getnstr(StringBuilder message, int numberOfCharacters) => sym_getnstr(message, numberOfCharacters);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_getstr(StringBuilder message);
        private static type_getstr sym_getstr = LoadFunction <type_getstr>("getstr");
        internal static int getstr(StringBuilder message) => sym_getstr(message);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool type_has_colors();
        private static type_has_colors sym_has_colors = LoadFunction <type_has_colors>("has_colors");
        internal static bool has_colors() => sym_has_colors();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_init_color(short color, short red, short green, short blue);
        private static type_init_color sym_init_color = LoadFunction <type_init_color>("init_color");
        internal static int init_color(short color, short red, short green, short blue) => sym_init_color(color, red, green, blue);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr type_initscr();
        private static type_initscr sym_initscr = LoadFunction <type_initscr>("initscr");
        internal static IntPtr initscr() => sym_initscr();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_init_pair(short color, short fg, short bg);
        private static type_init_pair sym_init_pair = LoadFunction <type_init_pair>("init_pair");
        internal static int init_pair(short color, short fg, short bg) => sym_init_pair(color, fg, bg);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_insch(uint character);
        private static type_insch sym_insch = LoadFunction <type_insch>("insch");
        internal static int insch(uint character) => sym_insch(character);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_insertln();
        private static type_insertln sym_insertln = LoadFunction <type_insertln>("insertln");
        internal static int insertln() => sym_insertln();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool type_isendwin();
        private static type_isendwin sym_isendwin = LoadFunction <type_isendwin>("isendwin");
        internal static bool isendwin() => sym_isendwin();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_keypad(IntPtr window, bool enable);
        private static type_keypad sym_keypad = LoadFunction <type_keypad>("keypad");
        internal static int keypad(IntPtr window, bool enable) => sym_keypad(window, enable);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate long type_mousemask(long newMask, out long oldmask);
        private static type_mousemask sym_mousemask = LoadFunction <type_mousemask>("mousemask");
        internal static long mousemask(long newMask, out long oldmask) => sym_mousemask(newMask, out oldmask);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_move(int y, int x);
        private static type_move sym_move = LoadFunction <type_move>("move");
        internal static int move(int y, int x) => sym_move(y, x);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_mvaddch(int row, int column, uint character);
        private static type_mvaddch sym_mvaddch = LoadFunction <type_mvaddch>("mvaddch");
        internal static int mvaddch(int row, int column, uint character) => sym_mvaddch(row, column, character);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_mvaddchnstr(int row, int column, uint character, int numberOfCharacters);
        private static type_mvaddchnstr sym_mvaddchnstr = LoadFunction <type_mvaddchnstr>("mvaddchnstr");
        internal static int mvaddchnstr(int row, int column, uint character, int numberOfCharacters) => sym_mvaddchnstr(row, column, character, numberOfCharacters);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_mvaddchstr(int row, int column, uint character);
        private static type_mvaddchstr sym_mvaddchstr = LoadFunction <type_mvaddchstr>("mvaddchstr");
        internal static int mvaddchstr(int row, int column, uint character) => sym_mvaddchstr(row, column, character);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_mvaddnstr(int row, int column, uint character, int numberOfCharacters);
        private static type_mvaddnstr sym_mvaddnstr = LoadFunction <type_mvaddnstr>("mvaddnstr");
        internal static int mvaddnstr(int row, int column, uint character, int numberOfCharacters) => sym_mvaddnstr(row, column, character, numberOfCharacters);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_mvaddstr(int row, int column, string message);
        private static type_mvaddstr sym_mvaddstr = LoadFunction <type_mvaddstr>("mvaddstr");
        internal static int mvaddstr(int row, int column, string message) => sym_mvaddstr(row, column, message);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_mvwaddstr(IntPtr window, int y, int x, string message);
        private static type_mvwaddstr sym_mvwaddstr = LoadFunction <type_mvwaddstr>("mvwaddstr");
        internal static int mvwaddstr(IntPtr window, int y, int x, string message) => sym_mvwaddstr(window, y, x, message);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_mvwin(IntPtr window, int row, int column);
        private static type_mvwin sym_mvwin = LoadFunction <type_mvwin>("mvwin");
        internal static int mvwin(IntPtr window, int row, int column) => sym_mvwin(window, row, column);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_napms(int milliseconds);
        private static type_napms sym_napms = LoadFunction <type_napms>("napms");
        internal static int napms(int milliseconds) => sym_napms(milliseconds);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr type_newpad(int row, int column);
        private static type_newpad sym_newpad = LoadFunction <type_newpad>("newpad");
        internal static IntPtr newpad(int row, int column) => sym_newpad(row, column);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr type_newwin(int rows, int columns, int yOrigin, int xOrigin);
        private static type_newwin sym_newwin = LoadFunction <type_newwin>("newwin");
        internal static IntPtr newwin(int rows, int columns, int yOrigin, int xOrigin) => sym_newwin(rows, columns, yOrigin, xOrigin);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_nodelay(IntPtr window, bool removeDelay);
        private static type_nodelay sym_nodelay = LoadFunction <type_nodelay>("nodelay");
        internal static int nodelay(IntPtr window, bool removeDelay) => sym_nodelay(window, removeDelay);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_noecho();
        private static type_noecho sym_noecho = LoadFunction <type_noecho>("noecho");
        internal static int noecho() => sym_noecho();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_overlay(IntPtr sourceWindow, IntPtr destinationWindow);
        private static type_overlay sym_overlay = LoadFunction <type_overlay>("overlay");
        internal static int overlay(IntPtr sourceWindow, IntPtr destinationWindow) => sym_overlay(sourceWindow, destinationWindow);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_overwrite(IntPtr sourceWindow, IntPtr destinationWindow);
        private static type_overwrite sym_overwrite = LoadFunction <type_overwrite>("overwrite");
        internal static int overwrite(IntPtr sourceWindow, IntPtr destinationWindow) => sym_overwrite(sourceWindow, destinationWindow);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate short type_PAIR_NUMBER(uint n);
        private static type_PAIR_NUMBER sym_PAIR_NUMBER = LoadFunction <type_PAIR_NUMBER>("PAIR_NUMBER");
        internal static short PAIR_NUMBER(uint n) => sym_PAIR_NUMBER(n);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_pair_content(short pair, out short fg, out short bg);
        private static type_pair_content sym_pair_content = LoadFunction <type_pair_content>("pair_content");
        internal static int pair_content(short pair, out short fg, out short bg) => sym_pair_content(pair, out fg, out bg);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_pechochar(IntPtr pad, int character);
        private static type_pechochar sym_pechochar = LoadFunction <type_pechochar>("pechochar");
        internal static int pechochar(IntPtr pad, int character) => sym_pechochar(pad, character);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_pnoutrefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn);
        private static type_pnoutrefresh sym_pnoutrefresh = LoadFunction <type_pnoutrefresh>("pnoutrefresh");
        internal static int pnoutrefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn) 
            => sym_pnoutrefresh(pad, padMinRow, padMinColumn, screenMinRow, screenMinColumn, screenMaxRow, screenMaxColumn);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_prefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn);
        private static type_prefresh sym_prefresh = LoadFunction <type_prefresh>("prefresh");
        internal static int prefresh(IntPtr pad, int padMinRow, int padMinColumn, int screenMinRow, int screenMinColumn, int screenMaxRow, int screenMaxColumn) 
            => sym_prefresh(pad, padMinRow, padMinColumn, screenMinRow, screenMinColumn, screenMaxRow, screenMaxColumn);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_refresh();
        private static type_refresh sym_refresh = LoadFunction <type_refresh>("refresh");
        internal static int refresh() => sym_refresh();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_resize_term(int nlines, int ncols);
        private static type_resize_term sym_resize_term = LoadFunction <type_resize_term>("resize_term");
        internal static int resize_term(int nlines, int ncols) => sym_resize_term(nlines, ncols);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_scrl(int numberOfLines);
        private static type_scrl sym_scrl = LoadFunction <type_scrl>("scrl");
        internal static int scrl(int numberOfLines) => sym_scrl(numberOfLines);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_scroll(IntPtr window);
        private static type_scroll sym_scroll = LoadFunction <type_scroll>("scroll");
        internal static int scroll(IntPtr window) => sym_scroll(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_scrollok(IntPtr window, bool canScroll);
        private static type_scrollok sym_scrollok = LoadFunction <type_scrollok>("scrollok");
        internal static int scrollok(IntPtr window, bool canScroll) => sym_scrollok(window, canScroll);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_curs_set(int cursorState);
        private static type_curs_set sym_curs_set = LoadFunction <type_curs_set>("curs_set");
        internal static int curs_set(int cursorState) => sym_curs_set(cursorState);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_slk_clear();
        private static type_slk_clear sym_slk_clear = LoadFunction <type_slk_clear>("slk_clear");
        internal static int slk_clear() => sym_slk_clear();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_slk_init(int numberOfLabels);
        private static type_slk_init sym_slk_init = LoadFunction <type_slk_init>("slk_init");
        internal static int slk_init(int numberOfLabels) => sym_slk_init(numberOfLabels);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_slk_refresh();
        private static type_slk_refresh sym_slk_refresh = LoadFunction <type_slk_refresh>("slk_refresh");
        internal static int slk_refresh() => sym_slk_refresh();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_slk_restore();
        private static type_slk_restore sym_slk_restore = LoadFunction <type_slk_restore>("slk_restore");
        internal static int slk_restore() => sym_slk_restore();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_slk_set(int labelNumber, string text, int position);
        private static type_slk_set sym_slk_set = LoadFunction <type_slk_set>("slk_set");
        internal static int slk_set(int labelNumber, string text, int position) => sym_slk_set(labelNumber, text, position);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_start_color();
        private static type_start_color sym_start_color = LoadFunction <type_start_color>("start_color");
        internal static int start_color() => sym_start_color();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr type_subpad(IntPtr parent, int row, int column, int y, int x);
        private static type_subpad sym_subpad = LoadFunction <type_subpad>("subpad");
        internal static IntPtr subpad(IntPtr parent, int row, int column, int y, int x) => sym_subpad(parent, row, column, y, x);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr type_subwin(IntPtr window, int rows, int colums, int y, int x);
        private static type_subwin sym_subwin = LoadFunction <type_subwin>("subwin");
        internal static IntPtr subwin(IntPtr window, int rows, int colums, int y, int x) => sym_subwin(window, rows, colums, y, x);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_touchline(IntPtr window, int row, int column);
        private static type_touchline sym_touchline = LoadFunction <type_touchline>("touchline");
        internal static int touchline(IntPtr window, int row, int column) => sym_touchline(window, row, column);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_touchwin(IntPtr window);
        private static type_touchwin sym_touchwin = LoadFunction <type_touchwin>("touchwin");
        internal static int touchwin(IntPtr window) => sym_touchwin(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_ungetch(int character);
        private static type_ungetch sym_ungetch = LoadFunction <type_ungetch>("ungetch");
        internal static int ungetch(int character) => sym_ungetch(character);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_use_default_colors();
        private static type_use_default_colors sym_use_default_colors = LoadFunction <type_use_default_colors>("use_default_colors");
        internal static int use_default_colors() => sym_use_default_colors();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_waddch(IntPtr window, int character);
        private static type_waddch sym_waddch = LoadFunction <type_waddch>("waddch");
        internal static int waddch(IntPtr window, int character) => sym_waddch(window, character);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int type_waddstr(IntPtr window, string message);
        private static type_waddstr sym_waddstr = LoadFunction <type_waddstr>("waddstr");
        internal static int waddstr(IntPtr window, string message) => sym_waddstr(window, message);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int type_waddnstr(IntPtr win, String str, int n);
        private static type_waddnstr sym_waddnstr = LoadFunction <type_waddnstr>("waddnstr");
        internal static int waddnstr(IntPtr win, String str, int n) => sym_waddnstr(win, str, n);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_wbkgd(IntPtr window, uint ch);
        private static type_wbkgd sym_wbkgd = LoadFunction <type_wbkgd>("wbkgd");
        internal static int wbkgd(IntPtr window, uint ch) => sym_wbkgd(window, ch);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_wborder(IntPtr window, char leftSide, char rightSide, char topSide, char bottomSide, char topLeftHandCorner, char topRightHandCorner, char bottomLeftHandCorner, char bottomRightHandCorner);
        private static type_wborder sym_wborder = LoadFunction <type_wborder>("wborder");
        internal static int wborder(IntPtr window, char leftSide, char rightSide, char topSide, char bottomSide, char topLeftHandCorner, char topRightHandCorner, char bottomLeftHandCorner, char bottomRightHandCorner) 
            => sym_wborder(window, leftSide, rightSide, topSide, bottomSide, topLeftHandCorner, topRightHandCorner, bottomLeftHandCorner, bottomRightHandCorner);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_wclear(IntPtr window);
        private static type_wclear sym_wclear = LoadFunction <type_wclear>("wclear");
        internal static int wclear(IntPtr window) => sym_wclear(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_wgetch(IntPtr win);
        private static type_wgetch sym_wgetch = LoadFunction <type_wgetch>("wgetch");
        internal static int wgetch(IntPtr win) => sym_wgetch(win);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_wrefresh(IntPtr win);
        private static type_wrefresh sym_wrefresh = LoadFunction <type_wrefresh>("wrefresh");
        internal static int wrefresh(IntPtr win) => sym_wrefresh(win);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int type_wscrl(IntPtr window, int numberOfLines);
        private static type_wscrl sym_wscrl = LoadFunction <type_wscrl>("wscrl");
        internal static int wscrl(IntPtr window, int numberOfLines) => sym_wscrl(window, numberOfLines);

    }
}
