i7using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Enter Temperature :");
            temp = Convert.ToInt32(Console.ReadLine());
            if(temp<0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if(temp>=0 && temp<=10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temp >= 10 && temp <= 20)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temp >= 20 && temp <= 30)
            {
                Console.WriteLine("Normal in Temp");
            }
            else if (temp >= 30 && temp <= 40)
            {
                Console.WriteLine("Its Hot");
            }
            else if (temp >= 0)
            {
                Console.WriteLine("Its Very Hot");
            }
            else
            {
                Console.WriteLine("Invalid Temperature");
            }
            Console.ReadKey();


        }
    }
}
