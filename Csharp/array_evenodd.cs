using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_evenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
           
            for (int cnt = 0; cnt < 5; cnt++)
            {
                Console.Write("Enter Element {0}- ", cnt);
                arr[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Even No. : ");
            for (int cnt = 0; cnt < 5; cnt++)
            {
                if (arr[cnt] % 2 == 0)
                {
                    Console.Write("{0}, ", arr[cnt]);
                }
            }   
            Console.WriteLine("Odd No. : ");
            for (int cnt = 0; cnt < 5; cnt++)
            {
                 if (arr[cnt] % 2 != 0)
                 {
                    Console.Write("{0}, ", arr[cnt]);
                 }
                
            }

            
            
            Console.ReadKey();
        }
    }
}
