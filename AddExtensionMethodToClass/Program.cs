using System;
using ExtensionMethods;

/* Add a new namespace
 * Add a new public static class to this namespace
 * Write Extension method
 * First parameter should be the type to which your method should be added.
 * The type should be preceded by the keyword this
 * Write the body of the extension method
 * 
 */

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
namespace AddExtensionMethodToClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string HelloWorld = "Hello World! This sentence contains more than two words.";
            Console.WriteLine($"The string \"{HelloWorld}\" has {HelloWorld.WordCount()} words");
        }
    }
}
