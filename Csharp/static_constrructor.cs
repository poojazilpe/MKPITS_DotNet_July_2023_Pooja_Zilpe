using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor
{
    class Account
    {
        public int accno;
        public string name;
        public static float roi;
        public Account(int accno,string name)
        {
            Console.WriteLine("instance constructor is called ");
            this.accno = accno;
            this.name = name;
        }
        static Account()
        {
            Console.WriteLine("static constructor is called ");
            roi = 9.5f;
        }
        public void display()
        {
            Console.WriteLine(" " + accno + " " + name + roi);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(101, "Sonoo");
            Account a2 = new Account(102, "Mahesh");
            a1.display();
            a2.display();
            Console.ReadKey();

        }
    }
}
