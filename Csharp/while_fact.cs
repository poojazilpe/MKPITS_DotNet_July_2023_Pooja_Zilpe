using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_fact
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("Enter no :");
            num = Convert.ToInt32(Console.ReadLine());
            while(num>0)
            {
                fact = fact * num;
                num--;
                
            }
            Console.WriteLine("Factorial = {0}", fact);
            Console.ReadKey();
        }
    }
}
