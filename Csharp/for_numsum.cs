using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_numsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            for(int cnt=1;cnt<=5;cnt++)
            {
                Console.WriteLine("Enter no: ");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("Addition of 5 no : {0}",sum);
            Console.ReadKey();
        }
    }
}
