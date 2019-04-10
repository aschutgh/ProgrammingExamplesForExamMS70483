using System;

namespace NamedAndOptionalParameters
{

    class Program
    {
        static void NamedParameters(int OrderID, string Customer, string Product)
        {
            Console.WriteLine(OrderID);
            Console.WriteLine(Customer);
            Console.WriteLine(Product);
        }

        static void OptionalParameters(int OrderID, string Customer = "John Doe", string Product = "Table")
        {
            Console.WriteLine(OrderID);
            Console.WriteLine(Customer);
            Console.WriteLine(Product);
        }

        static void Main(string[] args)
        {
            // arguments by position
            NamedParameters(31, "John Doe", "Table");
            // arguments by name, doesn't have to be in order
            NamedParameters(Customer: "John Doe", Product: "Table", OrderID: 31);
            // arguments by position and by name are possible
            // positional arguments come first
            NamedParameters(31, Product: "Table", Customer: "John Doe");

            // Optional paramters
            Console.WriteLine("Optional parameters example:\n");
            OptionalParameters(31);
            OptionalParameters(31, "Someone else");
            OptionalParameters(31, Product: "Fridge");
            OptionalParameters(Product: "Fridge", Customer: "The Neighbour", OrderID: 37);
        }
    }
}
