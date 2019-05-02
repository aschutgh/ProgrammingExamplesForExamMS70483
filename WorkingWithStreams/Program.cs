using System;
using System.IO;
using System.Text;

/*
 * source: Programming in C# Exam Ref 70-483
 * Wouter de Kort
 */

namespace WorkingWithStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This only works when directory temp exists!
             * Listing 4-14
             */
            string path = @"c:\temp\test.dat";

            using (FileStream fileStream = File.Create(path))
            {
                string myValue = "MyValue";
                byte[] data = Encoding.UTF8.GetBytes(myValue);
                fileStream.Write(data, 0, data.Length);
            }

            /*
             * Listing 4-15
             */

            string path2 = @"c:\temp\test2.dat";
            // File.CreateText will create a text file with UTF-8 encoding
            using (StreamWriter streamWriter = File.CreateText(path2))
            {
                string myValue = "MyValue";
                streamWriter.Write(myValue);
            }
        }
    }
}
