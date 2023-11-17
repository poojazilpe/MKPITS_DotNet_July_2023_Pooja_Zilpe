using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism_Animal
{
    class Program
    {
        class Animal
        {
            public string color = "white";
        } 
        class dog : Animal
        {
            public string color = "Black";
        }
        static void Main(string[] args)
        {
            Animal a = new dog();
            Console.WriteLine(a.color);
            Console.ReadKey();
        }
    }
}
