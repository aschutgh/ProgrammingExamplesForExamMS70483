#define DEBUG
//#undef DEBUG
using System;

/*
 * DEBUG symbol is defined by the line #define DEBUG
 * #if DEBUG checks if DEBUG is defined and if this is the case the statement
 * Console.WriteLine("Debug mode is on"); is executed.
 * To disable this behaviour do the following:
 * comment the #define DEBUG line
 * uncomment the #undef DEBUG line
 *  
 *  source: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives/
 */

namespace CSharpDirectives
{
    class Program
    {
        static void Main(string[] args)
        {
            #if DEBUG
                Console.WriteLine("Debug mode is on");
            #endif            
            Console.WriteLine("Hello World!");
        }
    }
}
