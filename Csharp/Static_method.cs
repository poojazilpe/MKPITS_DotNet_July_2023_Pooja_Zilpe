using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_method
{
    class Program
    {
        static void display()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            display();
            Console.ReadKey();
        }
    }
}
