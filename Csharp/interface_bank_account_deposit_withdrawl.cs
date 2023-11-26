using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_bank_account_deposit_withdrawl
{
    interface bank
    {
        string deposit(int accno, int amt);
    }
    class account
    {
        public int accno;
        public int bal = 1000;
        public string show()
        {
            return "balance is :" + bal;
        }

    }
    class saving : account,bank
    {
        public string deposit(int accno,int amt)
        {
            this.accno = accno;
            bal = bal + amt;
            return "Deposit successfully, Balance is :" + bal;
        }
        public string withdrawl(int accno, int amt)
        {
            this.accno = accno;
            bal = bal - amt;
            return "withdrawl successfully, Balance is :" + bal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            saving s;
            s = new saving();
            string res = s.deposit(1, 200);
            Console.WriteLine(res);

            res = s.withdrawl(1, 100);
            Console.WriteLine(res);
            Console.WriteLine(s.show());
            Console.ReadKey();
        }
    }
}
