using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Order : IComparable
    {
        public DateTime Created { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Order o = obj as Order;

            if (o == null)
            {
                throw new ArgumentException("Object is not an Order");
            }

            // Created is of type DateTime. DateTime objects are already comparable.
            return this.Created.CompareTo(o.Created);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
            {
                new Order { Created = new DateTime(2012, 12, 1 )},
                new Order { Created = new DateTime(2012, 1, 6 )},
                new Order { Created = new DateTime(2012, 7, 8 )},
                new Order { Created = new DateTime(2012, 2, 20 )},
            };
            foreach (Order order in orders)
            {
                Console.WriteLine(order.Created);
            }
            orders.Sort();
            Console.WriteLine("After sort: ");
            foreach (Order order in orders)
            {
                Console.WriteLine(order.Created);
            }
        }
    }
}
