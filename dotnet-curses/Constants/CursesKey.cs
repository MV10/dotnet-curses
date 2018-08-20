namespace Mindmagma.Curses
{
    public static class CursesKey
    {
        public const int ESC = 0x01B;
        public const int CTRLC = 0x003;
        public const int CTRLZ = 0x01A;
        public const int BREAK = 0x101;
        public const int DOWN = 0x102;
        public const int UP = 0x103;
        public const int LEFT = 0x104;
        public const int RIGHT = 0x105;
        public const int HOME = 0x106;
        public const int BACKSPACE = 0x107;
        public const int F0 = 0x108;
        public const int DL = 0x148;
        public const int IL = 0x149;
        public const int DC = 0x14a;
        public const int DELETEKEY = 0x14a;
        public const int IC = 0x14b;
        public const int INSERTKEY = 0x14b;
        public const int EIC = 0x14c;
        public const int CLEAR = 0x14d;
        public const int EOS = 0x14e;
        public const int EOL = 0x14f;
        public const int SF = 0x150;
        public const int SR = 0x151;
        public const int NPAGE = 0x152;
        public const int PPAGE = 0x153;
        public const int STAB = 0x154;
        public const int CTAB = 0x155;
        public const int CATAB = 0x156;
        public const int ENTER = 0x157;
        public const int SRESET = 0x158;
        public const int RESET = 0x159;
        public const int PRINT = 0x15a;
        public const int LL = 0x15b;
        public const int A1 = 0x15c;
        public const int A3 = 0x15d;
        public const int B2 = 0x15e;
        public const int C1 = 0x15f;
        public const int C3 = 0x160;
        public const int BTAB = 0x161;
        public const int BEG = 0x162;
        public const int CANCEL = 0x163;
        public const int CLOSE = 0x164;
        public const int COMMAND = 0x165;
        public const int COPY = 0x166;
        public const int CREATE = 0x167;
        public const int END = 0x168;
        public const int EXIT = 0x169;
        public const int FIND = 0x16a;
        public const int HELP = 0x16b;
        public const int MARK = 0x16c;
        public const int MESSAGE = 0x16d;
        public const int MOUSE = 0x199;
        public const int MOVE = 0x16e;
        public const int NEXT = 0x16f;
        public const int OPEN = 0x170;
        public const int OPTIONS = 0x171;
        public const int PREVIOUS = 0x172;
        public const int REDO = 0x173;
        public const int REFERENCE = 0x174;
        public const int REFRESH = 0x175;
        public const int REPLACE = 0x176;
        public const int RESIZE = 0x19a;
        public const int RESTART = 0x177;
        public const int RESUME = 0x178;
        public const int SAVE = 0x179;
        public const int SBEG = 0x17a;
        public const int SCANCEL = 0x17b;
        public const int SCOMMAND = 0x17c;
        public const int SCOPY = 0x17d;
        public const int SCREATE = 0x17e;
        public const int SDC = 0x17f;
        public const int SDL = 0x180;
        public const int SELECT = 0x181;
        public const int SEND = 0x182;
        public const int SEOL = 0x183;
        public const int SEXIT = 0x184;
        public const int SFIND = 0x185;
        public const int SHELP = 0x186;
        public const int SHOME = 0x187;
        public const int SIC = 0x188;
        public const int SLEFT = 0x189;
        public const int SMESSAGE = 0x18a;
        public const int SMOVE = 0x18b;
        public const int SNEXT = 0x18c;
        public const int SOPTIONS = 0x18d;
        public const int SPREVIOUS = 0x18e;
        public const int SPRINT = 0x18f;
        public const int SREDO = 0x190;
        public const int SREPLACE = 0x191;
        public const int SRIGHT = 0x192;
        public const int SRSUME = 0x193;
        public const int SSAVE = 0x194;
        public const int SSUSPEND = 0x195;
        public const int SUNDO = 0x196;
        public const int SUSPEND = 0x197;
        public const int UNDO = 0x198;

        public static int KEY_F(int n)
        {
            return F0 + n;
        }

        public const int MIN = 0x101;
        public const int MAX = 0x1ff;
    }
}
