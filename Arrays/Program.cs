using System;

/*
 * - single dimensional arrays
 * - multidimensional arrays
 * - jagged arrays
 * 
 * source: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
 * 
 */

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a single-dimensional array 
            int[] array1 = new int[5];

            // Declare and set array element values
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            foreach(int i in array2)
            {
                Console.Write($"{i} ");
            }

            // Alternative syntax
            int[] array3 = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine();
            foreach (int i in array3)
            {
                Console.Write($"{i} ");
            }

            // Declare a two dimensional array
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Declare a jagged array
            int[][] jaggedArray = new int[6][]; // specify the number of arrays you want in a jagged array

            // Set the values of the first array in the jagged array structure
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
        }
    }
}
