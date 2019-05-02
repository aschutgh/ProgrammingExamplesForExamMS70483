using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Linq;

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

            /*
             * Listing 4-16
             */

            string path3 = @"c:\temp\test2.dat";

            using (FileStream fileStream = File.OpenRead(path3))
            {
                byte[] data = new byte[fileStream.Length];

                for(int index = 0; index < fileStream.Length; index++)
                {
                    data[index] = (byte)fileStream.ReadByte();
                }
                Console.WriteLine(Encoding.UTF8.GetString(data));
            }

            /*
             * Listing 4-17
             * 
             * When reading a text file you can also use StreamReader
             */

            string path4 = @"c:\temp\test2.dat";

            using (StreamReader streamReader = File.OpenText(path4))
            {
                Console.WriteLine(streamReader.ReadLine());
            }

            /*
             * Listing 4-18
             * 
             */

            string folder = @"c:\temp";
            string uncompressedFilePath = Path.Combine(folder, "uncompressed.dat");
            string compressedFilePath = Path.Combine(folder, "compressed.gz");

            byte[] dataToCompress = Enumerable.Repeat((byte)'a', 1024 * 1024).ToArray();

            using (FileStream uncompressedFileStream = File.Create(uncompressedFilePath))
            {
                uncompressedFileStream.Write(dataToCompress, 0, dataToCompress.Length);
            }

            using (FileStream compressedFileStream = File.Create(compressedFilePath))
            {
                using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                {
                    compressionStream.Write(dataToCompress, 0, dataToCompress.Length);
                }
            }

            FileInfo uncompressedFile = new FileInfo(uncompressedFilePath);
            FileInfo compressedFile = new FileInfo(compressedFilePath);

            Console.WriteLine(uncompressedFile.Length);
            Console.WriteLine(compressedFile.Length);


        }
    }
}
