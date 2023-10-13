using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelsequadrant
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter the value x cordinate :");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value y cordinate :");
            y = Convert.ToInt32(Console.ReadLine());

            if(x>0 && y>0)
            {
                Console.WriteLine("The coordinate point {0},{1} lies in the First quadrant.", x, y);
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The coordinate point {0},{1} lies in the Second quadrant.", x, y);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The coordinate point {0},{1} lies in the Third quadrant.", x, y);
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The coordinate point {0},{1} lies in the Fourth quadrant.", x, y);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();
        }
    }
   }

