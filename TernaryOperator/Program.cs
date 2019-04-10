using System;

/*
 * source: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
 * 
 * condition ? consequent : alternative
 * 
 * The condition expression must evaluate to true or false.
 * If condition evaluates to true, the consequent expression is
 * evaluated, and its result becomes the result of the operation.
 * If condition evaluates to false, the alternative expression is
 * evaluated, and its result becomes the result of the operation.
 * 
 * 
 */


namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = -10; i <= 20; i++)
            {
                Console.WriteLine($"{i} is {(i % 2 == 0 ? "even" : "odd" )}");
            }
        }
    }
}
