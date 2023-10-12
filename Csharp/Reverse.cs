using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNo
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b, c;
            Console.Write("Enter character 1 : ");
            a = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter character 2 : " );
            b = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter character 3 : " );
             c= Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Reverse character :" + c + b + a);
            Console.ReadKey();

        }
    }
}
