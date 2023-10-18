using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile_sumnum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            do
            {
                Console.WriteLine(num);
                sum = sum + num;
                num++;
            } while (num <= 10);
            Console.WriteLine("Sum = {0}",sum);
            Console.ReadKey();
        }
    }
}
