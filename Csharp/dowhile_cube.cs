using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_whilecube
{
    class Program
    {
        static void Main(string[] args)
        {
            int cube, num,sum=0;
            int cnt = 1;
            Console.WriteLine("Enter no :");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                cube = cnt * cnt * cnt;
                Console.WriteLine("cube = {0}", cube);
                sum = sum + cube;
                cnt++;
                
                
            } while (cnt <= num);
            Console.WriteLine("Sum = {0}", sum);
            Console.ReadKey();
        }
    }
}
