namespace Mindmagma.Curses
{
    public static class CursesAttribute
    {
        public const uint NORMAL = 0x00000000U;
        public const uint ALTCHARSET = 0x00400000U;
        public const uint BLINK = 0x00080000U;
        public const uint BOLD = 0x00200000U;
        public const uint DIM = 0x00100000U;
        public const uint INVIS = 0x00800000U;
        public const uint PROTECT = 0x01000000U;
        public const uint REVERSE = 0x00040000U;
        public const uint STANDOUT = 0x00010000U;
        public const uint UNDERLINE = 0x00020000U;

        // masks
        public const uint ATTRIBUTES = 0xffffff00U;
        public const uint CHARTEXT = 0x000000ffU;
        public const uint COLOR = 0x0000ff00U;
    }
}
