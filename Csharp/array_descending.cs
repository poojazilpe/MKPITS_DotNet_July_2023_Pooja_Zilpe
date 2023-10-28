using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_descending
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int temp;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter element : {0}- ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Elements of array in sorted ascending order: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.ReadKey();
        }
    }
}
