# MonoGame.WpfCore

MonoGame embedded inside a WPF app as a `dotnet new` template.

![obligatory screenshot](.template.config/screenshot.png)

## Prerequisites

NEW changes ( mabye this should be a branch or fork) 

UPDATED TO 3.81 mg, which is all netcore 6.0.. I had to do this because mg 3.81 so longer supports net standard 2.0 and my game core is in a lib like that.. Updgrateing it to the new net6 mG  game libary, a Net 4.8 exe wont link to it.

This template uses .NET Core 6.0. If you're having trouble getting it to compile make sure you've updated to the latest version. I have confirmed that it works with:

 - Visual Studio 2022 17.2.6  or later.
 - [.NET Core 6.0.100](https://dotnet.microsoft.com/download/dotnet-core/6.0) which should install with Visual Studio anyway.

    
Since its referencing SharpDX, dont expect it to work on linux or mac.


If you have MG 3.8.1 core game code in net6 libraries, you cant use dotnet 4.8 exe linked to them, so legacy modules in complex level editors might make this upgrade an bad idea, since Netstandard 2.0 is not supported by MG 3.8.1, better stick with MG 3.8 in this case.  There might be compatibility modes aroudn this.




## Installing the template

To install the `dotnet new` template, clone this repository locally and [install the template from a local directroy](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates#to-install-a-template-from-a-file-system-directory).

```
dotnet new -i MonoGame.WpfCore\
```

After the template is installed you should see it in the list. To create a new project, first create an empty directory then run the template.

```
mkdir MyLevelEditor
cd MyLevelEditor
dotnet new monogamewpf
```

All done! Open the solution and run the project.

## Simple. 

There's no magic here.

 - The WPF project references the official [`MonoGame.Framework.WindowsDX` NuGet package](https://www.nuget.org/packages/MonoGame.Framework.WindowsDX/). The same package can be used in your game.
 - There's only a handful of files required to do the heavy lifting. 
 - The `MonoGameContentControl` is a standard WPF control in every other way.

## Modern. 

I've been using and refining the `MonoGameContentControl` in my own projects for many years. Everything else in this template was built from the ground up using the latest .NET technologies.

 - Thanks to the new `UseWPF` flag introduced in .NET Core 3.0 we can build WPF projects in the new `csproj` format.
 
 
 
## Customizable.

All of the code used to embed MonoGame in WPF is included in this template. You can edit and customize it however you like. 

 - The template includes a `MonoGameViewModel` as an example of how to get started. If you use a different view model architecture, just change it.
 - The project references the `MonoGame.Content.Builder` package so that it can automatically build your `Content.mgcb` file. You can load content using the `Content` manager just like you do in your games. If your editor doesn't need this you can simply remove it.
