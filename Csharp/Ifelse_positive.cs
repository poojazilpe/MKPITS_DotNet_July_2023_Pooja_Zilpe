using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElsepositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter no :");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
                Console.WriteLine("Number is Positive ");
            else
                Console.WriteLine("Number is Negative ");
            Console.ReadKey();
        }
    }
}
