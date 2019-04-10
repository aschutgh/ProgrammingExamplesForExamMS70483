using System;

/*
 * Checks if an object is compatible with a given type, or (starting with C# 7.0)
 * tests an expression against a pattern.
 * 
 * syntax of the is operator: expr is type
 * 
 * source: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/is
 * 
 */

namespace IsOperator
{
    class Person
    {
        private string name;
        private int age;

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set // some validation logic...
            {
                if (value < 0)
                {
                    age = 0;
                }
                else if (value > 120)
                {
                    age = 120;
                }
                else
                {
                    age = value;
                }
            }
        }

        // Declare custom constructor
        public Person(string Name, int Age)
        {
            this.name = Name;
            this.age = Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John Doe", 37);
            Person person2 = new Person("Santa Claus", 41);
            
            object o = new Person("Jane Doe", 29);
            Console.WriteLine(person1.GetType());
            Console.WriteLine(o.GetType());
            
            Console.WriteLine($"person1 is a Person? {person1 is Person}");
            Console.WriteLine($"object o is a Person? {o is Person}");
            Console.WriteLine($"object o is string? {o is string}");
            Console.WriteLine($"person1 is an object? {person1 is object}");
            Console.WriteLine($"person1 is IsOperator.Person? {person1 is IsOperator.Person}");
            // The following is pointless. The compiler gives a warning.
            // int is a value type. person2 is a reference type. These can never be the same.
            Console.WriteLine($"person2 is an int? {person2 is int}");
        }
    }
}
