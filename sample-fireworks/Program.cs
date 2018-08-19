using System;
using Mindmagma.Curses;

namespace sample_fireworks
{
    // Converted from sushihangover's implemenation of the PDCurses firework.c demo

    class Program
    {
        private const int FRAMERATE = 150;

        private static IntPtr Screen;

        private static readonly Random rng = new Random();

        private static readonly short[] color_table = {
            (short)CursesColor.RED,
            (short)CursesColor.BLUE,
            (short)CursesColor.GREEN,
            (short)CursesColor.CYAN,
            (short)CursesColor.RED,
            (short)CursesColor.MAGENTA,
            (short)CursesColor.YELLOW,
            (short)CursesColor.WHITE
        };

        static void Main(string[] args)
        {
            Screen = NCurses.InitScreen();
            try
            {
                Fireworks();
            }
            finally
            {
                NCurses.EndWin();
            }
        }

        private static void Fireworks()
        {
            NCurses.NoDelay(Screen, true);
            NCurses.NoEcho();

            if(NCurses.HasColors())
            {
                NCurses.StartColor();
                for (short i = 1; i < 8; i++)
                    NCurses.InitPair(i, color_table[i], (short)CursesColor.BLACK);
            }

            int flag = 0;
            while(NCurses.GetChar() == -1)
            {
                int start, end, row, diff, direction;
                do
                {
                    start = rng.Next(NCurses.Columns() - 3);
                    end = rng.Next(NCurses.Columns() - 3);
                    start = (start < 2) ? 2 : start;
                    end = (end < 2) ? 2 : end;
                    direction = (start > end) ? -1 : 1;
                    diff = Math.Abs(start - end);
                } while (diff < 2 || diff >= NCurses.Lines() - 2);

                NCurses.AttributeSet(CursesAttribute.NORMAL);
                for (row = 1; row < diff; ++row)
                {
                    NCurses.MoveAddString(NCurses.Lines() - row, row * direction + start, (direction < 0) ? "\\" : "/");
                    if (flag++ > 0)
                    {
                        MyRefresh();
                        NCurses.Erase();
                        flag = 0;
                    }
                }

                if (flag++ > 0)
                {
                    MyRefresh();
                    flag = 0;
                }

                Explode(NCurses.Lines() - row, diff * direction + start);
                NCurses.Erase();
                MyRefresh();
            }
        }

        private static void Explode(int row, int col)
        {
            NCurses.Erase();
            AddStr(row, col, "-");
            MyRefresh();

            col--;

            GetColor();
            AddStr(row - 1, col, " - ");
            AddStr(row, col, "-+-");
            AddStr(row + 1, col, " - ");
            MyRefresh();

            col--;

            GetColor();
            AddStr(row - 2, col, " --- ");
            AddStr(row - 1, col, "-+++-");
            AddStr(row, col, "-+#+-");
            AddStr(row + 1, col, "-+++-");
            AddStr(row + 2, col, " --- ");
            MyRefresh();

            GetColor();
            AddStr(row - 2, col, " +++ ");
            AddStr(row - 1, col, "++#++");
            AddStr(row, col, "+# #+");
            AddStr(row + 1, col, "++#++");
            AddStr(row + 2, col, " +++ ");
            MyRefresh();

            GetColor();
            AddStr(row - 2, col, "  #  ");
            AddStr(row - 1, col, "## ##");
            AddStr(row, col, "#   #");
            AddStr(row + 1, col, "## ##");
            AddStr(row + 2, col, "  #  ");
            MyRefresh();

            GetColor();
            AddStr(row - 2, col, " # # ");
            AddStr(row - 1, col, "#   #");
            AddStr(row, col, "     ");
            AddStr(row + 1, col, "#   #");
            AddStr(row + 2, col, " # # ");
            MyRefresh();
        }

        private static void AddStr(int y, int x, string str)
        {
            if (x >= 0 && x < NCurses.Columns() && y >= 0 && y < NCurses.Lines())
                NCurses.MoveAddString(y, x, str);
        }

        private static void MyRefresh()
        {
            NCurses.Nap(FRAMERATE);
            NCurses.Move(NCurses.Lines() - 1, NCurses.Columns() - 1);
            NCurses.Refresh();
        }

        private static void GetColor()
        {
            uint bold = (rng.Next(2) > 0) ? (uint)CursesAttribute.BOLD : (uint)CursesAttribute.NORMAL;
            NCurses.AttributeSet(NCurses.ColorPair((short)rng.Next(8)) | bold);
        }

    }
}

