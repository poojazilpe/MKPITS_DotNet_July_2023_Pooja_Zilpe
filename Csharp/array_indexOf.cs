using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_indexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int l = Array.IndexOf(arr, 3);
            Console.WriteLine("index of 3  is :" + l);
            Console.ReadKey();

        }
    }
}
