using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @char
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("Enter Character : ");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Character = " + ch);
            Console.ReadKey();
        }
    }
}
