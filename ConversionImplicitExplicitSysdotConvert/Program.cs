using System;

namespace ConversionImplicitExplicitSysdotConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            int a = 4;
            long b;
            b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            // explicit conversion
            Console.WriteLine("================================");
            int c;
            long d = 5;
            c = (int)d; // explicit conversion of long d to int c
            Console.WriteLine(c);

            // using System.Convert()

            string possibleInt = "1234";
            int count = Convert.ToInt32(possibleInt);
            Console.WriteLine(count);
        }
    }
}
