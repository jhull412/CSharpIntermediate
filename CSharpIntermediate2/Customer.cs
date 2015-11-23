using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate2
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        // These 2 additional constructors are probably more confusing than useful.  Provided here as an example only.

        // when this Customer(int id) is called, it first calls Custormer()
        public Customer(int id)
            :this()
        {
            this.Id = id;
        }
        // when this Customer(int id, string name) is called, it first calls Custormer(int id) -> which actually calls Customer() before that!
        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }
    }
}
