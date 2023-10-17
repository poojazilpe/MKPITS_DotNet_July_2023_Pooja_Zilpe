//Write a program in C# Sharp to display the multiplication table of a given integer.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_table1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cnt = 1,result;
            Console.WriteLine("Enter no :");
            num = Convert.ToInt32(Console.ReadLine());
            while(cnt<=10)
            {
                result = num * cnt;
                Console.WriteLine("{0}*{1}={2}",num,cnt,result);
                cnt++;
            }
            Console.ReadKey();
        }
    }
}
