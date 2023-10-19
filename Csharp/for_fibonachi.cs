using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num1=0;
            int num2 = 1;
            int add = 0;
            Console.WriteLine("Enter no :");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("0");
            for (int cnt=3;cnt<=num;cnt++)
            {
                num1 = num2;
                num2 = add;
                add = num1 + num2;
                Console.WriteLine(add);
            }
            
            Console.ReadKey();
        }
    }
}
