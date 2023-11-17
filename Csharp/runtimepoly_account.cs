using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtimepoly_account
{
    class Account
    {
       public int accno;
        public int balance=1000;
        public virtual string deposite(int acno,int amt)
        {
            return "deposit method of account class";
        }
        public string showbalance()
        {
            return "Balance Amoount : " + balance;
        }
    }
    class current : Account
    {
        public override string deposite(int accno, int amt)
        {
            this.accno = accno;
            balance = balance + amt;
            return "amount deposited successfully in current class";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account act = new current();
            String res = act.deposite(1, 2000);
            Console.WriteLine("account no is " + act.accno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
