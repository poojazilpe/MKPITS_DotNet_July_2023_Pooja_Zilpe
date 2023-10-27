using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for (int i = 0; i < 10; i++) 
            {
                Console.Write("Enter number");
               num[i]= Convert.ToInt32(Console.ReadLine());
                
            }
            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine("Element: {0}-{1}", i, num[i]);
            }
            Console.Write("Element in an array are :");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}", num[i]);


            }
            Console.ReadKey();
        }
    }
}
