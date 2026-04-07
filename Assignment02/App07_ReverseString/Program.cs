using System;

namespace App07_ReverseString
{
    public class Program
    {
        public static void Run()
        {
            Console.Write("Enter string to reverse: ");
            string input = Console.ReadLine();

            // Method 1: Char Array
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string method1 = new string(charArray);
            Console.WriteLine("Method 1 (Char Array): " + method1);

            // Method 2: For-loop
            Console.Write("Method 2 (For Loop):   ");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}