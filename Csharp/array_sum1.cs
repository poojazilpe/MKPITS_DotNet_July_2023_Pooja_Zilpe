using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Number :");
                num[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + num[i];
            }
            Console.Write("Sum :"+sum);

            Console.ReadKey();
        }
    }
}
