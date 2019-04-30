using System;
using System.IO;
using System.Net;

/*
 * Source: Programming in C# Exam ref 70-483
 * Wouter de Kort
 */

namespace GetWebsite
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("http://www.microsoft.com/");
            WebResponse response = request.GetResponse();

            StreamReader responseStream = new StreamReader(response.GetResponseStream());
            string responseText = responseStream.ReadToEnd();

            Console.WriteLine(responseText);
            response.Close();
        }
    }
}
