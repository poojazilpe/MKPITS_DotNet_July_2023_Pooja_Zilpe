using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstact_class_account1
{
    abstract class account
    {
        public abstract void deposit();
        public void showbalance()
        {
            Console.WriteLine("balance method");
        }
    }
    class saving : account
    {
        public override void deposit()
        {
            Console.WriteLine("Hello from saving method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            account a = new saving();
            a.deposit();
            a.showbalance();
            Console.ReadKey();
        }
    }
}
