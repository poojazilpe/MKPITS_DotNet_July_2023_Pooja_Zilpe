﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_Inheritance_animal
{
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating....");
        }
    }
    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking....");
        }
    }
    class Babydog : Dog
    {
        public void weep()
        {
            Console.WriteLine("Weeping....");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Babydog b = new Babydog();
            b.eat();
            b.bark();
            b.weep();
            Console.ReadKey();
                

        }
    }
}
