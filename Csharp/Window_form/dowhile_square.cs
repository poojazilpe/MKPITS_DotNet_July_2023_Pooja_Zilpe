using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_whilesquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,square;
            char choice = 'y';
            do
            {
                Console.WriteLine("Enter num :");
                num = Convert.ToInt32(Console.ReadLine());
                square = num * num;
                Console.WriteLine("Square= {0}",square);
                Console.WriteLine("Enter key y or n:");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'y' || choice == 'Y');
            
            Console.ReadKey();
        }
    }
}
