continue
# .NET 8 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that an .NET 8.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 8.0 upgrade.
3. Upgrade FlightFinder.Blazor.csproj

## Settings

This section contains settings and data used by execution steps.

### Excluded projects

Table below contains projects that do belong to the dependency graph for selected projects and should not be included in the upgrade.

| Project name                                   | Description                 |
|:-----------------------------------------------|:---------------------------:|

### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                        | Current Version | New Version | Description                         |
|:------------------------------------|:---------------:|:-----------:|:------------------------------------|
| Microsoft.AspNetCore.Blazor                 | 3.1.0-preview4.19579.2 | remove | Replaced by modern Blazor WASM SDK in .NET 8 |
| Microsoft.AspNetCore.Blazor.Build           | 3.1.0-preview4.19579.2 | remove | Replaced by modern Blazor WASM SDK in .NET 8 |
| Microsoft.AspNetCore.Blazor.HttpClient      | 3.1.0-preview4.19579.2 | remove | Replaced by modern Blazor WASM SDK in .NET 8 |
| Microsoft.AspNetCore.Blazor.DevServer       | 3.1.0-preview4.19579.2 | remove | Replaced by modern Blazor WASM SDK in .NET 8 |

### Project upgrade details
This section contains details about each project upgrade and modifications that need to be done in the project.

#### FlightFinder.Blazor.csproj modifications

Project properties changes:
  - Target framework should be changed from `netstandard2.1` to `net8.0`
  - Switch to modern Blazor WebAssembly project SDK (`Microsoft.NET.Sdk.Web`) and use `WebAssembly` entrypoint with `Program.cs` hosting model

NuGet packages changes:
  - Remove legacy Blazor 3.1 preview packages (Build, DevServer, HttpClient) as SDK supplies features in .NET 8

Feature upgrades:
  - Migrate to `Program.cs` hosting model with `WebAssemblyHostBuilder`
  - Update `wwwroot/index.html` boot script to `blazor.webassembly.js`
  - Replace `@using Microsoft.AspNetCore.Components.Web` imports if needed and align with .NET 8 templates

Other changes:
  - Replace project reference to `FlightFinder.Shared` binary with a project reference if source project exists, or add to solution
