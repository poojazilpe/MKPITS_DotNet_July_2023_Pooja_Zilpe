using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, c,profit,loss;
            Console.WriteLine("Enter Selling price :");
            s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter cost price:");
            c = Convert.ToInt32(Console.ReadLine());

            profit = s - c;
            loss = c - s;
            if(s>c)
            {
                Console.WriteLine("You can book your profit amount {0}", profit);
            }
            else
            {
                Console.WriteLine("You can book your loss amount {0}", loss);
            }
            Console.ReadKey();
        }
    }
}
