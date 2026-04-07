namespace App05_PrintPyramid
{
    public class Program
    {
        public static void Run()
        {
            // Question: Print a star pyramid using three total loops.
            int levels = 5;
            for (int i = 1; i <= levels; i++)
            {
                for (int j = 1; j <= levels - i; j++) Console.Write(" ");
                for (int k = 1; k <= (2 * i - 1); k++) Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}