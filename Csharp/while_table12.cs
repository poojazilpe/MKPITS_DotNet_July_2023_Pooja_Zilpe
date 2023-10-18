using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_table1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sn=1, en=2;
            int res1, res2;
            int cnt = 1;
            while (cnt <= 10)
            {
                res1 = sn * cnt;
                res2 = en * cnt;
                Console.Write("{0}*{1}={2}", sn, cnt, res1);
                Console.Write("\t");
                Console.Write("{0}*{1}={2}", en, cnt, res2);
                cnt++;
                Console.WriteLine();
            }
            

            Console.ReadKey();
        }
    }
}
