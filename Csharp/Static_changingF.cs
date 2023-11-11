using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_changingfeild
{
    class Program
    {
        public class Account
        {
            public int accno;
            public string name;
            public static float rateOfIntrest=8.8f;
            public Account(int accno,string name)
            {
                this.accno = accno;
                this.name = name;
            }
            public void display()
            {
                Console.WriteLine(accno + " " + name + " " + rateOfIntrest);
            }
                
        }
        static void Main(string[] args)
        {
           Account.rateOfIntrest = 10.5f;
            Account a = new Account(1,"Pooja");
            Account a1 = new Account(2, "Chandrima");
            a.display();
            a1.display();
            Console.ReadKey();

        }
    }
}
