using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_baseclass_childclass
{
    class baseclass
    {
        public virtual void show()
        {
            Console.WriteLine("hello from base class show method");
        }
    }
    class childclass : baseclass
    {
        public override void show()
        {
            Console.WriteLine("hello from child class show method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            baseclass b = new childclass();
            b.show();
            Console.ReadKey();
        }
    }
}
