using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_secondsmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            Console.WriteLine("Enter No : ");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            int n = arr.Length;
            Console.WriteLine("Second smallest no : {0}",arr[1]);
            Console.ReadLine();
        }
    }
}
