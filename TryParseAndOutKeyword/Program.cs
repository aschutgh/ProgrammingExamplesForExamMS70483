using System;

namespace TryParseAndOutKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string numberString = "1234";
            // comment line above and uncomment line below to fail
            // string numberString = "1234thisshouldfail";
            // try to convert numberString to int and place result in number
            // returns true if succes otherwise false
            if (int.TryParse(numberString, out number)) // out keyword
            {
                Console.WriteLine("Conversion succeeded!");
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }
        }
    }
}
