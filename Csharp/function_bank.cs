using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_bank
{
    class Program
    {
        static int calculate(int acno, int amt)
        {
            int balance = 1000;
            int deposite, withdrawl;
            int result = 0;
            deposite = amt + balance;
            Console.WriteLine("Deposite value is :" + deposite);
            withdrawl = amt - balance;
            Console.WriteLine("Withdrawl value is :" + withdrawl);
            return result;
        }
        static void Main(string[] args)
        {
            int accno, amount;
            Console.WriteLine("Enter Accont no :");
            accno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount :");
            amount = Convert.ToInt32(Console.ReadLine());
            int res = calculate(accno, amount);
            
            
                Console.ReadKey();


        }
    }
}
