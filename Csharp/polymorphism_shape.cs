using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_shape
{
    class shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing......");
        }
    }
    class rectangle: shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Rectangle......");
        }
    }
    class Circle :shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle......");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            shape s;
            s = new shape();
            s.draw();
            s = new rectangle();
            s.draw();
            s = new Circle();
            s.draw();
            Console.ReadKey();

        }
    }
}
