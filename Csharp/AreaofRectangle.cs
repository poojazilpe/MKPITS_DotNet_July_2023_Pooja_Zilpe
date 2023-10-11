using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOfRect
{
    class Program
    {
        static void Main()
        {
            int length, breadth,area;
            Console.WriteLine("Enter length : ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter breadth : ");
            breadth = Convert.ToInt32(Console.ReadLine());

            area = length * breadth;
            Console.WriteLine("Area of rectangle = " + area);
            Console.ReadKey();
        }
    }
}
