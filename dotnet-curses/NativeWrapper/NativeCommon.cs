using System;
using System.Runtime.InteropServices;
using System.Text;

#pragma warning disable IDE1006 // naming rule violation, methods must begin with uppercase

// common functions

namespace Mindmagma.Curses.Interop
{
    internal static partial class Native
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_addch(int ch);
        private static dt_addch call_addch = NativeToDelegate<dt_addch>("addch");
        internal static int addch(int ch) => call_addch(ch);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_assume_default_colors(int f, int b);
        private static dt_assume_default_colors call_assume_default_colors = NativeToDelegate<dt_assume_default_colors>("assume_default_colors");
        internal static int assume_default_colors(int f, int b) => call_assume_default_colors(f, b);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_addstr(string str);
        private static dt_addstr call_addstr = NativeToDelegate<dt_addstr>("addstr");
        internal static int addstr(string str) => call_addstr(str);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_attroff(uint attributes);
        private static dt_attroff call_attroff = NativeToDelegate<dt_attroff>("attroff");
        internal static int attroff(uint attributes) => call_attroff(attributes);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_attron(uint attributes);
        private static dt_attron call_attron = NativeToDelegate<dt_attron>("attron");
        internal static int attron(uint attributes) => call_attron(attributes);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_attrset(uint attributes);
        private static dt_attrset call_attrset = NativeToDelegate<dt_attrset>("attrset");
        internal static int attrset(uint attributes) => call_attrset(attributes);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_beep();
        private static dt_beep call_beep = NativeToDelegate<dt_beep>("beep");
        internal static int beep() => call_beep();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_bkgd(uint ch);
        private static dt_bkgd call_bkgd = NativeToDelegate<dt_bkgd>("bkgd");
        internal static int bkgd(uint ch) => call_bkgd(ch);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_clear();
        private static dt_clear call_clear = NativeToDelegate<dt_clear>("clear");
        internal static int clear() => call_clear();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_color_content(short color, out short red, out short green, out short blue);
        private static dt_color_content call_color_content = NativeToDelegate<dt_color_content>("color_content");
        internal static int color_content(short color, out short red, out short green, out short blue) => call_color_content(color, out red, out green, out blue);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate uint dt_COLOR_PAIR(int n);
        private static dt_COLOR_PAIR call_COLOR_PAIR = NativeToDelegate<dt_COLOR_PAIR>("COLOR_PAIR");
        internal static uint COLOR_PAIR(int n) => call_COLOR_PAIR(n);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_clrtobot();
        private static dt_clrtobot call_clrtobot = NativeToDelegate<dt_clrtobot>("clrtobot");
        internal static int clrtobot() => call_clrtobot();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_clrtoeol();
        private static dt_clrtoeol call_clrtoeol = NativeToDelegate<dt_clrtoeol>("clrtoeol");
        internal static int clrtoeol() => call_clrtoeol();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_curs_set(int cursorState);
        private static dt_curs_set call_curs_set = NativeToDelegate<dt_curs_set>("curs_set");
        internal static int curs_set(int cursorState) => call_curs_set(cursorState);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_delch();
        private static dt_delch call_delch = NativeToDelegate<dt_delch>("delch");
        internal static int delch() => call_delch();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_deleteln();
        private static dt_deleteln call_deleteln = NativeToDelegate<dt_deleteln>("deleteln");
        internal static int deleteln() => call_deleteln();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_doupdate();
        private static dt_doupdate call_doupdate = NativeToDelegate<dt_doupdate>("doupdate");
        internal static int doupdate() => call_doupdate();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_echo();
        private static dt_echo call_echo = NativeToDelegate<dt_echo>("echo");
        internal static int echo() => call_echo();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_erase();
        private static dt_erase call_erase = NativeToDelegate<dt_erase>("erase");
        internal static int erase() => call_erase();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_flash();
        private static dt_flash call_flash = NativeToDelegate<dt_flash>("flash");
        internal static int flash() => call_flash();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_flushinp();
        private static dt_flushinp call_flushinp = NativeToDelegate<dt_flushinp>("flushinp");
        internal static int flushinp() => call_flushinp();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_getch();
        private static dt_getch call_getch = NativeToDelegate<dt_getch>("getch");
        internal static int getch() => call_getch();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_getmouse(out MouseEvent mouseEvent);
        private static dt_getmouse call_getmouse = NativeToDelegate<dt_getmouse>("getmouse");
        internal static int getmouse(out MouseEvent mouseEvent) => call_getmouse(out mouseEvent);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_getnstr(StringBuilder message, int numberOfCharacters);
        private static dt_getnstr call_getnstr = NativeToDelegate<dt_getnstr>("getnstr");
        internal static int getnstr(StringBuilder message, int numberOfCharacters) => call_getnstr(message, numberOfCharacters);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_getstr(StringBuilder message);
        private static dt_getstr call_getstr = NativeToDelegate<dt_getstr>("getstr");
        internal static int getstr(StringBuilder message) => call_getstr(message);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_init_color(short color, short red, short green, short blue);
        private static dt_init_color call_init_color = NativeToDelegate<dt_init_color>("init_color");
        internal static int init_color(short color, short red, short green, short blue) => call_init_color(color, red, green, blue);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_init_pair(short color, short fg, short bg);
        private static dt_init_pair call_init_pair = NativeToDelegate<dt_init_pair>("init_pair");
        internal static int init_pair(short color, short fg, short bg) => call_init_pair(color, fg, bg);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_insch(uint character);
        private static dt_insch call_insch = NativeToDelegate<dt_insch>("insch");
        internal static int insch(uint character) => call_insch(character);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_insertln();
        private static dt_insertln call_insertln = NativeToDelegate<dt_insertln>("insertln");
        internal static int insertln() => call_insertln();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate uint dt_mousemask(uint newMask, out uint oldmask);
        private static dt_mousemask call_mousemask = NativeToDelegate<dt_mousemask>("mousemask");
        internal static uint mousemask(uint newMask, out uint oldmask) => call_mousemask(newMask, out oldmask);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_move(int y, int x);
        private static dt_move call_move = NativeToDelegate<dt_move>("move");
        internal static int move(int y, int x) => call_move(y, x);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_mvaddch(int row, int column, uint character);
        private static dt_mvaddch call_mvaddch = NativeToDelegate<dt_mvaddch>("mvaddch");
        internal static int mvaddch(int row, int column, uint character) => call_mvaddch(row, column, character);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_mvaddchnstr(int row, int column, uint character, int numberOfCharacters);
        private static dt_mvaddchnstr call_mvaddchnstr = NativeToDelegate<dt_mvaddchnstr>("mvaddchnstr");
        internal static int mvaddchnstr(int row, int column, uint character, int numberOfCharacters) => call_mvaddchnstr(row, column, character, numberOfCharacters);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_mvaddchstr(int row, int column, uint character);
        private static dt_mvaddchstr call_mvaddchstr = NativeToDelegate<dt_mvaddchstr>("mvaddchstr");
        internal static int mvaddchstr(int row, int column, uint character) => call_mvaddchstr(row, column, character);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_mvaddnstr(int row, int column, uint character, int numberOfCharacters);
        private static dt_mvaddnstr call_mvaddnstr = NativeToDelegate<dt_mvaddnstr>("mvaddnstr");
        internal static int mvaddnstr(int row, int column, uint character, int numberOfCharacters) => call_mvaddnstr(row, column, character, numberOfCharacters);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_mvaddstr(int row, int column, string message);
        private static dt_mvaddstr call_mvaddstr = NativeToDelegate<dt_mvaddstr>("mvaddstr");
        internal static int mvaddstr(int row, int column, string message) => call_mvaddstr(row, column, message);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate short dt_PAIR_NUMBER(uint n);
        private static dt_PAIR_NUMBER call_PAIR_NUMBER = NativeToDelegate<dt_PAIR_NUMBER>("PAIR_NUMBER");
        internal static short PAIR_NUMBER(uint n) => call_PAIR_NUMBER(n);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_pair_content(short pair, out short fg, out short bg);
        private static dt_pair_content call_pair_content = NativeToDelegate<dt_pair_content>("pair_content");
        internal static int pair_content(short pair, out short fg, out short bg) => call_pair_content(pair, out fg, out bg);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_refresh();
        private static dt_refresh call_refresh = NativeToDelegate<dt_refresh>("refresh");
        internal static int refresh() => call_refresh();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_resize_term(int nlines, int ncols);
        private static dt_resize_term call_resize_term = NativeToDelegate<dt_resize_term>("resize_term");
        internal static int resize_term(int nlines, int ncols) => call_resize_term(nlines, ncols);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_scrollok(IntPtr window, bool canScroll);
        private static dt_scrollok call_scrollok = NativeToDelegate<dt_scrollok>("scrollok");
        internal static int scrollok(IntPtr window, bool canScroll) => call_scrollok(window, canScroll);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_slk_clear();
        private static dt_slk_clear call_slk_clear = NativeToDelegate<dt_slk_clear>("slk_clear");
        internal static int slk_clear() => call_slk_clear();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_slk_init(int numberOfLabels);
        private static dt_slk_init call_slk_init = NativeToDelegate<dt_slk_init>("slk_init");
        internal static int slk_init(int numberOfLabels) => call_slk_init(numberOfLabels);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_slk_refresh();
        private static dt_slk_refresh call_slk_refresh = NativeToDelegate<dt_slk_refresh>("slk_refresh");
        internal static int slk_refresh() => call_slk_refresh();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_slk_restore();
        private static dt_slk_restore call_slk_restore = NativeToDelegate<dt_slk_restore>("slk_restore");
        internal static int slk_restore() => call_slk_restore();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_slk_set(int labelNumber, string text, int position);
        private static dt_slk_set call_slk_set = NativeToDelegate<dt_slk_set>("slk_set");
        internal static int slk_set(int labelNumber, string text, int position) => call_slk_set(labelNumber, text, position);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_start_color();
        private static dt_start_color call_start_color = NativeToDelegate<dt_start_color>("start_color");
        internal static int start_color() => call_start_color();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_ungetch(int character);
        private static dt_ungetch call_ungetch = NativeToDelegate<dt_ungetch>("ungetch");
        internal static int ungetch(int character) => call_ungetch(character);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_use_default_colors();
        private static dt_use_default_colors call_use_default_colors = NativeToDelegate<dt_use_default_colors>("use_default_colors");
        internal static int use_default_colors() => call_use_default_colors();

    }
}
