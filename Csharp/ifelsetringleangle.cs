using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelsetriangleangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Angle of a :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Angle of b :");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Angle of c :");
            c = Convert.ToInt32(Console.ReadLine());
            if(a + b + c==180)
            {
                Console.WriteLine("The triangle is valid.");
            }
            else
            {
                Console.WriteLine("The triangle not  is valid.");
            }
            Console.ReadKey();
        }
    }
}
