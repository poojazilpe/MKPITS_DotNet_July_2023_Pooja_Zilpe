using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_Circle
{
    class Program
    {
        static void display(ref int radius, ref float area,ref float circ)
        {
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius = 5;
            float area = 0, circ = 0;
            display(ref radius, ref area, ref circ);
            Console.WriteLine("Area = " + area);
            Console.WriteLine("Circumferance of circle :" + circ);
            Console.ReadKey();

        }
    }
}
