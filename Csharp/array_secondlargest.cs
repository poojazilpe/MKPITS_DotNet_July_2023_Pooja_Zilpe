using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_secondlargest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int [4];
            Console.WriteLine("Enter number :");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            int n =arr[arr.Length-2];
            Console.WriteLine("second largest element is "+n);
            Console.ReadKey();
        }
    }
}
