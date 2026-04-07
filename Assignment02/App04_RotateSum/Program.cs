using System;
using System.Linq;

namespace App04_RotateSum
{
    public class Program
    {
        public static void Run()
        {
            Console.Write("Enter array (space separated): ");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.Write("Enter k (rotations): ");
            int k = int.Parse(Console.ReadLine());

            int n = array.Length;
            int[] sum = new int[n];

            for (int r = 1; r <= k; r++)
            {
                for (int i = 0; i < n; i++)
                {
                    int newIndex = (i + r) % n;
                    sum[newIndex] += array[i];
                }
            }

            Console.WriteLine("Sum[] = " + string.Join(" ", sum));
        }
    }
}