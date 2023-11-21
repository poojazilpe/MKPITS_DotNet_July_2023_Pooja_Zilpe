using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstact_class_deposit_withdrawl
{
    abstract class account
    {
        public int bal = 1000;
        public abstract void deposit(int amt);
        public abstract void withdrawl(int amt);
        public void show()
        {
            Console.WriteLine("Balance is : " + bal);
        }

    }
    class saving : account
    {
        public override void deposit(int amt)
        {
            int interest = 200;
            bal = bal + amt + interest;
            Console.WriteLine("Amount deposite with intrest,balance is : " + bal);
        }
        public override void withdrawl(int amt)
        {
            bal = bal - amt;
            Console.WriteLine("Amount withdrawl, balance is : " + bal);
        }
    }
    class current : account
    {
        public override void deposit(int amt)
        {
            bal=bal+amt;
            Console.WriteLine("Amount deposite without intrest,balance is : " + bal);

        }
        public override void withdrawl(int amt)
        {
            bal=bal-amt;
            Console.WriteLine("Amount withdrawl, balance is : " + bal);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            account a = null;
            Console.WriteLine("Enter amount :");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter type saving or current :");
            string acttype=Console.ReadLine();
            Console.WriteLine("Enter choice deposit or withdrawl :");
            string choice = Console.ReadLine();
            
            if(acttype=="saving")
            {
                a = new saving();
            }
            else if(acttype=="current")
            {
                a = new current();
            }

            if(choice=="withdrawl")
            {
                a.withdrawl(amt);
            }
            else if(choice=="deposit")
            {
                a.deposit(amt);
            }

            a.show();
            Console.ReadKey();

        }
    }
}
