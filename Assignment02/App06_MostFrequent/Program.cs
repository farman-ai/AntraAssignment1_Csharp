using System;
using System.Collections.Generic;
using System.Linq;

namespace App06_MostFrequent
{
    public class Program
    {
        public static void Run()
        {
            Console.Write("Enter sequence (space separated): ");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var counts = new Dictionary<int, int>();
            int maxFreq = 0;
            int mostFreqNum = array[0];

            foreach (int num in array)
            {
                if (!counts.ContainsKey(num)) counts[num] = 0;
                counts[num]++;

                if (counts[num] > maxFreq)
                {
                    maxFreq = counts[num];
                    mostFreqNum = num;
                }
            }

            Console.WriteLine($"The number {mostFreqNum} is the most frequent (occurs {maxFreq} times)");
        }
    }
}