namespace App09_CountTo24
{
    public class Program
    {
        public static void Run()
        {
            // Question: Count up to 24 using increments 1, 2, 3, and 4.
            for (int outer = 1; outer <= 4; outer++)
            {
                for (int inner = 0; inner <= 24; inner += outer)
                {
                    Console.Write(inner + (inner + outer > 24 ? "" : ","));
                }
                Console.WriteLine();
            }
        }
    }
}