using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

/*
 * source: Programming in C# Exam Ref 70-483 by Wouter de Kort
 * 
 */

namespace StringManipulation
{
    class Person
    {
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // This gives an error. Strings in C# are immutable.
            //string SomeText = "Some text";
            //SomeText[0] = 'N';

            // Strings of type StringBuilder are mutalbe.
            StringBuilder sb = new StringBuilder("Some text");
            Console.WriteLine(sb);
            sb[0] = 'N';
            Console.WriteLine(sb);

            var stringWriter = new StringWriter();
            // using statement: Provides a convenient syntax that ensures the correct use of IDisposable objects.
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }
            string xml = stringWriter.ToString();
            Console.WriteLine(xml);

            var stringReader = new StringReader(xml);
            
            using (XmlReader reader = XmlReader.Create(stringReader))
            {
                reader.ReadToFollowing("price");
                decimal price = decimal.Parse(reader.ReadInnerXml(), new CultureInfo("en-US"));
                Console.WriteLine(price);
            }

            string value = "My Sample Value";
            int indexOfp = value.IndexOf('p');
            int lastIndexOfm = value.LastIndexOf('m');
            Console.WriteLine($"indexOfp is {indexOfp} lastIndexOfm is {lastIndexOfm}");

            string value1 = "<mycustominput>";
            Console.WriteLine(value1.StartsWith('<'));
            Console.WriteLine(value1.EndsWith('>'));

            string value2 = "My Sample Value";
            string subString = value2.Substring(3, 6);
            Console.WriteLine(subString);

            string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
            string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels", "Abraham Adams", "Ms. Nicole Norris" };

            foreach (string name in names)
                Console.WriteLine(Regex.Replace(name, pattern, String.Empty));

            string value3 = "My Custom Value";
            foreach (char c in value3)
                Console.WriteLine(c);

            Person p = new Person("John", "Doe");
            Console.WriteLine(p);

            double cost = 1234.56;
            Console.WriteLine(cost.ToString("C", new CultureInfo("en-US")));

            DateTime d = new DateTime(2013, 4, 22);
            CultureInfo provider = new CultureInfo("en-US");
            Console.WriteLine(d.ToString("d", provider));
            Console.WriteLine(d.ToString("D", provider));
            Console.WriteLine(d.ToString("M", provider));
        }
    }
}