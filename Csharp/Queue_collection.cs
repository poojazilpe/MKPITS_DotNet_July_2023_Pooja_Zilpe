using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue('A');
            q.Enqueue('B');
            q.Enqueue('C');
            q.Enqueue('D');
            Console.WriteLine("Current Queue :");
            foreach (Char c in q) 
            {
                Console.WriteLine(c + " "+"\n");
            }
            q.Enqueue('E');
            q.Enqueue('F');
            Console.WriteLine(" After add character Queue :");
            foreach (Char c in q)
            {
                Console.WriteLine(c + " " + "\n");
            }
            Console.WriteLine("Removing some values ");
            char ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            Console.ReadKey();
          

        }
    }
}
