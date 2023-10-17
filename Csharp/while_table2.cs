using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_table2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cnt = 1, cnt1 = 1, result;
            Console.WriteLine("Enter no :");
            num = Convert.ToInt32(Console.ReadLine());
            while(num!=0)
            {
                if (cnt <= 10)
                {
                    result = cnt1 * cnt;
                    Console.WriteLine("{0}*{1}={2}", cnt1, cnt, result);

                }
                cnt++;
                
            }
            Console.ReadKey();
        }
    }
}
