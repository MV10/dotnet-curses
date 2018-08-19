using System;

namespace Mindmagma.Curses
{
    public class NativeExceptionHelper : DotnetCursesException
    {
        internal NativeExceptionHelper()
        { }

        internal NativeExceptionHelper(string message) : base(message)
        { }

        internal NativeExceptionHelper(string message, Exception inner) : base (message, inner)
        { }

        internal static void ThrowOnFailure(int result, string method)
        {
            if (result == -1) throw new DotnetCursesException($"{method}() returned ERR");
        }

        internal static void ThrowOnFailure(IntPtr result, string method)
        {
            if (result == IntPtr.Zero) throw new DotnetCursesException($"{method}() returned NULL");
        }

    }
}
