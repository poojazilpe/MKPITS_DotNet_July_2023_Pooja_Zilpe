using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_print10to1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            while(num>0)
            {
                Console.WriteLine(num);
                num--;
            }
            Console.ReadKey();
        }
    }
}
