using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelsegreater
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter no 1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("Greater no is : {0}", num1);
            else
                Console.WriteLine("Greater no is : {1}", num2);
            Console.ReadKey();



        }
    }
}
