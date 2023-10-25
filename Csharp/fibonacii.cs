using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_power
{
    class Program
    {
        static int calculate(int num)

        {
           
            
            int num1 = 0;
            int num2 = 1;
            int add =1;
            Console.WriteLine("Fibinacii :{0},{1}",num1,num2);
            for (int cnt = 3; cnt <= num; cnt++)
            {
                num1 = num2;
                num2 = add;
               
                Console.WriteLine("{0}",add);
                add = num1 + num2;
            }
            
            return add;

            
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter no :");
            number = Convert.ToInt32(Console.ReadLine());
            int result = calculate(number);
            Console.ReadKey();

        }
    }
}
