using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding_Animal
{
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating.... ");
        }
    }
    class dog:Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread.... ");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal d = new dog();
            d.eat();
            Console.ReadKey();
        }
    }
}
