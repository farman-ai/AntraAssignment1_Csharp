namespace App06_GuessingGame
{
    public class Program
    {
        public static void Run()
        {
            // Question: Guess a random number between 1 and 3.
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("I have generated a number between 1 and 3.");
            Console.Write("Enter your guess: ");

            if (int.TryParse(Console.ReadLine(), out int guess))
            {
                if (guess < 1 || guess > 3) Console.WriteLine("Invalid range!");
                else if (guess == correctNumber) Console.WriteLine("Correct!");
                else if (guess < correctNumber) Console.WriteLine("Too low!");
                else Console.WriteLine("Too high!");
            }
        }
    }
}