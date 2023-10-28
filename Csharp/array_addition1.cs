using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_addition1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            int[,] arr3 = new int[2, 2];
            Console.WriteLine("Enter 1 matrix :");
            for (int row=0;row<2;row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("Element [{0}],[{1}] : ", row, col);
                    arr1[row, col] = Convert.ToInt32(Console.ReadLine());
                }    
            }
            Console.WriteLine("Enter 2 matrix :");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("Element [{0}],[{1}] : ", row, col);
                    arr2[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Addition of 2 matrix :");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    arr3[row, col] = arr1[row, col] + arr2[row, col];
                    Console.Write("{0}", arr3[row,col]+"\t");
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
