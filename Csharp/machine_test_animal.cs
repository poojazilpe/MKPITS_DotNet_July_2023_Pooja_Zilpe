using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machine_test_animal
{
    class Animal
    {
        public int age { get; set; }
        public string name { get; set; }
        public Animal(int age,string name)
        {
            this.age = age;
            this.name = name;
        }
        public void makesound()
        {
            Console.WriteLine("Animal make sound");
        }
        
    }
    class Mammal:Animal
    {
        public string furcolor { get; set; }
        public Mammal(int age, string name, string furcolor) : base(age, name)
        {
            
            this.furcolor = furcolor;
        }
        public void walk()
        {
            Console.WriteLine("Mammal is walking");
        }
    }
    class Reptile : Animal
    {
        public bool Iscoldloaded { get; set; }
        public Reptile(int age, string name, bool Iscoldloaded) : base(age, name)
        {
            this.Iscoldloaded = Iscoldloaded;
        }
        public void croll()
        {
            Console.WriteLine("Reptile is crolling");
        }

    }
    class Bird : Animal
    {
        public int wing { get; set; }
        public Bird(int age, string name, int wing) : base(age, name)
        {
            this.wing = wing;
        }
        public void fly()
        {
            Console.WriteLine("Bird is flying");
        }

    }
    class Lion : Mammal
    {

        public Lion(int age,string name, string furcolor) :base(age,name,furcolor)
        {
            this.age = age;
            this.name = furcolor;
        }
        public void makesound()
        {
            Console.WriteLine("Lion Roars loudly");
        }
        public void display()
        {
            Console.WriteLine("Age : "+age+"\n");
            Console.WriteLine("Name : " + name + "\n");
            Console.WriteLine("Furcolor : " + furcolor + "\n");
        }


    }
    class Snake :Reptile
    {
        public Snake(int age, string name, bool Iscoldloaded) : base(age, name, Iscoldloaded)
        {
            

        }
        public void makesound()
        {
            Console.WriteLine("Snake is hiss");
        }
        public void display()
        {
            Console.WriteLine("Age : " + age + "\n");
            Console.WriteLine("Name : " + name + "\n");
            Console.WriteLine("Iscoldloaded : " + Iscoldloaded + "\n");
        }

    }
    class Eagle : Bird
    {
        public Eagle(int age, string name, int wing) : base(age, name, wing)
        {


        }
        public void makesound()
        {
            Console.WriteLine("Eagle is scriches");
        }
        public void display()
        {
            Console.WriteLine("Age : " + age + "\n");
            Console.WriteLine("Name : " + name + "\n");
            Console.WriteLine("Wing : " + wing + "\n");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Lion l = new Lion(3,"simba","Orange");
            l.display();
            l.walk();
            Snake s = new Snake(2,"Cobra",true);
            s.display();
            s.croll();
            Eagle e = new Eagle(1, "Egloo", 2);
            e.display();
            e.fly();

            
                Console.ReadKey();
            }



        }
    }

