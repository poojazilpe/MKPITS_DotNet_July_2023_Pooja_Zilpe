using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while.prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter=2;
            int flag = 0;
            Console.WriteLine("Enter no");
            num = Convert.ToInt32(Console.ReadLine());
            while (counter < num)
            {
                if (num % counter == 0)
                {
                    flag = 1;

                    break;
                }
                counter++;
            }
                if(flag==0)
                {
                    Console.WriteLine(" prime");
                }
                else
                {
                    Console.WriteLine("  not prime");
                    
                }
            
            Console.ReadKey();

        }
    }
}
