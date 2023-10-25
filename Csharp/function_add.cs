using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_add
{
    class Program
    {
        static int add(int num1, int num2)
        {
            int res = 0;
                res = num1 + num2;
            return res;
        }
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Enter no 1 :");
                number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no 2 :");
                number2 = Convert.ToInt32(Console.ReadLine());
            int result = add(number1, number2);
            Console.WriteLine("Addition of 2 nos : "+result);
            Console.ReadKey();

        }
    }
}
