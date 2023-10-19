using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_odd1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cnt = 1, sum = 1,add=0;
            Console.WriteLine("Enter no :");
            num = Convert.ToInt32(Console.ReadLine());
            while(true)
            {
                if(sum<=num)
                {
                    if(cnt%2!=0)
                    {
                        Console.WriteLine("Odd no is :{0}", cnt);
                        sum = sum + 1;
                        add = add + num;
                    }
                }
                else
                {
                    break;
                }
                cnt++;
                
                
            }
            Console.WriteLine("Addition is :{0}", add);
            Console.ReadKey();
        }
    }
}
