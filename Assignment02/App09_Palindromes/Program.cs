using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace App09_Palindromes
{
    public class Program
    {
        public static void Run()
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();

            string[] words = Regex.Split(input, @"\W+").Where(w => w.Length > 0).ToArray();
            List<string> palindromes = new List<string>();

            foreach (string word in words)
            {
                string reversed = new string(word.Reverse().ToArray());
                if (word.Equals(reversed, StringComparison.OrdinalIgnoreCase))
                {
                    palindromes.Add(word);
                }
            }

            var uniqueSorted = palindromes.Distinct().OrderBy(p => p).ToList();
            Console.WriteLine("Palindromes: " + string.Join(", ", uniqueSorted));
        }
    }
}