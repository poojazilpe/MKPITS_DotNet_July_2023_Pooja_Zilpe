using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_copyelement
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] arr1 = new int[3];
            int[] arr2= new int[3];
            for( i=0;i<3;i++)
            {
                Console.WriteLine("Enter Number :");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                arr2[i] = arr1[i];
            }
            
            Console.WriteLine("The elements copied into the second array are  :");
            for (i = 0; i < 3; i++)
            {
                
                Console.Write("{0}",arr2[i]);
                
            }
            Console.ReadKey();
        }
    }
}
