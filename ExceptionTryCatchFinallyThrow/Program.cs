using System;

/*
 * Add exception handling
 * use the following:
 * try / catch
 * try / catch / finally
 * try / finally
 * throw keyword
 */

namespace ExceptionTryCatchFinallyThrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[5] { 37, 36, 35, 34, 33 };
            //Console.WriteLine(Numbers[6]);

            try
            {
                Console.WriteLine(Numbers[6]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.GetType());
            }
            finally
            {
                Console.WriteLine(Numbers[Numbers.Length - 1]);
            }

            Console.WriteLine("Rethrow an exception");
            void PrintArray(int[] numbers, int index)
            {
                try
                {
                    Console.WriteLine(numbers[index]);
                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("I can't handle this.");
                    throw; // Comment this line and the catch block below will not execute.
                }
                
            }

            try
            {
                PrintArray(Numbers, 6);
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Index was to large!");
            }

        }
    }
}
