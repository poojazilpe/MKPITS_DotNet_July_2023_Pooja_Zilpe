using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_table
{
    class Program
    {
        static int calculate(int num)
        {
            int result=0;
            int cnt = 1;
            while(cnt<=10)
            {
                result = num * cnt;
                Console.WriteLine(num + "*" + cnt + "=" + result + "\n");
                cnt++;
            }

            return result;
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter no :");
            number = Convert.ToInt32(Console.ReadLine());
            int res = calculate(number);
            
            Console.ReadKey();
        }
    }
}
