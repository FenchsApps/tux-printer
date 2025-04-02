# Tux Printer

A simple Linux utility that prints the official Tux penguin in authentic colors.

## Installation

```bash
dotnet publish -c Release -r linux-x64 --self-contained true
sudo ln -s $PWD/bin/Release/net6.0/linux-x64/publish/TuxPrinter /usr/local/bin/tux-print
```

## Usage

Just type:
```bash
tux-print
```

![Tux Example](tux-example.png)
