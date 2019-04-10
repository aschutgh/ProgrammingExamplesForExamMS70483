using System;

/* 
 * source: 20483B Programming in Visual C#
 * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing
 * 
 */

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // The process of converting a value type to a reference type is called boxing
            int i = 100;
            object o = i;
            Console.WriteLine($"{i} {o}");
            i = 133;
            Console.WriteLine($"After changing variable i the values are: i: {i} and o: {o}");

            // The process of converting a reference type to a value type is called unboxing.
            Console.WriteLine("Unboxing:");
            int j;
            j = (int)o;
            Console.WriteLine($"{o} {j}");

        }
    }
}
