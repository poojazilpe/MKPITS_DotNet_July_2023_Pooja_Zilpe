using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_avg
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, cnt;
            float avg=0;
            Console.WriteLine("Enter no ");
            cnt = Convert.ToInt32(Console.ReadLine());
            for (int num = 1; num <= cnt; num++)
            {
                Console.WriteLine(num);
                sum = sum + num;
                avg = sum / 10.0f;
            }
            Console.WriteLine("Addition is = {0}", sum);
            Console.WriteLine("Average is = {0}", avg);
            Console.ReadKey();
        }
    }
}
