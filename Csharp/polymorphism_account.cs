using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_account
{
    class Account
    {
        public int accno;
        public int balance=1000;
        public virtual void deposit(int accno,int amt)
        {
            Console.WriteLine( "deposit method of account class");
        }
        public virtual void withdrawl(int accno, int amt)
        {
            Console.WriteLine("deposit method of account class");
        }
        public void dshowbalance()
        {
            Console.WriteLine (" deposit Balance Amount :" + balance+"\n");
        }
        public void wshowbalance()
        {
            Console.WriteLine (" withdrwal Balance Amount :" + balance);
        }
    }
    class current : Account
    {
        public override void deposit(int accno, int amt)
        {
            this.accno = accno;
            balance = balance + amt;
            Console.WriteLine ("amount deposited successfully without interest in current class");
        }
        public override void withdrawl(int accno, int amt)
        {
            balance = 1000;
            this.accno = accno;
            balance = balance - amt;
            if (amt > balance)
            {
                Console.WriteLine("Insufficient balance for withdrawl from current account");
            }
            else
            {
                Console.WriteLine("withdrawl successfully in current account");
            }
        }
    }
    class saving : Account
    {
        public override void deposit(int accno, int amt)
        {
            this.accno = accno;
            int intrest = 500;
            balance = balance + amt+intrest;
            Console.WriteLine ("amount deposited successfully with interest in Saving class");
        }
        public override void withdrawl(int accno, int amt)
        {
            balance = 1000;
            this.accno = accno;
            balance = balance - amt;
            if (amt > balance)
            {
                Console.WriteLine("Insufficient balance for withdrawl from saving account");
            }
            else
            {
                Console.WriteLine("withdrawl successfully in current account");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter account no ");
            int accno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount to be deposited ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account type (saving or currrent)");
            String acttype = Console.ReadLine();
            

            Account act = null;
            if (acttype == "saving")
            {
                act = new saving();
            }
            else if (acttype == "current")
            {
                act = new current();
            }

            Console.WriteLine("Do you want withdrawl or deposite");
            String choice = Console.ReadLine();
            if (choice=="deposite")
            {
                act.deposit(accno, amt);
                act.dshowbalance();
            }
            else if(choice == "withdrawl")
            {
                act.withdrawl(accno, amt);
                act.wshowbalance();
            }

           
            Console.ReadKey();
        }
    }
}
