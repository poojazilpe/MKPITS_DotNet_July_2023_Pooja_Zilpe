using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forprime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            int flag = 0;
            int cnt = 2;
            Console.WriteLine("2");
            for ( num=3;num<=20;num++)
            {
                    flag = 0;
                    cnt = 2;
                    for (cnt=2; cnt<num; cnt++)
                {
                    if(num%cnt==0)
                    {
                        flag = 1;
                        break;
                    }

                }
                if (flag == 0)
                {
                    Console.WriteLine(num);
                }

            }
            
            Console.ReadKey();
        }
    }
}
