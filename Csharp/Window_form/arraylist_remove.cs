using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arraylist_remove
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(1);
            ar.Add(2);
            ar.Add(3);
            ar.Add(4);
            Console.WriteLine("Array list without remove");
            foreach (object o in ar)
            {
                Console.WriteLine("Roll No :" + o);
            }
            Console.WriteLine("------------------------------");
            ar.Remove(2);
            Console.WriteLine("Array list with remove");
            foreach (object o in ar)
            {
                Console.WriteLine("Roll No :" + o);
            }

            Console.WriteLine("------------------------------");
            ar.RemoveAt(2);
            Console.WriteLine("Array list with RemoveAt");
            foreach (object o in ar)
            {
                Console.WriteLine("Roll No :" + o);
            }
            Console.ReadKey();
        }
    }
}
