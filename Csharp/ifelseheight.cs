using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseheight
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            Console.WriteLine("Enter height :");
            height = Convert.ToInt32(Console.ReadLine());
            if (height <= 150)
            {
                Console.WriteLine("The person's height is Dwarf.");
            }
            else if (height >= 165 && height <= 150)
            {
                Console.WriteLine("The person's height is average.");
            }
            else if (height >= 165 && height <= 195)

            {
                Console.WriteLine("The person's height is Tall.");
            }
            else
            {
                Console.WriteLine("The person's hright is Abnormal.");
            }

                
            
            Console.ReadKey();
        }
    }
}
