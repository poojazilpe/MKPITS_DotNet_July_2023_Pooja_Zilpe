using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.WriteLine("Angle of a :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Angle of b :");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Angle of c :");
            c = Convert.ToInt32(Console.ReadLine());

            if(a==b && b==c)
            {
                Console.WriteLine("triangle is Equilateral");
            }
            else if(a==b || b==c || a==c)
            {
                Console.WriteLine("triangle is Isosceles ");
            }
            else
            {
                Console.WriteLine("triangle is Scalene ");
            }
            Console.ReadKey();

        }
    }
}
