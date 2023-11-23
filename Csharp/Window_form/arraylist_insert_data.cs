using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arraylist_insert_data
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(11);
            ar.Add(12);
            ar.Add(13);
            Console.WriteLine("Arraylist without insert data");
            foreach(object o in ar)
            {
                Console.WriteLine("Roll No :" + o);
            }
            ar.Insert(1, 15);

            Console.WriteLine("Arraylist with insert data");
            foreach (object o in ar)
            {
                Console.WriteLine("Roll No :" + o);
            }
            Console.ReadKey();
        }
    }
}
