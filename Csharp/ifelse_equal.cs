using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseequal
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter no 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine("Number are equal");
            else
                Console.WriteLine("Number are not equal");
            Console.ReadKey();

        }
    }
}
