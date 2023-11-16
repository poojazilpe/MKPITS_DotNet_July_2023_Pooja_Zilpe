using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_count_object
{
    class Account
    {
        public int accno;
        public string name;
        public static int count = 0;
        public Account(int accno,string name)
        {
            this.accno = accno;
            this.name = name;
            count++;
        }
        public void display()
        {
            Console.WriteLine(" " + accno + " " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account(1, "Pooja");
            Account a1 = new Account(2, "Chandrima");
            Account a2 = new Account(3, "Kareena");
            a.display();
            a1.display();
            a2.display();
            Console.WriteLine("Total Objects are: " + Account.count);
            Console.ReadKey();

        }
    }
}
