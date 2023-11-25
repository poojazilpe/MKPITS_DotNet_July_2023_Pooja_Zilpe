using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_account_bank_deposit_withdrawl1
{
    interface bank
    {
        string deposit(int accno, int amt);
        string withdrawl(int accno, int amt);
         string show();
    }
    class account
    {
        public int accno;
        public int bal = 1000;
        public int interest = 500;
       

    }
    class saving : account, bank
    {
        public string deposit(int accno, int amt)
        {
            this.accno = accno;
            bal = bal + amt+interest;
            return "Deposit successfully, Balance is :" + bal;
        }
        public string withdrawl(int accno, int amt)
        {
            this.accno = accno;
            bal = bal - amt;
            return "withdrawl successfully, Balance is :" + bal;
        }
        public string show()
        {
            return "balance is :" + bal;
        }
    }
    class current : account, bank
    {
        public string deposit(int accno, int amt)
        {
            this.accno = accno;
            bal = bal + amt ;
            return "Deposit successfully, Balance is :" + bal;
        }
        public string withdrawl(int accno, int amt)
        {
            this.accno = accno;
            bal = bal - amt;
            return "withdrawl successfully, Balance is :" + bal;
        }
        public string show()
        {
            return "balance is :" + bal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bank b = null;
            Console.WriteLine("enter account no :");
            int accno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter amount :");
            int amt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter saving or current");
            string acttype = Console.ReadLine();
            string res = null;
            switch (acttype)
            {
                case "saving":
                    b = new saving();
                    break;
                case "current":
                    b = new current();
                    break;

            }
            Console.WriteLine("enter deposit or withdrawl");
            string tt = Console.ReadLine();


            if (tt == "deposit")
                res = b.deposit(accno,amt);
            else if (tt == "withdrawl")
                res = b.withdrawl(accno,amt);

            Console.WriteLine(res);
            Console.WriteLine(b.show());
            Console.ReadKey();

        }
    }
}
