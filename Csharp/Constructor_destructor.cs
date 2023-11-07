using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_destructor
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Constructor called ");
        }
        ~ Employee()
        {
            Console.WriteLine("Destructor called ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Console.ReadKey();
            Employee e1 = new Employee();
            Console.ReadKey();

        }
    }
}
