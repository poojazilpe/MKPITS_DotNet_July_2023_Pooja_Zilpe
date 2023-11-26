using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_inheritance_circle
{
    interface Idrawable
    {
        void draw();
    }
    class circle : Idrawable
    {
        public void draw()
        {
            Console.WriteLine("Circle drawing..");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Idrawable d = new circle();
            d.draw();
            Console.ReadKey();

        }
    }
}
