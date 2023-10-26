using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_power
{
    class Program
    {
        static void calculate(int num,int pow)
        {
            int result = 1;
            for(int i=1;i<=pow;i++)
            {
                result = result * num;
                
            }
            Console.WriteLine("Result = " + result);
        }
        static void Main(string[] args)
        {
            int number, power;
            Console.WriteLine("Enter number : ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter power : ");
            power = Convert.ToInt32(Console.ReadLine());
            calculate(number,power);
            Console.ReadKey();
        }
    }
}
