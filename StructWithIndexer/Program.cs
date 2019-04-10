using System;

// source: 20483B Programming in Visual C#

namespace StructWithIndexer
{
    class Program
    {
        //Declaring a struct
        public struct Coffee
        {
            public int Strength;
            public string Bean;
            public string CountryOfOrigin;
        }


        static void Main(string[] args)
        {
            // Using a struct
            Coffee coffee1 = new Coffee();
            coffee1.Strength = 3;
            coffee1.Bean = "Arabica";
            coffee1.CountryOfOrigin = "Kenya";
            Console.WriteLine(coffee1.Strength);
            Console.WriteLine(coffee1.Bean);
            Console.WriteLine(coffee1.CountryOfOrigin);
        }
    }
}
