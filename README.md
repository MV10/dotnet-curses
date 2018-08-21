# dotnet-curses
This is an easy-to-use, fully cross-platform .NET Standard 2.0 wrapper for the Unix NCurses terminal library. The project is able to load the OS-specific native implementation of NCurses at runtime which means you can deploy the same binary to Windows, Linux, or OSX. Most other .NET wrappers use statically-defined references to the native implementation, requiring different builds for different OSes.

## Usage
