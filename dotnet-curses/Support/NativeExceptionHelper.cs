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

        internal static void ThrowOnError(int result, string nativeFunction)
        {
            if (result == -1) throw new DotnetCursesException($"{nativeFunction}() returned ERR");
        }

        internal static void ThrowOnNullPointer(IntPtr result, string nativeFunction)
        {
            if (result == IntPtr.Zero) throw new DotnetCursesException($"{nativeFunction}() returned NULL");
        }

    }
}
