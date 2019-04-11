using System;
using System.Text;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // This gives an error. Strings in C# are immutable.
            //string SomeText = "Some text";
            //SomeText[0] = 'N';

            // Strings of type StringBuilder are mutalbe.
            StringBuilder sb = new StringBuilder("Some text");
            Console.WriteLine(sb);
            sb[0] = 'N';
            Console.WriteLine(sb);
        }
    }
}