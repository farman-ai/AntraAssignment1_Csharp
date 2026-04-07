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
                Console.WriteLine("  ANTRA INC. - ASSIGNMENT 02 (ARRAYS & STRINGS)");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1.  Copying an Array");
                Console.WriteLine("2.  Grocery List Manager");
                Console.WriteLine("3.  Find Primes in Range");
                Console.WriteLine("4.  Rotate and Sum Array");
                Console.WriteLine("5.  Longest Sequence of Equal Elements");
                Console.WriteLine("6.  Most Frequent Number");
                Console.WriteLine("7.  Reverse String (Two Ways)");
                Console.WriteLine("8.  Reverse Words in Sentence");
                Console.WriteLine("9.  Extract Palindromes");
                Console.WriteLine("10. Parse URL");
                Console.WriteLine("0.  Exit");
                Console.Write("\nSelect a task: ");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1": App01_CopyArray.Program.Run(); break;
                    case "2": App02_GroceryList.Program.Run(); break;
                    case "3": App03_PrimesInRange.Program.Run(); break;
                    case "4": App04_RotateSum.Program.Run(); break;
                    case "5": App05_LongestSequence.Program.Run(); break;
                    case "6": App06_MostFrequent.Program.Run(); break;
                    case "7": App07_ReverseString.Program.Run(); break;
                    case "8": App08_ReverseWords.Program.Run(); break;
                    case "9": App09_Palindromes.Program.Run(); break;
                    case "10": App10_ParseURL.Program.Run(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid Selection."); break;
                }

                Console.WriteLine("\nPress any key to return to Main Menu...");
                if (!Console.IsInputRedirected)
                {
                    Console.ReadKey();
                }
                else
                {
                    // When input is redirected (piped/non-interactive), skip the pause
                    Console.WriteLine("(input redirected — continuing)");
                }
            }
        }
    }
}
