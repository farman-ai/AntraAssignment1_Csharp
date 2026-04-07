namespace App03_CenturyConverter
{
    public class Program
    {
        public static void Run()
        {
            // Question: Convert centuries to years, days, hours, minutes, seconds, etc.
            Console.Write("Enter number of centuries: ");
            if (uint.TryParse(Console.ReadLine(), out uint centuries))
            {
                uint years = centuries * 100;
                uint days = (uint)(years * 365.2422); 
                uint hours = days * 24;
                ulong minutes = (ulong)hours * 60;
                ulong seconds = minutes * 60;
                ulong milliseconds = seconds * 1000;
                ulong microseconds = milliseconds * 1000;
                // Decimal used for nanoseconds to avoid ulong overflow on high input
                decimal nanoseconds = (decimal)microseconds * 1000;

                Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
            }
        }
    }
}
