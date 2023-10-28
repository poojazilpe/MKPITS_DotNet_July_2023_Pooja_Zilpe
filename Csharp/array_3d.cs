using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_3d
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];

            Console.WriteLine("Input elements in the matrix :");
            for (int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write("Element-[{0}],[{1}]: ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Output elements in the matrix :");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}",arr[i,j]+"\t");
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
