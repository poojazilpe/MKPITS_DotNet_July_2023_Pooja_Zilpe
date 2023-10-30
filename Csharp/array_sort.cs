using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 2 };
            Array.Sort(arr);
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
