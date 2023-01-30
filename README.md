# StartMinimized

It is annoying in server that consoles flash frequently because of Task Scheduler calling `cmd` periodically.

You can only either run your batch in totally background or endure the console flashing.

## Start Minimized

Therefore, I should create a tiny program which starts programs with minimized Window style at the first place.

Since programs are only minimized not hidden, I can check their healthness so easily.

## .NET 6

In order to make file size as small as possible. This is compiled with framework dependance.

[Download](https://github.com/tommy-iasia/StartMinimized/blob/main/StartMinimized/bin/Release/net6.0-windows/publish/win-x64/StartMinimized.exe) (353 KB)

## Arguments

First command line argument is the target program.

Other following command line arguments are also passed down to the target program.

## Code

```C#
WindowStyle = ProcessWindowStyle.Minimized
```

[Program.cs](StartMinimized/Program.cs) is so short that I suggest that you should build your own version.
