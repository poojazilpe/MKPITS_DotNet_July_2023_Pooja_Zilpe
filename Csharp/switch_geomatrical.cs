using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_geomatrical
{
    class Program
    {
        static void Main(string[] args)
        {
            int r,l,b,side,num;
            float area;
            Console.WriteLine("1.Circle\n2.Rectangle\n3.Square");
            Console.WriteLine("Enter any no (1 to 3):");
            
            num = Convert.ToInt32(Console.ReadLine());

            

              switch (num)
            {
                case 1:
                    Console.WriteLine("Enter radius:");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14f * r * r;
                    Console.WriteLine("Area of Circle = {0}",area);
                    break;

                case 2:
                    Console.WriteLine("Enter length:");
                    l = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter breadth:");
                    b = Convert.ToInt32(Console.ReadLine());
                    area =  l * b;
                    Console.WriteLine("Area of Rectangle = {0}", area);
                    break;

                case 3:
                    Console.WriteLine("Enter side:");
                    side = Convert.ToInt32(Console.ReadLine());
                    area = side*side;
                    Console.WriteLine("Area of Square = {0}", area);
                    break;



            }
            Console.ReadKey();
        }
    }
}
