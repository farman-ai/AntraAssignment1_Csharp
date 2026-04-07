# Antra Assignment 2 - Solution

This repository contains a small collection of console apps (C# / .NET) created for Assignment 2. Each app is a tiny, self-contained console project and there is a `MainMenu` project that acts as an interactive launcher to run any of them.

## Repository structure

Antra_Assignment2_FinalCode/
- AntraAssignment2.slnx                # Visual Studio solution
- MainMenu/
  - MainMenu.csproj
  - Program.cs                         # Main menu/launcher
- App01_CopyArray/
  - App01_CopyArray.csproj
  - Program.cs
- App02_GroceryList/
  - App02_GroceryList.csproj
  - Program.cs                          # Grocery List Manager
- App03_PrimesInRange/
  - App03_PrimesInRange.csproj
  - Program.cs
- App04_RotateSum/
  - App04_RotateSum.csproj
  - Program.cs
- App05_LongestSequence/
  - App05_LongestSequence.csproj
  - Program.cs
- App06_MostFrequent/
  - App06_MostFrequent.csproj
  - Program.cs
- App07_ReverseString/
  - App07_ReverseString.csproj
  - Program.cs
- App08_ReverseWords/
  - App08_ReverseWords.csproj
  - Program.cs
- App09_Palindromes/
  - App09_Palindromes.csproj
  - Program.cs
- App10_ParseURL/
  - App10_ParseURL.csproj
  - Program.cs

> Note: The projects above contain minimal Program classes. `MainMenu/Program.cs` is the interactive launcher that calls the `Run()` method on each app's `Program` class.

## Quick prerequisites

- .NET SDK (6.0+ or the version used for the projects). Verify with:

```bash
dotnet --info
```

- Visual Studio Code (recommended) with the C# extension (OmniSharp).

## How to open in VS Code

1. Open VS Code.
2. Choose `File -> Open Folder...` and open the `Antra_Assignment2_FinalCode` folder (the directory containing `AntraAssignment2.slnx`).
3. If you don't have the C# extension installed, VS Code will prompt or you can install it from the Extensions view (search for `C#`).
4. The extension will automatically detect the solution and projects. You can use the Run and Debug view to run `MainMenu` or individual projects.

## How to run from VS Code (Terminal)

Open the integrated terminal (View → Terminal) and run these commands from the repository root.

- Build the whole solution:

```bash
cd /path/to/Antra_Assignment2_FinalCode
dotnet build
```

- Run the interactive main menu (recommended):

```bash
dotnet run --project MainMenu/MainMenu.csproj
```

- Run a single app directly (example: Grocery List):

```bash
dotnet run --project App02_GroceryList/App02_GroceryList.csproj
```

## Running and testing notes

- The `MainMenu` program is interactive. After each task it prints `Press any key to return to Main Menu...` and calls `Console.ReadKey()`.
  - If you run the app with input piped or redirected (for automated tests), `Console.ReadKey()` will throw `InvalidOperationException` because `ReadKey` requires an interactive console. For non-interactive tests, either:
    - Run individual projects directly and avoid the `ReadKey` pause, or
    - Modify `MainMenu/Program.cs` to use `Console.ReadLine()` instead of `Console.ReadKey()`, or wrap the `ReadKey()` call with a check:

```csharp
if (!Console.IsInputRedirected) Console.ReadKey();
```

- Grocery List behavior (App02):
  - Typing `+ item` adds `item` to the list.
  - Typing `- item` removes the `item` from the list.
  - Typing `--` clears the list.
  - Typing `exit` exits the grocery task.
  - Pressing Enter (empty input) or entering only whitespace now returns to the main menu (this was implemented to support returning on blank input).

## Troubleshooting

- Build errors:
  - Ensure you have the correct .NET SDK installed and that `dotnet --info` shows a compatible SDK.
  - If a project references a class name/file that was renamed, restore the file/class names consistently (this repo uses `Program.cs` classes in each app folder).

- If `dotnet run` fails with a runtime exception when piping input, see the note above about `Console.ReadKey()` and use `Console.IsInputRedirected` guard or `ReadLine`.

## Recommended quick test (interactive)

1. Build the solution:

```bash
dotnet build
```

2. Run the main menu:

```bash
dotnet run --project MainMenu/MainMenu.csproj
```

3. At the menu choose `2` (Grocery List Manager), then try:
- `+ Apple` → adds item
- `+ Mango` → adds item
- `--` → clears
- Press `Enter` (empty input) → returns to main menu
- From main menu choose `0` to exit

## If you want me to

- Change `MainMenu` to use `Console.ReadLine()` (so piped tests work) or add a small guard around `Console.ReadKey()` to avoid exceptions when input is redirected — tell me which behavior you prefer and I will update `MainMenu/Program.cs` and run the build + a piped smoke test.
- Re-run or add simple automated tests for tasks.

---

If you'd like, I can now update `MainMenu` to be safe for redirected input (skip `ReadKey()` when stdin is redirected) and re-run the build/test. Which behavior do you prefer: skip `ReadKey()` when input is redirected, or switch to `ReadLine()` for the pause?"