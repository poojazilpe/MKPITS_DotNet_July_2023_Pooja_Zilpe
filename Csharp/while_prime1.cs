using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_prime1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int cnt = 0;
            
            while(num<=20)
            {

                if(num%cnt==0)
                {
                    flag = 1;
                    break;
                }
                num++;
            }
            if(flag==0)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
