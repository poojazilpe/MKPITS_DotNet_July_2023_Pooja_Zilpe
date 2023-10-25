using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_swap
{
    class Program
    {
        static int swap(int num1,int num2)
        {
            int res =0;
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("after swap : {0} , {1} " + num1 + num2);
            return res;

        }
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Enter no 1 : ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no 2 : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            int result = swap(number1, number2);
            
            Console.ReadKey();

        }
    }
}
