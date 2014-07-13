TAGENIGMA Toolbox
-----------------


**Quick Links**

<a target=_blank href="https://www.assetstore.unity3d.com/#/content/1867">[TAGENIGMA Toolbox]</a> is available in the Unity Asset Store.

<a target=_blank href="http://forum.unity3d.com/threads/101485-Sync-VS2010-From-Mac">[Unity Showcase Thread]</a>

Audience
--------

Package contents are targeted towards programmers wanting to extend the Unity IDE.


Compatibility
-------------

This project is targeted for Unity 4.3 or better.


What is in the toolbox?
----------------------------

The Toolbox Editor panel can be collapsed to dock nicely in your view.

<img src="http://d3j5vwomefv46c.cloudfront.net/photos/large/817180615.png?1382592114"/>

How many times have you seen a line-ending warning. Quickly pick a side and keep the

files synced in that format. The post processor can enforce your line ending format

if you decide to turn on automatic processing.

<img src="http://d3j5vwomefv46c.cloudfront.net/photos/large/817180704.png?1382592170"/>

Quickly choose to export with a specific Visual Studio version. And it works on the Mac!

<img src="http://d3j5vwomefv46c.cloudfront.net/photos/large/817180801.png?1382592215"/>

Control when Visual Studio opens.

<img src="http://d3j5vwomefv46c.cloudfront.net/photos/large/817180926.png?1382592276"/>

Handle more formats to include in your project than normal. If you are an Android developer, it's

nice to have your C#, JavaScript, and Java accessible from within your Visual Studio project.

If you are a C++ or LUA developer, those are included with many other common formats.

<img src="http://d3j5vwomefv46c.cloudfront.net/photos/large/817181019.png?1382592307"/>

The Toolbox Panel can also be expanded.

<img src="http://d3j5vwomefv46c.cloudfront.net/photos/large/817192668.png?1382598400"/>

With 'Use Override' enabled, you can specify an alternate location to change the path

to the Unity DLLs. This is useful if you are running a Virtual Machine where the guest

needs an alternate path than the host. I.e. Running Mac with a Windows guest.

<img src="http://d3j5vwomefv46c.cloudfront.net/photos/large/817193089.png?1382598602"/>

Extensions! Extensions can be accessed via the menu items.


**"Window/TAGENIGMA/Open TAGENIGMA Toolbox"** - Opens a configuration panel for the toolbox. Here you can set an alternate path

to the unity editor and engine DLL references.

On Windows, this location should be the folder containing the Unity Editor application, so that the Unity libraries can be

referenced. You can use the default install folder, or browse to the location, or search the registry for the location.

On MacOS, you could potentially be running Visual Studio in a virtual machine on the Mac in which case you still want to

export Visual Studio projects. You can browse or manually enter the path to the Unity Editor as referenced from the local

virtual machine path. In most cases the default location should be adequate.

<img src="http://d3j5vwomefv46c.cloudfront.net/photos/large/822791526.png?1384896123"/>

**"Assets/TAGENIGMA Toolbox/Asset Store"** - Opens the Asset Store page in the browser.

**"Assets/TAGENIGMA Toolbox/Open Toolbox"** - Another quick link to open the configuration panel.

**"Assets/TAGENIGMA Toolbox/Convert to Unix Line Endings"** - Converts source line endings to Unix.

**"Assets/TAGENIGMA Toolbox/Convert to Dos Line Endings"** - Converts source line endings to Dos.

**"Assets/TAGENIGMA Toolbox/Sync Visual Studio 2008"** - Direct exporter to Visual Studio 2008.


**"Assets/TAGENIGMA Toolbox/Sync Visual Studio 2010"** - Whether you are on PC or MAC, you can now sync a VS 2010 compatible project and solution.

The export process checks the registry to find UnityEditor.dll and UnityEngine.dll or defaults to using the default path.

The project is intended to reference C# script, text assets, materials, shaders, and shader include files.


**"Assets/TAGENIGMA Toolbox/Sync Visual Studio 2012"** - Direct exporter to Visual Studio 2012.

**"Assets/TAGENIGMA Toolbox/Sync Visual Studio 2012 (csproj)"** - Direct exporter to Visual Studio 2012 and exports without a solution file.

**"Assets/TAGENIGMA Toolbox/Sync Visual Studio 2012 ..."** - Direct exporter to Visual Studio 2012 and opens a folder browser to choose where to place the files.

**"Assets/TAGENIGMA Toolbox/Sync Visual Studio 2012 (browse csproj)"** - Direct exporter to Visual Studio 2012 and opens a folder browser to choose where to place the project without a solution.


**"Assets/TAGENIGMA Toolbox/Clear Editor Prefs"** - Clears the Unity Editor Prefs.


**"Assets/TAGENIGMA Toolbox/Open Visual Studio 2008"** - Opens the solution in Visual Studio 2008.

**"Assets/TAGENIGMA Toolbox/Open Visual Studio 2010"** - Opens the solution in Visual Studio 2010.

**"Assets/TAGENIGMA Toolbox/Open Visual Studio 2012"** - Opens the solution in Visual Studio 2012.


**"Assets/TAGENIGMA Toolbox/Remove Bak and Bak Meta Files"** - Using external source control tools can create backup files. Unity automatically

generates meta files for your backup files. And then you can run into compile issues. This script will remove the autogenerated

backup files and redundant meta files.


**"Assets/TAGENIGMA Toolbox/Convert to Dos Line Endings"** - Mix-matched line endings can cause compile warnings. This will standardize the line

endings in your C# scripts to DOS style line endings.


**"Assets/TAGENIGMA Toolbox/Convert to Unix Endings"** - Mix-matched line endings can cause compile warnings. This will standardize the line

endings in your C# scripts to Unix style line endings.


Register Symbol - Pre-processor defines can now be automatically exported to the project.  Simply add a custom attribute

to your MonoBehaviour script and it will be detected and exported. The example format is as follows:

```
[RegisterSymbol(Name = "AS_2GR")]
public class YourClassName : MonoBehaviour
```

**"Assets/TAGENIGMA Toolbox/Set Preprocessor Defines"** - This will automatically detect any registered symbols and set the preprocessor defines in the Unity editor. The defined symbols are displayed in the configuration panel.

http://docs.unity3d.com/Documentation/Manual/PlatformDependentCompilation.html


Change Log
----------

1.22 - Changed description to say documentation is available online versus moved online.

1.23 - Made compatible with Unity 4.3

1.24 - Added support for Visual Studio 2013

1.25 - Added support for Mac .app contents paths to UnityEditor.dll and UnityEngine.dll

1.26 - Added support for .c, .cc, and .hpp extensions

1.27 - Added support for toggling define symbols

Q & A
-----

You can send comments/questions to tim@tagenigma.com and please rate this package.
