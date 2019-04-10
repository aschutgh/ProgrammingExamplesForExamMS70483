using System;

// source: 20483B Programming in Visual C#
// FIXME: add struct with indexer

namespace StructWithIndexer
{
    class Program
    {
        //Declaring a struct
        public struct Coffee
        {
            private int strength;
            private string bean;
            private string countryOfOrigin;

            // Strength property
            public int Strength
            {
                get { return strength; }
                set
                {
                    if (value < 1)
                    { strength = 1; }
                    else if (value > 5)
                    { strength = 5; }
                    else
                    { strength = value; }
                }
            }

            // Bean property (readonly)
            public string Bean
            {
                get { return bean; }
            }

            public string CountryOfOrigin
            {
                get { return countryOfOrigin; }
            }

            // Name of the constructor is equal to the name of the struct
            public Coffee(int strength, string bean, string countryOfOrigin )
            {
                this.strength = strength; // this refers to the particular instance of a Coffee struct
                this.bean = bean; // bean refers to the parameter in the custom Coffee constructor
                this.countryOfOrigin = countryOfOrigin;
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
