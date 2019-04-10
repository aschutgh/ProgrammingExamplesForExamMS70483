using System;
using System.Numerics;
using System.Collections.Generic;


/*
 * Some recursion examples in C#
 */

namespace Recursion
{
    class Program
    {
        static BigInteger Factorial(BigInteger n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

        static bool Palindrome(string word)
        {
            if (word.Length <= 1)
                return true;

            if (word[0] != word[word.Length - 1])
                return false;

            return Palindrome(word.Substring(1, word.Length - 2));
        }

        static int Fibonacci(int n) // FIXME: rewrite with BigInteger to avoid integer overflow
        {
            if (n < 2)
                return n;
            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }

        // Fibonacci recursive function with memoization
        // A dictionary in Main is referenced. This is necassary because C# does not allow global variables
        static int FibonacciMemo(int n, ref Dictionary<int, int> FibNumbers)
        { // FIXME: rewrite with BigInteger to avoid integer overflow
            if (!FibNumbers.ContainsKey(n))
                FibNumbers.Add(n, FibonacciMemo(n - 1, ref FibNumbers) + FibonacciMemo(n - 2, ref FibNumbers));
            return FibNumbers[n];
        }
        static void Main(string[] args)
        {
            Dictionary<int, int> FibNumbers = new Dictionary<int, int>()
            {
                {0, 0 },
                {1, 1 }
            };

            Console.WriteLine("Fibonacci numbers with recursive function:");
            for (int i = 0; i < 30; i++)
            {
                Console.Write($"{Fibonacci(i)}, ");
            }

            Console.WriteLine();
            Console.WriteLine("Fibonacci numbers with recursive function with memoization");
            for (int i = 0; i < 30; i++)
            {
                Console.Write($"{FibonacciMemo(i, ref FibNumbers)}, ");
            }
            Console.WriteLine();
            Console.WriteLine("Fibonacci dictionary contains: ");
            foreach(KeyValuePair<int, int> kvp in FibNumbers)
            {
                Console.WriteLine($"key: {kvp.Key} value: {kvp.Value}");
            }

            Console.WriteLine();
            Console.WriteLine("Some palindromes:");
            
            Console.WriteLine($"a is a palindrome? {Palindrome("a")}");
            Console.WriteLine($"ac is a palindrome? {Palindrome("ac")}");
            Console.WriteLine($"bb is a palindrome? {Palindrome("bb")}");
            Console.WriteLine($"cbc is a palindrome? {Palindrome("cbc")}");
            Console.WriteLine($"abba is a palindrome? {Palindrome("abba")}");
            Console.WriteLine($"radar is a palindrome? {Palindrome("radar")}");
            Console.WriteLine($"racecar is a palindrome? {Palindrome("racecar")}");
            Console.WriteLine($"refer is a palindrome? {Palindrome("refer")}");
            Console.WriteLine($"abc is a palindrome? {Palindrome("abc")}");

            Console.WriteLine();
            Console.WriteLine("Some factorial numbers:");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{i} :  {Factorial(i)}");
            }
        }
    }
}
