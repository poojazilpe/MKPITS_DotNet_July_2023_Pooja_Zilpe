using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 20;
            while(num<=30)
            {
                if(num%2!=0)
                {
                    Console.WriteLine(num);
                }
                num++;
            }
            Console.ReadKey();
        }
    }
}
