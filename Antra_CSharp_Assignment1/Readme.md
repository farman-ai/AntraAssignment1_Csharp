# Antra C# Assignment 01

This solution contains multiple console applications addressing the core fundamentals of C# and .NET.

## Project Structure
The solution `assignment1antra.sln` consists of the following projects:

| Project Name | File | Description |
| :--- | :--- | :--- |
| **MainMenu** | `Program.cs` | The central controller to run all assignments. |
| **App01_HackerName** | `Program.cs` | Hacker name generator using user input. |
| **App02_UnderstandingTypes** | `Program.cs` | Outputs memory sizes and ranges of C# types. |
| **App03_CenturyConverter** | `Program.cs` | Converts centuries to nanoseconds (handles overflow). |
| **App04_FizzBuzz** | `Program.cs` | Simulated FizzBuzz game (1-100). |
| **App05_PrintPyramid** | `Program.cs` | Prints a star pyramid using nested loops. |
| **App06_GuessingGame** | `Program.cs` | Number guessing game with logic feedback. |
| **App07_BirthDate** | `Program.cs` | Calculates days old and 10k-day anniversaries. |
| **App08_TimeOfDay** | `Program.cs` | Greets user based on system time (if statements). |
| **App09_CountTo24** | `Program.cs` | Nested loops with variable increments. |

## 🚀 How to Execute

1. Open the solution file `assignment1antra.sln` in JetBrains Rider, Visual Studio, or VS Code.
2. Set the startup project to `MainMenu` (Right-click → Set as Startup Project in Rider/VS).
3. Run with the debugger (F5) or start without debugging (Ctrl+F5 / Run button).
4. Use the numeric console menu to pick an exercise. Press `0` to exit.

## Running in VS Code (recommended)

1. Open VS Code and open the folder `Antra_CSharp_Assignment1` (File → Open Folder).
2. Install the C# extension (ms-dotnettools.csharp) if prompted.
3. Build via the Command Palette (Cmd+Shift+P) → `Tasks: Run Task` → `dotnet: build`, or build from the integrated terminal.
4. Run the Main Menu from the integrated terminal:

```bash
cd Antra_CSharp_Assignment1
dotnet run --project MainMenu/MainMenu.csproj
```

To auto-exit immediately after the menu is printed (useful for automation or CI):

```bash
echo "0" | dotnet run --project MainMenu/MainMenu.csproj --no-build
```

## Running from the command line (macOS / Linux / WSL / Windows)

1. Open a terminal and `cd` into `Antra_CSharp_Assignment1`.
2. (Optional) Build explicitly:

```bash
dotnet build MainMenu/MainMenu.csproj
```

3. Run the main menu:

```bash
dotnet run --project MainMenu/MainMenu.csproj
```

Then use the numeric menu to choose an app.

## 📚 Theory Documentation
Full theory answers, including data type selection and .NET internals, are located in the generated PDF/Documentation section.