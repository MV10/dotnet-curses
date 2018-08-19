using System;

namespace Mindmagma.Curses
{
    public class DotnetCursesException : Exception
    {
        public DotnetCursesException()
        { }

        public DotnetCursesException(string message) : base(message)
        { }

        public DotnetCursesException(string message, Exception inner) : base(message, inner)
        { }
    }

}
