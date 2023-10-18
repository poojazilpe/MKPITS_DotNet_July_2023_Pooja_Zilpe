using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            int cnt = 2;
            int flag = 0;
            do
            {
                cnt = 2;
                flag = 0;
                while(num>cnt)
                {
                    if(num%cnt==0)
                    {
                        flag = 1;
                        break;
                    }
                    cnt++;
                }
                if(flag==0)
                {
                    Console.WriteLine(num);
                }
                num++;

            } while (num<=20);
            Console.ReadKey();
        }
    }
}
