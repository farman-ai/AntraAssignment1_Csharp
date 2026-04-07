using System;

namespace App04_FizzBuzz
{
    public class Program
    {
        public static void Run()
        {
            Console.WriteLine("--- FizzBuzz ---");
            
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.Write("FizzBuzz ");
                else if (i % 3 == 0) Console.Write("Fizz ");
                else if (i % 5 == 0) Console.Write("Buzz ");
                else Console.Write(i + " ");

                // Har 10 items ke baad ek line break (Enter) daalne ke liye
                if (i % 10 == 0)
                {
                    Console.WriteLine(); 
                }
            }
        }
    }
}