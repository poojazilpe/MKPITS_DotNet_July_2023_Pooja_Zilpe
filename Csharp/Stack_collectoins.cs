using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Stack_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack sk = new Stack();
            sk.Push('A');
            sk.Push('B');
            sk.Push('C');
            sk.Push('D');
            Console.WriteLine("Current stack: ");
            foreach (char c in sk)
            {
                Console.WriteLine(c + " " + "\n");
            }
            sk.Push('E');
            sk.Push('F');
            
            Console.WriteLine("Current stack: ");
            foreach (char c in sk)
            {
                Console.WriteLine(c + " " + "\n");
            }
            Console.WriteLine("The next poppable value in stack: {0}", sk.Peek());
            Console.WriteLine("Removing values ");
            sk.Pop();
            sk.Pop();
            foreach (char c in sk)
            {
                Console.WriteLine(c + " " + "\n");
            }
            Console.ReadKey();
        }
    }
}
