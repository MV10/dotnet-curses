namespace Mindmagma.Curses
{
    public enum CursesKey : int
    {
        KEY_CODE_YES = 256, // flag indicating wchar_t contains wide-char key code
        KEY_MIN,            // minimum key value
        KEY_BREAK = 257,
        KEY_DOWN,
        KEY_UP,
        KEY_LEFT,
        KEY_RIGHT,
        KEY_HOME,
        KEY_BACKSPACE,
        KEY_F0,
        KEY_F1,
        KEY_F2,
        KEY_F3,
        KEY_F4,
        KEY_F5,
        KEY_F6,
        KEY_F7,
        KEY_F8,
        KEY_F9,
        KEY_F10,
        KEY_F11,
        KEY_F12,
        KEY_DL = 328,       // delete line
        KEY_IL,             // insert line
        KEY_DC,             // delete char
        KEY_IC,             // insert char or start insert mode
        KEY_EIC,            // exit insert mode
        KEY_CLEAR,          // clear screen
        KEY_EOS,            // clear to end of screen
        KEY_MOUSE = 409     // mouse event
    }
}
