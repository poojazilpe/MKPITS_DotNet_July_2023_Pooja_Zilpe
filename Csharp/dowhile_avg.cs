using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile_avg
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            float avg;
            do
            {
                Console.WriteLine(num);
                sum = sum + num;
                num++;
                avg = sum / 10.0f;
            } while (num <= 10);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", avg);
            Console.ReadKey();
        }
    }
}
