using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_prime
{
    class Program
    {
        static int check(int num)
        {
            int result = 0;
            int flag = 0;
            int cnt = 2;
            while (num > cnt)
            {
                if (num % cnt == 0)
                {
                    flag = 1;
                    break;
                }
                cnt++;

            }
            if (flag == 0)
            {
                Console.WriteLine("Prime no ");

            }
            else
            {
                Console.WriteLine(" not Prime no ");
            }
            return result;
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter no :");
            number = Convert.ToInt32(Console.ReadLine());
            int res = check(number);
            Console.ReadKey();

        }
    }
}
