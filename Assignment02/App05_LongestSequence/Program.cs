using System;
using System.Linq;

namespace App05_LongestSequence
{
    public class Program
    {
        public static void Run()
        {
            Console.Write("Enter array (space separated): ");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (array.Length == 0) return;

            int bestCount = 1, currentCount = 1, bestElement = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestElement = array[i];
                }
            }

            Console.WriteLine("Output: " + string.Join(" ", Enumerable.Repeat(bestElement, bestCount)));
        }
    }
}