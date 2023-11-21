using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_vehicle
{
    class vehicle
    {
        string make;
        string model;
        public void get(string make,string model)
        {
            this.make = make;
            this.model = model;
            Console.WriteLine("Make : " + make);
            Console.WriteLine("Model : " + model);

        }
    }
    class car : vehicle
    {
        int numdoor;
        string fueltype;
        public void set(int numdoor , string fueltype)
        {
            this.numdoor = numdoor;
            this.fueltype = fueltype;
            Console.WriteLine("No of doors : " + numdoor);
            Console.WriteLine("Fuel type : " + fueltype);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            car c = new car();
            Console.WriteLine("Enter vehicle make :");
            string make = Console.ReadLine();

            Console.WriteLine("Enter vehicle model :");
            string model = Console.ReadLine();

            Console.WriteLine("Enter car no of doors :");
            int numdoor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter car fuel type :");
            string fueltype = Console.ReadLine();

            c.get(make, model);
            c.set(numdoor, fueltype);
            Console.ReadKey();

        }
    }
}
