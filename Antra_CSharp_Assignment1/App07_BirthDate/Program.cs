namespace App07_BirthDate
{
    public class Program
    {
        public static void Run()
        {
            // Question: Calculate days old and next 10,000 day anniversary.
            Console.Write("Enter your birth date (yyyy-mm-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dob))
            {
                int daysOld = (DateTime.Now - dob).Days;
                Console.WriteLine($"You are {daysOld} days old.");

                int daysToNext = 10000 - (daysOld % 10000);
                DateTime nextAnniversary = DateTime.Now.AddDays(daysToNext);
                Console.WriteLine($"Your next 10,000-day anniversary is: {nextAnniversary.ToShortDateString()}");
            }
        }
    }
}