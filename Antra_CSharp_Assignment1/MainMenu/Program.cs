using System;

namespace MainMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("    ANTRA INC. - C# ASSIGNMENT 01 MENU       ");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Hacker Name Generator");
                Console.WriteLine("2. Number Type Ranges");
                Console.WriteLine("3. Century Converter");
                Console.WriteLine("4. FizzBuzz Game");
                Console.WriteLine("5. Print Star Pyramid");
                Console.WriteLine("6. Guessing Game");
                Console.WriteLine("7. Birth Date Calculator");
                Console.WriteLine("8. Time-Based Greeting");
                Console.WriteLine("9. Nested Counting (to 24)");
                Console.WriteLine("0. Exit");
                Console.Write("\nSelect a task: ");

                string? choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1": App01_HackerName.Program.Run(); break;
                    case "2": App02_UnderstandingTypes.Program.Run(); break;
                    case "3": App03_CenturyConverter.Program.Run(); break;
                    case "4": App04_FizzBuzz.Program.Run(); break;
                    case "5": App05_PrintPyramid.Program.Run(); break;
                    case "6": App06_GuessingGame.Program.Run(); break;
                    case "7": App07_BirthDate.Program.Run(); break;
                    case "8": App08_TimeOfDay.Program.Run(); break;
                    case "9": App09_CountTo24.Program.Run(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid Selection."); break;
                }

                Console.WriteLine("\n----------------------------------------------");
                Console.WriteLine("Press any key to return to Main Menu...");
                Console.ReadKey();
            }
        }
    }
}