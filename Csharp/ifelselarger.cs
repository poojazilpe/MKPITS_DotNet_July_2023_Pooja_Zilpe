using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelselarger
{
    Internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.WriteLine("Enter no :");
            m = Convert.ToInt32(Console.ReadLine());
            if (m < 0)
            {
                Console.WriteLine("Value of n = -1");
            }
            else if (m == 0)
            {
                Console.WriteLine("Value of n = 0");
            }
            else if(m>0)
            {
                Console.WriteLine("Value of n = 1");
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
            Console.ReadKey();
            
        }
    }
}
