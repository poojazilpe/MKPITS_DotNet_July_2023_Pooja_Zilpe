using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_calculateRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c, result;
            Console.WriteLine("Enter the value of a :");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b :");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of c :");
            c = Convert.ToInt32(Console.ReadLine());
            result = (b * b) - 4 * a * c;
            if(result!=0)
            {
                Console.WriteLine("Root are imaginary");

            }
            else
            {
                Console.WriteLine("the real Number ");
            }
            Console.ReadKey();
        }
    }
}
