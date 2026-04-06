namespace App02_UnderstandingTypes
{
    public class Program
    {
        public static void Run()
        {
            // Question: Output bytes, min, and max values for various number types.
            Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", "Type", "Bytes", "Min", "Max");
            Console.WriteLine(new string('-', 85));

            PrintTypeInfo("sbyte",sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            PrintTypeInfo("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            PrintTypeInfo("short", sizeof(short), short.MinValue, short.MaxValue);
            PrintTypeInfo("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            PrintTypeInfo("int", sizeof(int), int.MinValue, int.MaxValue);
            PrintTypeInfo("uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            PrintTypeInfo("long", sizeof(long), long.MinValue, long.MaxValue);
            PrintTypeInfo("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            PrintTypeInfo("float", sizeof(float), float.MinValue, float.MaxValue);
            PrintTypeInfo("double", sizeof(double), double.MinValue, double.MaxValue);
            PrintTypeInfo("decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        }

        static void PrintTypeInfo(string name, int size, object min, object max)
        {
            Console.WriteLine("{0,-10} {1,-10} {2,-30} {3,-30}", name, size, min, max);
        }
    }
}