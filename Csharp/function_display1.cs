using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_display1
{
    class Program
    {
        static void display()
        {
            string name;

            Console.WriteLine("Enter name :");
            name = Console.ReadLine();
            Console.WriteLine("Welcome friend "+name);
            Console.WriteLine("Have a nice day!");


        }
        static void Main(string[] args)
        {
            display();
            Console.ReadKey();
        }
    }
}
