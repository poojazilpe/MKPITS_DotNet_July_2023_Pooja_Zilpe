


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cnt = 3, sum=0;
            Console.WriteLine("Enter no: ");
            num = Convert.ToInt32(Console.ReadLine());
            int num1 = 0;
            int num2 = 1;
            Console.WriteLine("{0}", num1);
            while(cnt<=num)
            {
                
                num1 = num2;
                num2 = sum;
                sum = num1 + num2;
                
                Console.WriteLine("{0}",sum);
                cnt++;


            }

            Console.ReadKey();
        }
    }
}
