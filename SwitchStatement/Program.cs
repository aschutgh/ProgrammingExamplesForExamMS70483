using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "connection_failed";
            // string response = "connection_succes";
            // string response = "this will default";

            switch(response)
            {
                case "connection_failed":
                    Console.WriteLine("The connection failed!");
                    break;
                case "connection_succes":
                    Console.WriteLine("The connection succeeded.");
                    break;
                default:
                    Console.WriteLine("This message prints if above cases fail");
                    break;
            }

            Console.WriteLine("===============================");
            // switch multiple cases example
            int value = 5;

            switch(value)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("Variable value has value 0, 1 or 2");
                    break;
                case 3:
                    Console.WriteLine("Variable value has value 3");
                    break;
                default:
                    Console.WriteLine("Variable value has value larger than 3");
                    break;
            }
        }
    }
}
