using System;

namespace DelegatesAndLambdas
{
    class Program
    {
        public delegate int Calculate(int x, int y);

        public static int Add(int x, int y) { return x + y; }
        public static int Mul(int x, int y) { return x * y; }

        // Use these functions in multicast delegate example below
        public static void MethodOne()
        {
            Console.WriteLine("Method One.");
        }

        public static void MethodTwo()
        {
            Console.WriteLine("Method Two.");
        }

        public delegate void Del();
        static void Main(string[] args)
        {

            Calculate calc = Add;
            Console.WriteLine(calc(3, 4));
            calc = Mul;
            Console.WriteLine(calc(3, 4));

            Console.WriteLine("Use Func");

            Func<int, int, int> calculator;
            calculator = Add;
            Console.WriteLine(calculator(5, 7));
            calculator = Mul;
            Console.WriteLine(calculator(5, 7));

            Console.WriteLine("Use an Action. An action does not have a return value.");
            Action<int, int> writeSum;
            writeSum = (int x, int y) => // This is a lambda function
            {
                Console.WriteLine(x + y);
            };

            writeSum(3, 7);

            Console.WriteLine("Multicast delegate example: ");
            Del d = MethodOne;
            d += MethodTwo;
            d(); // call delegate d after adding two functions to it.

        }
    }
}
