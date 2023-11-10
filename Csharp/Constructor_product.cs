using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Product
{
    class Product
    {
        int ProdId,Quantity,Price;
        string Name;
        public Product()
        {
            ProdId = 1;
            Name = "Pen";
            Quantity = 5;
            Price = 10;
        }
        public void display()
        {
            Console.WriteLine("Product Id :" + ProdId);
            Console.WriteLine("Product Name :" + Name);
            Console.WriteLine("Product Quantity :" + Quantity);
            Console.WriteLine("Product Price :" + Price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.display();
            Console.ReadKey();
        }
    }
}
