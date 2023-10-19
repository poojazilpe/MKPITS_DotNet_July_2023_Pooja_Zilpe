using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_tablen
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cnt1 = 1;
            Console.WriteLine("Enter no : ");
            num = Convert.ToInt32(Console.ReadLine());
            for(int cnt=1;cnt<=10;cnt++)
            {
                
                for(cnt1=1;cnt1<= num;cnt1++)
                {
                    
                    Console.Write("{0}*{1}={2}", cnt1, cnt, (cnt1 * cnt));
                    Console.Write("\t");
                    


                }
                
                Console.WriteLine();

            }
            Console.ReadKey();

        }
    }
}
