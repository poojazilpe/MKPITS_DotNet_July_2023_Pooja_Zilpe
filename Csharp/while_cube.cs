//Write a C# Sharp program to display the cube of an integer up to given number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_cube
{
    class Program
    {
        static void Main(string[] args)
        {
            int cube, num,cnt=1;
            Console.WriteLine("Enter no :");
            num = Convert.ToInt32(Console.ReadLine());
            while(cnt<=num)
            {
                cube = cnt * cnt * cnt;
                Console.WriteLine("cube={0}", cube);
                cnt++;
            }
            Console.ReadKey();
        }
    }
}
