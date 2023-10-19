using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedfor_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int cnt = 1; cnt <= 3; cnt++)
            {
                for (int cnt1 = 1; cnt1 <= cnt; cnt1++)
                {
                    Console.Write("* \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
