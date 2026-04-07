# Antra C# Assignments — Main README

This repository contains two sets of C# assignments completed for the Antra course. Use this top-level README to quickly find, build, and run the projects on macOS (zsh) using the .NET SDK (dotnet CLI).

## Repository layout

- `Assignment01/` - First assignment containing multiple small console apps and a `MainMenu` project. Solution file: `Assignment01/Antra_CSharp_Assignment1.sln`
- `Assignment02/` - Second assignment with additional console apps and a `MainMenu` project. Solution file: `Assignment02/AntraAssignment2.slnx`

Each `AppXX_*/` folder is a standalone console app with its own `.csproj` and `Program.cs`. There is also a `MainMenu/` project in each assignment that can be used to access or launch the apps in that assignment.

## Requirements

- .NET SDK (recommended .NET 6 or .NET 7). Verify with:

```bash
dotnet --version
```

- A terminal (macOS default shell: zsh) or an IDE that supports C# (.NET) such as Visual Studio for Mac, Rider, or Visual Studio Code with the C# extension.

## Quick start — build and run

From the repository root (`/Users/mac/AntraAssignment_Csharp`), you can build/run individual projects using the dotnet CLI.

Run the MainMenu for Assignment01:

```bash
dotnet run --project Assignment01/MainMenu/MainMenu.csproj
```

Run the MainMenu for Assignment02:

```bash
dotnet run --project Assignment02/MainMenu/MainMenu.csproj
```

Run a specific app directly (example: App01 in Assignment01):

```bash
dotnet run --project Assignment01/App01_HackerName/App01_HackerName.csproj
```

Build an entire solution (all projects under a solution file):

```bash
dotnet build Assignment01/Antra_CSharp_Assignment1.sln
dotnet build Assignment02/AntraAssignment2.slnx
```

List projects in a solution:

```bash
dotnet sln Assignment01/Antra_CSharp_Assignment1.sln list
dotnet sln Assignment02/AntraAssignment2.slnx list
```

Find every project file in the repo (handy when exploring):

```bash
find . -name "*.csproj" -print
```

## Notes & tips

- If `dotnet` is not found, install the .NET SDK from Microsoft (choose a supported SDK like 6.x or 7.x) and re-open your terminal.
- If you prefer an IDE, open the solution files:
  - `Assignment01/Antra_CSharp_Assignment1.sln`
  - `Assignment02/AntraAssignment2.slnx`

- When running with `dotnet run --project`, the command will build the project automatically if necessary.

## Troubleshooting

- Build errors: read the error messages, ensure the .NET SDK version matches the target framework in the `.csproj` files.
- Missing packages: run `dotnet restore` in the solution folder to restore NuGet packages.

```bash
dotnet restore Assignment01/Antra_CSharp_Assignment1.sln
dotnet restore Assignment02/AntraAssignment2.slnx
```

## Contributing / Notes

- This repository is organized as reference solutions for small console assignments. If you add or rename projects, update the README with the new paths.
- For any questions or improvements to these instructions, open an issue or update this README with more examples.

---

Happy coding!
