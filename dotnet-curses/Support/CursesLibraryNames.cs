using System.Collections.Generic;

namespace Mindmagma.Curses
{
    /// <summary>
    /// A library client can implement this interface to expand or
    /// replace the default NCurses library names on each target OS.
    /// </summary>
    public class CursesLibraryNames
    {
        /// <summary>
        /// Defaults to false, override this to set it to true which ignores
        /// the default NCurses library names built into dotnet-curses for
        /// OSPlatform.Windows.
        /// </summary>
        public virtual bool ReplaceWindowsDefaults => false;

        /// <summary>
        /// The list of default NCurses library names built into dotnet-curses
        /// for OSPlatform.Windows. Override this to add to the defaults, or
        /// also override the Replace property to replace the defaults.
        /// </summary>
        public virtual List<string> NamesWindows => new List<string> { "libncursesw6" };

        /// <summary>
        /// Defaults to false, override this to set it to true which ignores
        /// the default NCurses library names built into dotnet-curses for
        /// OSPlatform.Linux.
        /// </summary>
        public virtual bool ReplaceLinuxDefaults => false;

        /// <summary>
        /// The list of default NCurses library names built into dotnet-curses
        /// for OSPlatform.Linux. Override this to add to the defaults, or
        /// also override the Replace property to replace the defaults.
        /// </summary>
        public virtual List<string> NamesLinux => new List<string> { "libncurses.so.5.9", "libncurses.so" };

        /// <summary>
        /// Defaults to false, override this to set it to true which ignores
        /// the default NCurses library names built into dotnet-curses for
        /// OSPlatform.OSX.
        /// </summary>
        public virtual bool ReplaceOSXDefaults => false;

        /// <summary>
        /// The list of default NCurses library names built into dotnet-curses
        /// for OSPlatform.OSX. Override this to add to the defaults, or
        /// also override the Replace property to replace the defaults.
        /// </summary>
        public virtual List<string> NamesOSX => new List<string> { "libncurses.dylib" };
    }
}
