using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("101", "Pooja");
            ht.Add("102", "Chandrima");
            ht.Add("103", "Kareena");
            ht.Add("104", "Akash");
            if(ht.ContainsValue("Sonu"))
            {
                Console.WriteLine("Already exists");
            }
            else
            {
                ht.Add("105", "Sonu");
            }
            ICollection key = ht.Keys;
            foreach(string s in key)
            {
                Console.WriteLine(s + " : " + ht[s]);
            }
            Console.ReadKey();
        }
    }
}
