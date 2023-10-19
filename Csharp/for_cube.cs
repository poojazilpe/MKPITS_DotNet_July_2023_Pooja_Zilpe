using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_cube
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cube;
            Console.WriteLine("Enter no : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int cnt = 1; cnt <= num; cnt++)
            {
                cube = cnt * cnt * cnt;
                Console.WriteLine("Cube = {0}",cube);

            }
            Console.ReadKey();
        }
    }
}
