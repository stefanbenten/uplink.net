# uplink.NET
[![Storj.io](https://storj.io/img/storj-badge.svg)](https://storj.io)

**A .Net/C#-wrapper for Storj (v3)**

This library enables you to connect to the storj-network to upload and retrieve files to the distributed and secure cloud-storage.

Currently this library is under heavy development and it is not yet ready to use. You'll be able to compile it for yourself or use a Nuget in your projects.

If you want to help out, check the open issues, create some or open a PR.

## Use

There does not exist a working release, yet. Please come back later.

## Build

**Prerequesits**

Building everything by yourself is possible on Windows. You'll need the following tools:

* Git (to get the storj-repository)
* SWIG (to generate the C#-proxy)
* Go (to build the C-Binding to storj/uplink)
* [MSYS2](https://www.msys2.org/) (used by go to compile a Windows-DLL)
* Visual Studio 2017 or higher to compile the uplink.NET-library

**Noob-Disclaimer**

The process described here is the way I was successfull so far. It might not be the simplest way or you might be successfull using different compilers, versions, systems and whatever. I'm open to any adjustments, enhancements or proposials. Just let me know!
Furthermore this process involves some manual tasks that might be possible to automate by using a better SWIG-interface-file or some other build automation tools. I would love getting help by making this process better.

**Building-steps**

First you need to pull the latest version of storj/uplink. Open a command prompt and enter:

```
git clone https://github.com/storj/storj.git
```

Do this also for this repository in another directory:

```
git clone https://github.com/topperdel/uplink.net.git
```

Copy the files storj_uplink_first.i and storj_uplink_second.i to storj\lib\uplinkc of the local storj-repository. Do the same for the file string_handling.go. cd to that directory. Then run

```
swig -csharp -namespace uplink.SWIG storj_uplink_first.i
```

This will create many cs-files, obe h-file and one c-file. Ignore the cs-files for the moment. We now build the dll with go which will include the storj_uplink_wrap.c-file that got generated by SWIG.

In the same command prompt run:

```
go build -o storj_uplink.dll -buildmode c-shared 
```

You may want to alter specific GCC/MingW or Go-settings to build the DLL for different CPU-architectures. Here I'm only building a x64 DLL for Windows. To fully support .Net and UWP, it would be necessary to build x86 and ARM-DLLs, too. Help is appreciated!

With the DLL GCC creates another h-file, that needs to be included in the SWIG-C#-proxy. Delete all cs-files, to start new:

```
del *.cs 
```

Now create the SWIG-proxy again using the second i-file. It includes the additional h-file and some SWIG-specifics to handle ref-strings:

```
swig -csharp -namespace uplink.SWIG storj_uplink_second.i
```

TODO: Create DLL again, delete storj_uplink_first_wrap.c 

Now copy all cs-files to the uplink.NET repository replacing all containing files. If you made changes to the SWIG-files, you may need to adjust the Visual Studio solution to include only the created cs-files. And if you compiled the DLL for different cpu-architectures you may need to alter the solution properties accordingly.

In the file storj_uplinkPINVOKE.cs search for "free_string" and remove the "ref" from the parameter jarg1. This should be handled by SWIG, but I don't know how.
In the file storj_uplink.cs also remove the "ref" from the call to storj_uplinkPINVOKE.free_string().

Build the solution and include the uplink.net.dll and the storj_uplink.dll in your project.
