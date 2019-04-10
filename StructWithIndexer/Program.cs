using System;

// source: 20483B Programming in Visual C#


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

        public struct Menu
        {
            public Coffee[] coffees; // Coffee array cannot be instantiated within a struct

            public Coffee this[int index]

            {
                get { return coffees[index]; }
                set { coffees[index] = value; }
            }

            public int Length
            {
                get { return coffees.Length; }
            }
        }

        static void Main(string[] args)
        {
            // Using a struct
            Coffee coffee1 = new Coffee(3, "Arabica", "Kenya");
            Console.WriteLine(coffee1.Strength);
            Console.WriteLine(coffee1.Bean);
            Console.WriteLine(coffee1.CountryOfOrigin);
            Coffee coffee2 = new Coffee(4, "Arabica", "Colombia");
            Coffee coffee3 = new Coffee(2, "Arabica", "Nicaragua");
            Menu menu1 = new Menu();
            menu1.coffees = new Coffee[5];
            menu1[0] = coffee1;
            menu1[1] = coffee2;
            menu1[2] = coffee3;
            Console.WriteLine($"Number of coffees on the menu: {menu1.Length}");
            for(int i = 0; i < menu1.Length; i++)
            {
                Console.WriteLine($"{i} : {menu1[i].Bean}");
                Console.WriteLine($"{i} : {menu1[i].Strength}");
                Console.WriteLine($"{i} : {menu1[i].CountryOfOrigin}");
                Console.WriteLine();
            }
        }
    }
}
