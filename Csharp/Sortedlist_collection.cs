using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sortedlist_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("001", "Pooja");
            sl.Add("002", "Chandu");
            sl.Add("003", "Kareena");
            sl.Add("004", "Akash");
            if(sl.ContainsValue("Sonu"))
            {
                Console.WriteLine("Already Exit");
            }
            else
            {
                sl.Add("005", "Sonu");
            }
            ICollection key = sl.Keys;
            foreach(string s in key)
            {
                Console.WriteLine("Name :" + s + ":" + sl[s]);
            }
            Console.ReadKey();
        }
    }
}
