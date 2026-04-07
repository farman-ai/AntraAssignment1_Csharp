using System;

namespace App01_CopyArray
{
    public class Program
    {
        public static void Run()
        {
            int[] originalArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] copiedArray = new int[originalArray.Length];

            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
            }

            Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
            Console.WriteLine("Copied Array:   " + string.Join(", ", copiedArray));
        }
    }
}