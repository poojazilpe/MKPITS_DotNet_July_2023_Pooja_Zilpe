using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_feild
{
    class Account
    {
        public int accno;
        public string name;
        public static float rateofIntrest = 8.8f;
        public Account(int accno, string name)
        {
            this.accno = accno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(accno + " " + name + " " + rateofIntrest);
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account(1, "Pooja");
            Account a1 = new Account(2, "Chandrima");
            a.display();
            a1.display();
            Console.ReadKey();

        }
    }
}
