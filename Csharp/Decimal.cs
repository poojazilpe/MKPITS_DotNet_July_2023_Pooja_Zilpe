using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a;
            Console.Write("Enter Number : ");
            a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Decimal = " + a);
            Console.ReadKey();
        }
    }
}
