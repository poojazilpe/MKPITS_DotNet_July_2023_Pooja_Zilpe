using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_PassByvalue
{
    class Program
    {
        static void display(int num)
        {
             num = 20;//local variable
            Console.WriteLine("Num inside method :" + num);//20
        }
        static void Main(string[] args)
        {
            int num = 10;
            display(num);
            Console.WriteLine("num after passing inside main : " + num);//10
            Console.ReadKey();
        }
    }
}
