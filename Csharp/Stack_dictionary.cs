using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> sk = new Stack<int>();
            sk.Push(1);
            sk.Push(2);
            sk.Push(3);
            sk.Push(4);
            Console.WriteLine(sk.Peek());
            Console.WriteLine(sk.Pop());
            
            Console.WriteLine();
            foreach ( int i in sk)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
