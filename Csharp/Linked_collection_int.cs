using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_collection_int
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> num = new LinkedList<int>();
            num.AddLast(7);
            num.AddLast(9);
            num.AddLast(10);
            num.AddFirst(1);
            LinkedListNode<int> node = num.Find(9);
            num.AddBefore(node, 8);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
