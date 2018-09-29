# dotnet-curses [![NuGet](https://img.shields.io/nuget/v/dotnet-curses.svg)](https://nuget.org/packages/dotnet-curses)
This is an easy-to-use, fully cross-platform .NET Standard 2.0 wrapper for the Unix NCurses terminal library. The project is able to load the OS-specific native implementation of NCurses at runtime which means you can deploy the same binary to Windows, Linux, or OSX. Most other .NET wrappers use statically-defined references to the native implementation, requiring different builds for different OSes.

## Usage
This library assumes your application will be compiled as a portable executable. That results in a DLL that can run on Windows, Linux, or OSX, and this library works the same way. At runtime it detects the OS and loads the native OS version of the curses library. Later sections explain how to get the correct .NET runtime on Linux or OSX, where to find an ncurses implementation for Windows, and what to do if ncurses on your OS uses a non-standard library name (generally only a problem on Linux).

In your own program, you're mainly calling static methods exposed by the `NCurses` class in the `Mindmagma.Curses` namespace. I recommend browsing the `NCurses` class in the Visual Studio object browser window to see exactly what is available (at the time of writing, 91 API calls are available).

Please restrict opening issues in this repo to topics specific to this project, not about curses in general. For assistance with the curses API itself, questions tagged `ncurses` on [StackOverflow](https://stackoverflow.com/questions/tagged/ncurses) seem to be answered pretty quickly. 

How to use the curses API itself is beyond the scope of this README. I recommend reading either [this](http://www.ibiblio.org/pub/Linux/docs/HOWTO/other-formats/html_single/NCURSES-Programming-HOWTO.html) high-level introduction or the much longer article by Eric S. Raymond [here](https://invisible-island.net/ncurses/ncurses-intro.html). However, a typical start-up sequence using this package might look like this:

```csharp
var Screen = NCurses.InitScreen();
NCurses.NoDelay(Screen, true);
NCurses.NoEcho();
```

## The .NET Runtime
The target OS doesn't need to install the developer-oriented .NET SDK. Instead, a much smaller, machine-wide .NET runtime can be installed. For Windows, there is a simple installer [here](https://www.microsoft.com/net/download?initial-os=windows). The same is true of OSX, download an installer [here](https://www.microsoft.com/net/download?initial-os=macos).

As usual, Linux makes it complicated. Your best bet is to read the documentation about preprequisites [here](https://docs.microsoft.com/en-us/dotnet/core/linux-prerequisites?tabs=netcore2x) and follow the instructions that match your distro. Because distros can vary considerably even between minor releases, you should try to match your _exact_ distro and version for the best chances of success.

## The Native Library
OSX always installs ncurses. Linux distros _almost_ always do (if yours does not, unfortunately I probably can't help you).

For Windows, download it from Thomas Dickey’s site (the current ncurses maintainer) from the 64-bit link under the "MinGW Ports" heading on [this page](https://invisible-island.net/ncurses/#download_mingw), and extract the DLLs anywhere in your `%PATH%`.

## Non-Standard Library Filenames
Various platforms, releases and distributions have used different filenames for the curses library. On OSX it usually includes the major version number, and on Linux it's common to include the major and minor version numbers. Windows has never included a cursors implementation, although Thomas Dickey's builds are the de facto standard.

The _dotnet-curses_ library contains a list of defaults for each platform that are very likely to work. However, if you want to add to these or even replace one or more lists entirely, simply add a class to your project that derives from `CursesLibraryNames` and use one or more of the following:

```csharp
public override bool ReplaceWindowsDefaults => true;
public override bool ReplaceLinuxDefaults => true;
public override bool ReplaceOSXDefaults => true;
public override List<string> NamesWindows => new List<string> { "abc.dll", "xyz.dll" };
public override List<string> NamesLinux => new List<string> { "abc.1.5.so", "abc.so" };
public override List<string> NamesOSX => new List<string> { "xyz5.dylib", "xyz.dylib" };
```

The "Replace" properties are false by default. If you leave it at the default but override the corresponding name list, those names will be **added** to the _dotnet-curses_ default list. However, if you override and set a "Replace" property to true, the built-in defaults will be ignored, and only the names you provide will be used.

Currently the names built into _dotnet-curses_ are as follows and should work for most target environments:

- Windows: `libncursesw6.dll`
- Linux: `libncurses.so.5.9`, `libncurses.so`
- OSX: `libncurses.dylib`

## Native Library Loader
This project includes a separate slightly-modified copy of Eric Mellinoe's [_NativeLibraryLoader_](https://github.com/mellinoe/nativelibraryloader/) project. The project is serving as a prototype for implementing improved native library support directly in a future version of .NET Core (probably 2.2). It was actually incorporated into the _dotnet-curses_ codebase because the dotnet nuget packaging process currently isn't smart enough to combine two projects into a single package.
