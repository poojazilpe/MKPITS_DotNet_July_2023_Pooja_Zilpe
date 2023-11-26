using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_bank1
{ 
    interface bank
    {
        string deposit(int accno, int amt);
    }
    class saving : bank
    {
        int accno;
        int bal = 1000;
        int interest = 200;
        public string deposit(int accno, int amt)
        {
            this.accno = accno;
            bal = bal + amt + interest;
            return "Account No :" + accno + "\n" + "Balance with intrest :" + bal;
        }
    }
    class current : bank
    {
        int accno;
        int bal = 1000;

        public string deposit(int accno, int amt)
        {
            this.accno = accno;
            bal = bal + amt;
            return "Account No :" + accno + "\n" + "Balance without intrest :" + bal;
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                bank b = null;
                Console.WriteLine("Enter Account No :");
                int accno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Amount :");
                int amt = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter account type saving or current :");
                string acttype = Console.ReadLine();

                switch(acttype)
                {
                    case "saving" :
                        b = new saving();
                        break;
                    case "current":
                        b = new current();
                        break;
                }
                string res = b.deposit(accno, amt);
                Console.WriteLine(res);
                Console.ReadLine();
            }



        }
}
    

