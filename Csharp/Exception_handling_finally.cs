using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, n;
            Console.WriteLine("Enter No 1 :");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter No 2 :");
            n = Convert.ToInt32(Console.ReadLine());

            int res = 0;
            try
            {
                res = num / n;
            }
            catch(Exception ee)
            {
                Console.WriteLine("catch block is executing");
                Console.WriteLine("Connot devide by zero");
            }
            finally
            {
                Console.WriteLine("Finally block is executing");
                Console.WriteLine("Result : " + res);

            }
            
            Console.ReadKey();
        }
    }
}
