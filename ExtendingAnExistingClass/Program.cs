using System;
using System.Collections.Generic;

/*
 * Derive a new class from an existing class
 * Add or override methods
 * 
 */


namespace ExtendingAnExistingClass
{
    public class UniqueList<T> : List<T>
    {
        public void RemoveDuplicates()
        {
            base.Sort(); // call base class method
            for (int i = this.Count - 1; i > 0; i--)
            {
                if (this[i].Equals(this[i - 1]))
                    this.RemoveAt(i);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ul = new UniqueList<int>();
            ul.Add(3);
            ul.Add(1);
            ul.Add(2);
            ul.Add(3);
            ul.Add(3);
            foreach(int i in ul)
            {
                Console.Write($"{i} ");
            }
            ul.RemoveDuplicates();
            Console.WriteLine();
            Console.WriteLine("After removing duplicates:");
            foreach (int i in ul)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
