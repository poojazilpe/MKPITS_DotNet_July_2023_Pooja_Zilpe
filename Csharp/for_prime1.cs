using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int flag = 0;
            Console.WriteLine("Enter no :");
            num = Convert.ToInt32(Console.ReadLine());
            for (int cnt = 2; cnt < num; cnt++)
            {
                
                if (num % cnt == 0)
                {
                    flag = 1;
                    break;
                }
            }
                if(flag==0)
                {
                    Console.WriteLine("prime no");
                }
                else
                {
                    Console.WriteLine(" not prime no");
                }
            Console.ReadKey();
        }
    }
}
