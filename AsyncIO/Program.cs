using System;
using System.IO;
using System.Threading.Tasks;

/*
 * source: Programming in C# 70-483
 * 
 */

namespace AsyncIO
{
    class Program
    {
        /*
         * Listing 4-23
         */
        public static async Task CreateAndWriteAsyncToFile()
        {
            using (FileStream stream = new FileStream(@"c:\temp\asyncIOtest.dat", FileMode.Create, FileAccess.Write,
                FileShare.None, 4096, true))
            {
                byte[] data = new byte[100000];
                new Random().NextBytes(data);

                await stream.WriteAsync(data, 0, data.Length);

            }
        }
        static async Task Main(string[] args)
        {
            await CreateAndWriteAsyncToFile();
            
        }
    }
}
