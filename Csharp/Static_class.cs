using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_class
{
    static class Math
    {
        public static float pi = 3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value of PI : " + Math.pi);
            Console.WriteLine("Value of Cube : " + Math.cube(3));
            Console.ReadKey();

        }
    }
}
