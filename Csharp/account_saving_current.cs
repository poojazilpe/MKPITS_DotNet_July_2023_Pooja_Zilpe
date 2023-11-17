using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace account_saving_current
{
    class Account

    {
        public int accno;
        public int balance = 1000;
        public virtual string deposit(int accno,int amt)
        {
            return "deposit method of account class";
        }
        public string showbalance()
        {
            return "Balance Amount : " + balance;
        }
    }
    class current : Account
    {
        public override string deposit(int accno, int amt)
        {
            this.accno = accno;
            balance = balance + amt;
            return "amount deposited successfully without interest in current class";
        }

        
    }
    class saving :Account
    {
        public override string deposit(int accno,int amt)
        {
            this.accno = accno;
            int intrest = 500;
            balance = balance + amt + intrest;
            return "amount deposited successfully without interest in saving class";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account no : ");
            int accno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter deposite amount : ");
            int amt=Convert.ToInt32(Console.ReadLine());
            Account a = new current();
            string res = a.deposit(accno, amt);
            Console.WriteLine("Account no is " + a.accno);
            Console.WriteLine(res);
            res = a.showbalance();
            Console.WriteLine(res);

            Console.WriteLine("Enter Account no : ");
            int accno1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter deposite amount : ");
            int amt1 = Convert.ToInt32(Console.ReadLine());
            Account a1 = new saving();
            string res1 = a1.deposit(accno1, amt1);
            Console.WriteLine("Account no is " + a1.accno);
            Console.WriteLine(res1);
            res1 = a1.showbalance();
            Console.WriteLine(res1);
            Console.ReadKey();




        }
    }
}
