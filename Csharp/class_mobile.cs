using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_mobile
{
    class Mobile
    {
        string colour;
        string name;
        public void get(string colour,string name)
        {
            this.colour = colour;
            this.name = name;
            Console.WriteLine("Mobile Name : " + name);
            Console.WriteLine("Mobile colour : " + colour);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mobile m = new Mobile();
            m.get("Blue", "Narzo 50");
            Console.ReadKey();

        }
    }
}
