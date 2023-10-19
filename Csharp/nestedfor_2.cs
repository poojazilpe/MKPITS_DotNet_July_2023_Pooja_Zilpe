using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedfor_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int cnt=1;cnt<=3; cnt++)
            {
                for (int cnt1 = 1; cnt1 <= 3; cnt1++)
                {
                    Console.Write(cnt1 + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
