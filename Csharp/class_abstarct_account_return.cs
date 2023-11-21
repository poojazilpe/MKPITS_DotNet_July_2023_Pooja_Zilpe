using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_abstract_account_return
{
    abstract class account
    {
        public int accno;
        public int bal = 1000;
        public abstract string deposit(int accno,int amt);
        public string show()
        {
            return "Balance : " + bal;
        }
    }
    class current : account
    {
        public override string deposit(int accno,int amt)
        {
            this.accno=accno;
            bal = bal + amt;
            return "amount deposited successfully without interest in current class";
        }

    }
    class saving : account
    {
        public override string deposit(int accno, int amt)
        {
            int interest = 200;
            this.accno = accno;
            bal = bal + amt + interest;
            return "amount withdrawl successfully with interest in saving  class";


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            account a = null;
            Console.WriteLine("Enter account no :");
            int accno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter amount :");
            int amt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter type saving or current :");
            string atype = Console.ReadLine();
            if(atype=="saving")
            {
                a = new saving();
            }
            else if(atype == "current")
            {
                a = new current();
            }
            String res = a.deposit(accno, amt);
            Console.WriteLine("account no is " + a.accno);
            Console.WriteLine(res);
            res = a.show();
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
