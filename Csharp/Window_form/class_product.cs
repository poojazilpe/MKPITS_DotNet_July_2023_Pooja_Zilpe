using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_product
{
    class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductItem { get; set; }

        public void getData(string ProductName, int ProductPrice, int ProductItem)
        {
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.ProductItem = ProductItem;
        }
        public void display()
        {
            Console.WriteLine("Product: " + ProductName);
            Console.WriteLine("Price: " + ProductPrice);
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product pr = new Product();
            string name;
            int item, price;
            int total;
            int quantity = 50;

            Console.WriteLine("Enter Product Name: ");
            name = Console.ReadLine();
            Console.WriteLine("How much you buy: ");
            item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price : ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("_________");

            if (item > 0 && item < quantity)
            {
                int remaningquantity = quantity - item;
                total = price * item;

                pr.getData(name, price, total);

                pr.display();
                Console.WriteLine("Total Price you Purches: " + total);
                Console.WriteLine("Remaining stock are: {0}", remaningquantity);
            }
            else
            {
                Console.WriteLine("Insufficient in stock");
            }
            Console.ReadKey();
        }
    }
}
