using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_tablen
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cnt = 1;
            int cnt1 = 1;
            Console.WriteLine("Enter no ");
            num = Convert.ToInt32(Console.ReadLine());
            while(cnt<=10)
            {
                cnt1 = 1;
                while(cnt1<=num)
                {
                    Console.Write("{0}*{1}={2}", cnt1, cnt, (cnt1 * cnt));
                    Console.Write("\t");
                    cnt1++;

                }
                cnt++;
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
    }
}
