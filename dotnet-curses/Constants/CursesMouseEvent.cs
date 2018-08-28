namespace Mindmagma.Curses
{
    public static class CursesMouseEvent
    {
        public static uint BUTTON1_PRESSED = 0x00000002U;
        public static uint BUTTON1_RELEASED = 0x00000001U;
        public static uint BUTTON1_CLICKED = 0x00000004U;
        public static uint BUTTON1_DOUBLE_CLICKED = 0x00000008U;
        public static uint BUTTON1_TRIPLE_CLICKED = 0x00000010U;
        public static uint BUTTON2_PRESSED = 0x00000080U;
        public static uint BUTTON2_RELEASED = 0x00000040U;
        public static uint BUTTON2_CLICKED = 0x00000100U;
        public static uint BUTTON2_DOUBLE_CLICKED = 0x00000200U;
        public static uint BUTTON2_TRIPLE_CLICKED = 0x00000400U;
        public static uint BUTTON3_PRESSED = 0x00002000U;
        public static uint BUTTON3_RELEASED = 0x00001000U;
        public static uint BUTTON3_CLICKED = 0x00004000U;
        public static uint BUTTON3_DOUBLE_CLICKED = 0x00008000U;
        public static uint BUTTON3_TRIPLE_CLICKED = 0x00010000U;
        public static uint BUTTON4_PRESSED = 0x00080000U;
        public static uint BUTTON4_RELEASED = 0x00040000U;
        public static uint BUTTON4_CLICKED = 0x00100000U;
        public static uint BUTTON4_DOUBLE_CLICKED = 0x00200000U;
        public static uint BUTTON4_TRIPLE_CLICKED = 0x00400000U;
        public static uint BUTTON_SHIFT = 0x02000000U;
        public static uint BUTTON_CTRL = 0x01000000U;
        public static uint BUTTON_ALT = 0x04000000U;
        public static uint ALL_MOUSE_EVENTS = 0x07ffffffU;
        public static uint REPORT_MOUSE_POSITION = 0x08000000U;
    }
}
