using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_class_method_company
{
    class Company
    {
        public string name = "fendahl";
        public void display()
        {
            Console.WriteLine("Company Name :" + name);
        }
    }
    class franchies : Company
    {
        public string name = "MKPITS";
        public void display()
        {
            base.display();
            Console.WriteLine("Company Name :" + name);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            franchies f = new franchies();
            f.display();
            Console.ReadKey();
        }
    }
}
