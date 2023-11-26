using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_shape
{
    interface shape
    {
        void draw();
    }
    class rectangle : shape
    {
        public void draw()
        {
            Console.WriteLine("draw shape rectangle");
        }
    }
    class circle : shape
    {
        public void draw()
        {
            Console.WriteLine("draw shape circle");
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
