using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functon_3parareturn
{
    class Program
    {
        static int calculate(int num1,int num2, char op)
        {
            int res = 0;
            if(op=='+')
            {
                res = num1 + num2;
            }
            else if (op == '-')
            {
                res = num1 - num2;
            }
            else if (op == '*')
            {
                res = num1 * num2;
            }
            return res;
        }

        static void Main(string[] args)
        {
            int number1,number2;
            char oper;
            Console.WriteLine("Enter no 1 : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no 2 : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any +,-,*");
            oper = Convert.ToChar(Console.ReadLine());

            int result = calculate(number1, number2, oper);
            Console.WriteLine("Result = "+result);
            Console.ReadKey();


        }
    }
}
