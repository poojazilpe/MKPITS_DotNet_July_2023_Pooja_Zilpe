using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTickit
{
    class Program
    {
        static void Main(string[] args)
        {
            string origin, destination;
            int date, trainno,km;
            string classes, passangername;
            Console.WriteLine("Enter origin :");
            origin = Console.ReadLine();

            Console.WriteLine("Enter destination :");
            destination = Console.ReadLine();

            Console.WriteLine("Enter date :");
            date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Train no :");
            trainno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Classes :");
            classes = (Console.ReadLine());

            Console.WriteLine("Enter Passanger Name :");
            passangername = (Console.ReadLine());

            Console.WriteLine("Enter Km :");
            km = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" origin : {0}, \n destination : {1}, \n date : {2}, \n train no: {3}, classes:{4}\n" +
                " passanger name : {5} \n km: {6} ", origin, destination, date, trainno, classes, passangername, km);

            if (km<=100)
            {
                Console.WriteLine(" Total fare =100 rs.");
            }
            else if(km>=100 && km<=500)
            {
                Console.WriteLine("Total fare =500 rs.");
            }
            else
            {
                Console.WriteLine("Total fare =800 rs.");
               
            }
            
            Console.ReadKey();
        }
    }
}
