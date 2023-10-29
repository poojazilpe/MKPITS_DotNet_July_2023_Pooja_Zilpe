using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int max, min;
            for(int cnt=0;cnt<3;cnt++)
            {
                Console.Write("Enter Element {0}- ", cnt);
                arr[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            max = arr[0];
            for(int cnt=0;cnt<3;cnt++)
            {
                if(arr[cnt]>max)
                {
                    max = arr[cnt];
                }
            }
            min = arr[0];
            for(int cnt=0;cnt<3;cnt++)
            {
                if(arr[cnt]<min)
                {
                    min = arr[cnt];
                }
            }

            Console.WriteLine("Maximum value = {0}", max);
            Console.WriteLine("Minimum value = {0}", min);
            Console.ReadKey();
        }
    }
}
