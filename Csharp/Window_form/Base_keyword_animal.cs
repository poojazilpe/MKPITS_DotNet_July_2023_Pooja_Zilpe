using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_keyword_animal
{
    class Animal
    {
        public string color = "White";
        
    }
    class Dog : Animal
    {
        public string color = "Red";
        public void display()
        {
            Console.WriteLine("Dog color :" + color);
            Console.WriteLine("Animal color :" + base.color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.display();
            Console.ReadKey();
        }
    }
}
