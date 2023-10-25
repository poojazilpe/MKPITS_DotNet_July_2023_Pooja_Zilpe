using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jump_goto
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter no :");
             num = Convert.ToInt32(Console.ReadLine());
            
            if (num % 2 == 0) goto Even;
            Console.WriteLine("Odd");
            goto End;
        Even:
            Console.WriteLine("Even");
        End:
            Console.ReadKey();


        }
    }
}
