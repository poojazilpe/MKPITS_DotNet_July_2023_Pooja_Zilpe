using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile_nsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cnt = 1;
            Console.WriteLine("Enter no :");
            num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            do
            {
                Console.WriteLine(cnt);
                sum = sum + cnt;
                cnt++;
            } while (cnt <= num);
            Console.WriteLine("Sum = {0}", sum);
            Console.ReadKey();
        }
    }
}
