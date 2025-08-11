# dotnet-curses [![NuGet](https://img.shields.io/nuget/v/dotnet-curses.svg)](https://nuget.org/packages/dotnet-curses)
This is an easy-to-use, fully cross-platform .NET wrapper for the Unix NCurses terminal library. The project is able to load the OS-specific native implementation of NCurses at runtime which means you can deploy the same binary to Windows, Linux, or OSX. Most other .NET wrappers use statically-defined references to the native implementation, requiring different builds for different OSes.

> "Wrapper" means this package DOES NOT include the curses library itself. See _The Native Curses Library_ section below for details.

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
## The Native Curses Library
OSX always installs ncurses. Linux distros _almost_ always do (if yours does not, unfortunately I probably can't help you).

For Windows, download it from Thomas Dickey’s site (the current ncurses maintainer) from the 64-bit link under the "MinGW Ports" heading on [this page](https://invisible-island.net/ncurses/#download_mingw), and extract the DLLs anywhere in your `%PATH%`.

## Non-Standard Curses Library Filenames
Various platforms, releases and distributions have used different filenames for the curses library. On OSX it usually includes the major version number, and on Linux it's common to include the major and minor version numbers. Windows has never included a cursors implementation, although Thomas Dickey's builds are the de facto standard.

Currently the names built into _dotnet-curses_ are as follows and should work for most target environments:

- Windows: `libncursesw6.dll`
- Linux: `libncurses.so.5.9`, `libncurses.so`
- OSX: `libncurses.dylib`

The _dotnet-curses_ library contains that list as defaults. However, if you want to add to these or even replace the lists entirely, simply create a class in your project that derives from `CursesLibraryNames` and use any of the following:

```csharp
public override bool ReplaceWindowsDefaults => true;
public override bool ReplaceLinuxDefaults => true;
public override bool ReplaceOSXDefaults => true;
public override List<string> NamesWindows => new List<string> { "abc.dll", "xyz.dll" };
public override List<string> NamesLinux => new List<string> { "abc.1.5.so", "abc.so" };
public override List<string> NamesOSX => new List<string> { "xyz5.dylib", "xyz.dylib" };
```

The "Replace" properties in the first three are false by default. If you leave it at the default but override the corresponding name list, those names will be _added_ to the _dotnet-curses_ default list. However, if you override a list and set the "Replace" property to true, the built-in defaults will be ignored, and _only_ the names you provide will be used.

## Native Library Loader
This project includes a separate slightly-modified copy of Eric Mellinoe's [_NativeLibraryLoader_](https://github.com/mellinoe/nativelibraryloader/) project. The project was a prototype for implementing improved native library support directly in a future version of .NET. Eventually, a variation made it into .NET Core 3.0, however I am not currently equipped to perform cross-platform testing (OSX is no longer so easy to run in a VM and I will never own an Apple product, and I haven't had a need to maintain a Linux environment for a couple years). Eric's code was incorporated into the _dotnet-curses_ codebase because the dotnet nuget packaging process can't combine two separate projects into a single package. Eventually I will release a new version that uses Microsoft's `System.Runtime.InteropServices.NativeLibrary` implementation (and I'd happy accept a PR if someone feels like doing that work and validating the results).

Note version 1 of _dotnet-curses_ targeted .NET Standard, which meant it could be used with modern .NET or .NET Framework. However, the library also used Microsoft extensions with .NET Core 2.1 dependencies, which is out of support and has known vulnerabilities. Unfortunately, as of .NET 8 Microsoft introduced a [breaking change](https://learn.microsoft.com/en-us/dotnet/core/compatibility/core-libraries/8.0/runtimeidentifier) in Runtime Identifier determination, which is used by the Native Library Loader code. The new property is not available for .NET Framework or .NET Standard.

## The .NET Runtime
The README for earlier releases of this library had links and specific instructions about setting up machine-wide .NET runtime installations under Windows, Linux, or OSX. Those links have changed, but Microsoft has actually made of all of this easier and you shouldn't have any trouble finding the current documentation yourself. (They kept changing the links, so I'm not going to try to keep track of it.)


