namespace Mindmagma.Curses
{
    public enum CursesAttribute : uint
    {
        NORMAL = 0,
        BOLD = 2097152,
        UNDERLINE = 131072,
        ATTRIBUTES = 4294967040,
        CHAR_TEXT = 255,
        REVERSE = 262144,
        BLINK = 524288,
        DIM = 1048576,
        ALT_CHARSET = 4194304,
        INVIS = 8388608,
        PROTECT = 16777216,
        HORIZONTAL = 33554432,
        LEFT = 67108864,
        LOW = 134217728,
        RIGHT = 268435456,
        TOP = 536870912,
        VERTICAL = 1073741824,
        ITALIC = 2147483648
    }
}
