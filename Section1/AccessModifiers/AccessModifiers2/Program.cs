using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers2
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1985, 2, 2));
            Console.WriteLine(person.GetBirthdate().ToLongDateString());
            Console.ReadLine();
        }
    }
}
