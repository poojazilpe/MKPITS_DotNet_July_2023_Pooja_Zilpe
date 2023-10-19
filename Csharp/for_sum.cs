using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0,cnt;
            Console.WriteLine("Enter no ");
            cnt = Convert.ToInt32(Console.ReadLine());
            for (int num = 1; num <= cnt; num++)
            {
                Console.WriteLine(num);
                sum = sum + num;
            }
            Console.WriteLine("Addition is = {0}", sum);
            Console.ReadKey();
        }
    }
}
