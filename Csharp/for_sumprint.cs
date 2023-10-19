using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_sumprint
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int num = 1; num <= 10; num++)
            {
                Console.WriteLine("natural no = {0}", num);
                sum = sum + num;
            }
            Console.WriteLine("Addition is = {0}", sum);
            Console.ReadKey();
        }
    }
}
