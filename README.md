# Get Changes

A minimal project to list all closed issues in GitHub repository by milestone in Markdown format. Right now, it is designed to create the changelist for NUnit.

## Installation

This program is a [dotnet tool](https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools) and requires the latest version of
the [.NET SDK](https://dotnet.microsoft.com/download) to be installed. .NET 5.0 or newer is recommended.

### Testing Locally

Build it, then package it using the **Pack** command in Visual Studio or `dotnet pack`
on the command line. Until this package is published, install it using the following
command line from the solution root;

```sh
dotnet tool install -g --add-source ./GetChanges/nupkg dotnet-getchanges
```

To update from a previous version,

```sh
dotnet tool update -g --add-source ./GetChanges/nupkg dotnet-getchanges
```

### Installing from GitHub Packages

Whenever the version is updated in `Guppi/Guppi.csproj`, a merge to master will publish the NuGet package
to [GitHub Packages](https://github.com/rprouse?tab=packages). You can install or update from there.

First you must update your global NuGet configuration to add the package registry and include the GitHub Personal
Access Token (PAT). This file is in `%appdata%\NuGet\NuGet.Config` on Windows and in `~/.config/NuGet/NuGet.Config`
or `~/.nuget/NuGet/NuGet.Config` on Linux/Mac.

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
    <add key="Local" value="C:\temp" />
    <add key="Microsoft Visual Studio Offline Packages" value="C:\Program Files (x86)\Microsoft SDKs\NuGetPackages\" />
    <add key="github" value="https://nuget.pkg.github.com/rprouse/index.json" />
  </packageSources>
  <packageSourceCredentials>
    <github>
      <add key="Username" value="rprouse" />
      <add key="ClearTextPassword" value="GITHUB_PAT" />
    </github>
  </packageSourceCredentials>
</configuration>
```

Once that is done, to install,

```sh
dotnet tool install -g dotnet-getchanges
```

And to update from a previous version,

```sh
dotnet tool update -g dotnet-getchanges
```

## Configuration ##

In order to run, you must set the GitHub authentication token. This token is a Personal Access Token which logs you into your GitHub account.

1. Visit the following URL: https://github.com/settings/tokens/new
2. Enter a description in the Token description field, like "GetChanges token".
3. Select the `Repo` scope.
4. Click Create Token.
5. Your new Personal Access token will be displayed, copy it
6. If running for the first time, the program will prompt for the token, otherwise to update the token, run with `--configure`

If you ever want to revoke the token, visit the GitHub Applications settings page and click Delete next to the key you wish to remove.

## Running on source code repo

If you prefer to just run it off the source code repo, you can do so by cloning the repo and running the following command line from the project folder,
for e.g. milestone 4.0:

For NUnit:
```cmd
`bin\Release\net7.0\getchanges.exe -o nunit -r nunit -l -m 4.0 > changes4.0.md`
```

For Nunit3TestAdapter:
```cmd
`bin\Release\net7.0\getchanges.exe -o nunit -r nunit3-vs-adapter -l -m 4.6 > nunit3-vs-adapter.changes4.6.md`
```



