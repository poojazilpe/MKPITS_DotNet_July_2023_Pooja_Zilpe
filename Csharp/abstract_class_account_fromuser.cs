using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstact_class_accout_fromuser
{
    abstract class account
    {
        public int bal = 1000;
        public int accno;
        public abstract void deposit(int amt);
        public void showbalance()
        {
            Console.WriteLine("bal amount for account no {0} is {1} ", accno, bal);
        }
    }
    class current : account
    {
        public override void deposit(int amt)
        {
            bal = bal + amt;
        }
    }
    class saving : account
    {
        int interest=500;
        public override void deposit(int amt)
        {
            bal = bal + amt + interest;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account No :");
            int accno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount :");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account type saving or current");
            string acttype = Console.ReadLine();
            account a = null;
            if(acttype=="saving")
            {
                a = new saving();
            }
            else if(acttype == "current")
            {
                a = new current();
            }
            a.accno = accno;
            a.deposit(amt);
            a.showbalance();
            Console.ReadKey();
        }
    }
}
