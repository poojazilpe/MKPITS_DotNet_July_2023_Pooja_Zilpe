using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int sum = 0;
            //displaying array using foreach loop
            Console.WriteLine("Enter no :");
            foreach (int val in arr)
            {
                arr[val] = Convert.ToInt32(Console.ReadLine());

                sum = sum + arr[val];
            }
            Console.WriteLine("sum of array elements are " + sum);
            Console.ReadKey();

        }
    }
}
