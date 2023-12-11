using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machintest_Animal_hirarchical
{
    class Animal
    {
        public string name;
        public int age;
        public Animal(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void makesound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }
    class Mammal :Animal
    {
        public Mammal(string name,int age): base(name,age)
        {
            
        }
    }
    class Reptile : Animal
    {
        public Reptile(string name,int age) :base(name,age)
        {

        }
    }
    class Bird : Animal
    {
        public Bird(string name,int age) : base(name,age)
        {

        }
    }
    class Lion : Mammal
    {
        public Lion(string name,int age) : base(name,age)
        {

        }
        public override void makesound()
        {
            Console.WriteLine("Lion is roar");
        }

    }
    class Snake : Reptile
    {
        public Snake(string name,int age) : base (name,age)
        {

        }
        public override void makesound()
        {
            Console.WriteLine("Hiss");
        }
    }
    class Eagle : Bird
    {
        public Eagle(string name,int age) : base (name,age)
        {

        }
        public override void makesound()
        {
            Console.WriteLine("Screech!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lion l = new Lion("Simba",3);
            Snake s = new Snake("Nahin",2);
            Eagle e = new Eagle("Thunder",1);
            Animal[] animals = { l, s, e };
            foreach (Animal animal in animals)
            {
                Console.WriteLine("Name :" + animal.name);
                Console.WriteLine("Age :" + animal.age);
                animal.makesound();
                    

            }

            Console.ReadKey();
        }
    }
}
