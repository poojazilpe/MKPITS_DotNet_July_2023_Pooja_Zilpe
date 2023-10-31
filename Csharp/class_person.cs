using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_person
{
    class Program
    {
        class Person
        {
            string name, address;
            int age;
            public void getdata(string name,int age,string address)
            {
                this.name = name;
                this.age = age;
                this.address = address;
            }
            public void displaydata()
            {
                Console.WriteLine("Name :" + name);
                Console.WriteLine("Age :" + age);
                Console.WriteLine("Address :" + address);
            }
        }
        static void Main(string[] args) 
        {
            Person per = new Person();
            Console.WriteLine("Enter Name, Age & Address :");
            string n = Console.ReadLine();
            int a = Convert.ToInt32(Console.ReadLine());
            string ad = Console.ReadLine();
            per.getdata(n, a, ad);
            per.displaydata();
            Console.ReadLine();

        }
    }
}
