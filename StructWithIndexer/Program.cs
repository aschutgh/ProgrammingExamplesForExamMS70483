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

            // Name of the constructor is equal to the name of the struct
            public Coffee(int strength, string bean, string countryOfOrigin )
            {
                this.Strength = strength; // this refers to the particular instance of a Coffee struct
                this.Bean = bean; // bean refers to the parameter in the custom Coffee constructor
                this.CountryOfOrigin = countryOfOrigin;
            }
        }


        static void Main(string[] args)
        {
            // Using a struct
            Coffee coffee1 = new Coffee(3, "Arabica", "Kenya");
            
            Console.WriteLine(coffee1.Strength);
            Console.WriteLine(coffee1.Bean);
            Console.WriteLine(coffee1.CountryOfOrigin);
        }
    }
}
