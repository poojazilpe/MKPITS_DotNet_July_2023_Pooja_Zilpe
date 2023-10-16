using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseGeomatrical
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, l, b, side,choice;
            float area;
            Console.WriteLine("Enter choice any no. (1 to 3) :");
            Console.WriteLine("1.Circle\n2.Rectangle\n3.Square");
            choice = Convert.ToInt32(Console.ReadLine());



            if (choice == 1)
            {
                Console.WriteLine("Enter radius :");
                r= Convert.ToInt32(Console.ReadLine());
                area = 3.14f * r * r;
                Console.WriteLine("Area of circle is: {0}", area);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter length :");
                l = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter breath :");
                b = Convert.ToInt32(Console.ReadLine());
                area = l*b;
                Console.WriteLine("Area of rectangle is: {0}", area);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter side :");
                side = Convert.ToInt32(Console.ReadLine());
                area = side * side;
                Console.WriteLine("Area of Square is: {0}", area);
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            Console.ReadKey();
        }
    }
}
