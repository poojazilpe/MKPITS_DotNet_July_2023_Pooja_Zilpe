using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_fact
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("Enter no : ");
            num = Convert.ToInt32(Console.ReadLine());
            for(int cnt=num;cnt>0;cnt--)
            {
                fact = fact * cnt;
                

            }
            Console.WriteLine("factorial ={0}", fact);
            Console.ReadKey();
        }
    }
}
