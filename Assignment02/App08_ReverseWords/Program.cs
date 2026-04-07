using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace App08_ReverseWords
{
    public class Program
    {
        public static void Run()
        {
            Console.Write("Enter sentence: ");
            string input = Console.ReadLine();

            string pattern = @"([.,:;=()&\[\]""'\\/!? ]+)";
            string[] parts = Regex.Split(input, pattern);

            List<string> words = new List<string>();
            for (int i = 0; i < parts.Length; i += 2)
            {
                words.Add(parts[i]);
            }

            words.Reverse();

            int wordIndex = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.Write(words[wordIndex]);
                    wordIndex++;
                }
                else 
                {
                    Console.Write(parts[i]);
                }
            }
            Console.WriteLine();
        }
    }
}