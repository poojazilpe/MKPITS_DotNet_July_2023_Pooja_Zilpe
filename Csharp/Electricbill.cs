using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electric_bill
{
    class Program
    {
        static void Main(string[] args)
        {
            int cid, unit;
            float total, surcharge = 0, finalamt = 0, chrgunit = 0;
            string name;
            Console.WriteLine("\n-----------Enter Electricity bill details-------");
            Console.WriteLine("Enter customer id :");
            cid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter customer name :");
            name =Console.ReadLine();

            Console.WriteLine("Unit Consumed:");
            unit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n-----------Bill paid details-------");
            {
                if(unit<199)
                {
                    chrgunit = 1.20f;
                }
                else if(unit>=200 && unit<400)
                {
                    chrgunit = 1.50f;
                }
                else if (unit >= 400 && unit < 600)
                {
                    chrgunit = 1.80f;
                }
                else
                {
                    chrgunit = 2.00f;
                }
                total = unit * chrgunit;
                Console.WriteLine("Customer Id : {0} \n Customer Name: {1} \n Unit consumed: {2}", cid, name, unit);
                Console.WriteLine("Amount charges @Rs," + chrgunit + "Per unit: Rs," + total);

            }
            if(total>=400)
            {
                surcharge = total * 0.15f;
            }
            finalamt = total + surcharge;
            Console.WriteLine("Surcharge Amount: Rs.{0} \n Net amount paid by the customer : rs.{1}", surcharge, finalamt);
            Console.ReadKey();

        }
    }
}
