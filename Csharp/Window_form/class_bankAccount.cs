using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_bankAccount
{
    class Program
    {
        class Bank
        {
            public int AccountNumber { get; set; }
            public string AccountHolderName { get; set; }
            public int Balance { get; set; }
            public void display()
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("account details of customer  :");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Account no : " + AccountNumber);
                Console.WriteLine("Account Holder name : " + AccountHolderName);
                Console.WriteLine("Balance : " + Balance);

            }
            public void transfer(Bank ba)
            {
                Balance = Balance + ba.Balance;
                ba.Balance = 0;
            }
            public void showing()
            {
                Console.WriteLine("current balance for account no {0} is {1} ", AccountNumber, Balance);
            }
        }
            static void Main(string[] args)
            {
                Bank b1 = new Bank();
                Bank b2 = new Bank();
                b1.AccountNumber = 123;
                b1.AccountHolderName = "Pooja";
                b1.Balance = 100;
                b1.display();

                b2.AccountNumber = 456;
                b2.AccountHolderName = "Kareena";
                b2.Balance = 50;
                b2.display();
                b1.transfer(b2);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("balance after transaction ");
                Console.WriteLine("----------------------------------");

                b1.showing();
                b2.showing();
                Console.ReadKey();

            }
        }
}
