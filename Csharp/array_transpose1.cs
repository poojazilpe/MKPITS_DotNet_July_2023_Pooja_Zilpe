using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arry_transpose1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 2];
           
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("Element [{0}],[{1}] : ", row, col);
                    arr1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Transpose of matrix :");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                  Console.Write("{0}", arr1[col,row] + "\t");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
