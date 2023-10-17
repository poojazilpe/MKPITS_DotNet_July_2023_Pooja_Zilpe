using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_vowel
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            Console.WriteLine("Enter character :");
            op = Convert.ToChar(Console.ReadLine());
            switch(op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Character is vowel");
                    break;
                default:
                    Console.WriteLine("Character is consonant");
                    break;


            }
            Console.ReadKey();
        }
    }
}
