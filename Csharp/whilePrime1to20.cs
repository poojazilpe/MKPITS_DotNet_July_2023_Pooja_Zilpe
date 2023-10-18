using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_prime1to20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers between 1 and 20 : ");
            Console.WriteLine("Prime no : 2");
            int num = 3, cnt = 2, flag = 0;
            while(num<=20)
            {
                cnt = 2;
                flag = 0;
                while (cnt<num)
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
            }
            
            

            Console.ReadKey();
        }
    }
}
