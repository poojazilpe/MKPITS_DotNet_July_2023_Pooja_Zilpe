using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_inheritance_method
{
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("cochu is eating");
        }
    }
    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("cochu is barking");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.eat();
            d.bark();
            Console.ReadKey();
        }
    }
}
