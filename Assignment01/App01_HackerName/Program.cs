namespace App01_HackerName
{
    public class Program
    {
        public static void Run()
        {
            // Question: Create a console application that asks the user a few questions 
            // and generates a "hacker name".
            Console.WriteLine("--- Hacker Name Generator ---");
            Console.Write("What is your favorite color? ");
            string color = Console.ReadLine();
            Console.Write("What is your astrology sign? ");
            string sign = Console.ReadLine();
            Console.Write("What is your street address number? ");
            string street = Console.ReadLine();

            Console.WriteLine($"\nYour hacker name is {color}{sign}{street}.");
        }
    }
}