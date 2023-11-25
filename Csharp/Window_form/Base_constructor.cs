using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_constructor
{
    class Company
    {
        public string name = "fendahl";
        public Company()
        {
            Console.WriteLine("Base class constructor");
            Console.WriteLine("Company Name :" + name);
        }
    }
    
    class franchies : Company
    {
        public string name = "MKPITS";
        public franchies()
        {

            Console.WriteLine("Derive class constructor");

            Console.WriteLine("Company Name :" + name);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            franchies f = new franchies();
            Console.ReadKey();

        }
    }
}
