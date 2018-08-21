using Mindmagma.Curses;
using System.Collections.Generic;

namespace sample_fireworks
{
    // This is only here to provide an example of supplementing or
    // overriding the default library names. The provided name is
    // the same as the default.

    public class MoreCursesLibraryNames : CursesLibraryNames
    {
        public override bool ReplaceWindowsDefaults => true;
        public override List<string> NamesWindows => new List<string> { "libncursesw6.dll" };
    }
}
