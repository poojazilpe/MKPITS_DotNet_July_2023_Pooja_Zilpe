using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile_oddsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,sum=0;
            Console.WriteLine("Enter no :");
            num = Convert.ToInt32(Console.ReadLine());
            int cnt = 1;
            do
            {
                if (cnt % 2 != 0)
                {
                    Console.WriteLine(cnt);
                    sum = sum + cnt;
                    
                }
                cnt++;

            } while (cnt <= num);
            Console.WriteLine("add = {0}",sum);
            Console.ReadKey();
        }
    }
}
