using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class_method
{
    class animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating....");
        }
        public virtual void run()
        {
            Console.WriteLine("Running....");
        }
    }
    class dog:animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread....");
        }
        public sealed override void run()
        {
            Console.WriteLine("Running fast....");
        }

    }
    class babydog : dog
    {
        public override void eat()
        {
            Console.WriteLine("Eating biscuit....");
        }
        public  override void run()
        {
            Console.WriteLine("Running slowly....");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            babydog b = new babydog();
            b.eat();
            b.run();
            Console.ReadKey();
        }
    }
}
