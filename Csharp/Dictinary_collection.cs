using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("p", "pooja");
            d.Add("c", "chandu");
            d.Add("k", "karina");
            d.Add("a", "akash");
            Console.WriteLine(d["c"]);
            Console.WriteLine("Dictionary has {0} items",
            d.Count);
            Console.WriteLine("Keys of the dictionary:");

            List<string> keys = new List<string>(d.Keys);

            foreach (string key in keys)
            {
                Console.WriteLine("{0}", key);
            }


            Console.WriteLine("Values of the dictionary:");

            List<string> vals = new List<string>(d.Values);

            foreach (string val in vals)
            {
                Console.WriteLine("{0}", val);
            }

            Console.WriteLine("Keys and values of the dictionary:");


            foreach (KeyValuePair<string, string> kvp in d)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }



            Console.ReadKey();

        }
    }
}
