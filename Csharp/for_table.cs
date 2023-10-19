using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter no :");
            num = Convert.ToInt32(Console.ReadLine());
            for(int cnt=1;cnt<=10;cnt++)
            {
                Console.WriteLine("{0}*{1}={2}", num, cnt, (num * cnt));

            }
            Console.ReadKey();
        }
    }
}
