using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile_table1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,cnt=1;
            Console.WriteLine("Enter num :");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("{0}*{1}={2}", num, cnt, (num * cnt));
                cnt++;
            } while (cnt <= 10);
            Console.ReadKey();
        }
    }
}
