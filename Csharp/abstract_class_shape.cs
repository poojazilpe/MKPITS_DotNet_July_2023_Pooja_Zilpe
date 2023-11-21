using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstact_class_shape
{
    abstract class shape
    {
        public abstract void draw();
    }
    class rectangle : shape
    {
        public override void draw()
        {
            Console.WriteLine("rectangle....");
        }
    }
    class circle : shape
    {
        public override void draw()
        {
            Console.WriteLine("circle....");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            shape s = new rectangle();
            s.draw();
            s = new circle();
            s.draw();
            Console.ReadKey();

               
        }
    }
}
