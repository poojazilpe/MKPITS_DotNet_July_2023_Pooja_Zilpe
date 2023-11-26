using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_bank_account
{
    interface bank
    {
        string deposit(int accno, int amt);
    }
    class account
    {
        public int accno;
        public int bal = 1000;
    }
    class saving : account,bank
    {
        public string deposit(int accno,int amt)
        {
            this.accno = accno;
            bal = bal + amt;
            return "Account no :" + accno + "\n" + "Balance is :" + bal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bank b = new saving();
            string res = b.deposit(1, 200);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
