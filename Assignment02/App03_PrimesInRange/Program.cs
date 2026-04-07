using System;
using System.Collections.Generic;

namespace App03_PrimesInRange
{
    public class Program
    {
        public static void Run()
        {
            Console.Write("Enter start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            int end = int.Parse(Console.ReadLine());

            int[] primes = FindPrimesInRange(start, end);
            Console.WriteLine("Primes: " + string.Join(", ", primes));
        }

        static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();
            for (int i = Math.Max(2, startNum); i <= endNum; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0) { isPrime = false; break; }
                }
                if (isPrime) primes.Add(i);
            }
            return primes.ToArray();
        }
    }
}
