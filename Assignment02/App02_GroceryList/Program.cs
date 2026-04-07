using System;
using System.Collections.Generic;

namespace App02_GroceryList
{
    public class Program
    {
        public static void Run()
        {
            List<string> groceryList = new List<string>();
            Console.WriteLine("--- Grocery List Manager ---");
            Console.WriteLine("Type 'exit' to quit this task.\n");

            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit") break;
                // If the user presses Enter or enters only whitespace, return to Main Menu
                if (string.IsNullOrWhiteSpace(input)) return;

                if (input == "--")
                {
                    groceryList.Clear();
                }
                else if (input.StartsWith("+ "))
                {
                    groceryList.Add(input.Substring(2));
                }
                else if (input.StartsWith("- "))
                {
                    groceryList.Remove(input.Substring(2));
                }

                Console.WriteLine("Current List: " + (groceryList.Count > 0 ? string.Join(", ", groceryList) : "[Empty]"));
                Console.WriteLine("-----------------------");
            }
        }
    }
}