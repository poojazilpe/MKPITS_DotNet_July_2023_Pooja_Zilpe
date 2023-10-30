using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_getlength
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int l = arr.GetLength(0);
            Console.WriteLine("length" + l);
            Console.ReadKey();

        }
    }
}
