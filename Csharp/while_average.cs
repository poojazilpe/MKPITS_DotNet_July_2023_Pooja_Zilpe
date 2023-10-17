//Write a C# Sharp program to read 10 numbers and find their average and sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_average
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=1,sum=0;
            float avg;
            
            while(num<=10)
            {
                Console.WriteLine(num);
                sum = sum + num;
                num++;
            }
            Console.WriteLine("sum={0}", sum);
            avg = sum / 10.0f;
            Console.WriteLine("Average={0}", avg);
            Console.ReadKey();
        }
    }
}
