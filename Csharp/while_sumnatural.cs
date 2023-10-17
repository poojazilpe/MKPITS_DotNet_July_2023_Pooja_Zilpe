//Write a C# Sharp program that displays the sum of n natural numbers.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_sumnatural

{
    class Program
    {
        static void Main(string[] args)
        {
            int num,cnt=1,sum=0;
            Console.WriteLine("Enter number :");
            num = Convert.ToInt32(Console.ReadLine());
            while(cnt<=num)
            {
                Console.WriteLine(cnt);
                sum = sum + cnt;
                cnt++;
            }
            Console.WriteLine("sum = {0}", sum);
            Console.ReadKey();
        }
    }
}
