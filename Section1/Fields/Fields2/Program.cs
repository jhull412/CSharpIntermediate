using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields2
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(2);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Promote();
            Console.WriteLine(customer.Orders.Count);
            Console.ReadLine();
        }
    }
}
