# Simple mono.wasm sample

Based on the sample from here: https://github.com/mono/mono/tree/master/sdks/wasm

_Note_: mono.wasm is in a very early experimental stage!

## Step 1

To setup the sample, first you need to compile & setup a directory to serve binaries:

**Linux / Mac**

```
mkdir managed
cp bcl/mscorlib.dll managed/
csc /nostdlib /target:library /r:managed/mscorlib.dll /out:managed/sample.dll sample.cs
```

**Windows**

The **csc** executable is a build tool that is installed with Visual Studio. For the commands below, using a command window opened using a _Developer Command Prompt for Visual Studio_ is convenient.

```
md managed
copy bcl\mscorlib.dll managed
csc /nostdlib /target:library /r:managed/mscorlib.dll /out:managed/sample.dll sample.cs
```

## Step 2

Pick a pre-built runtime from one of the directories and copy all files to the root sample directory. Allow file overwrites if necessary:

**Linux / Mac**

```
cp debug/* .
```

**Windows**

```
copy debug\* .
```

## Step 3

Start a web server from the sample directory (where index.html is), e.g. with the provided Python script:
```
python server.py
```

## Step 4

From within a browser, go to `localhost:8000/index.html` to see the sample app, which will show a text box (allowing C# code to be entered) and **Run** button when successfully built.
