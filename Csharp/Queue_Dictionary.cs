using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("m 1");
            q.Enqueue("m 2");
            q.Enqueue("m 3");
            q.Enqueue("m 4");
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Peek());
            Console.WriteLine();
            foreach (string s in q)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
