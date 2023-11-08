using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_BookFromuser
{
    class Book
    {
        int BookId, Price;
        string Title, Author;
        public Book(int BookId,string Title,string Author,int Price)
        {
            this.BookId = BookId;
            this.Title = Title;
            this.Author = Author;
            this.Price = Price;
        }
        public void display()
        {
            Console.WriteLine("Book Id : " + BookId);
            Console.WriteLine("Book Title : " + Title);
            Console.WriteLine("Book Author : " + Author);
            Console.WriteLine("Book Price : " + Price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Enter Book Id :");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Book Title :");
            string t = Console.ReadLine();

            Console.WriteLine("Enter Book Author :");
            string a = (Console.ReadLine());

            Console.WriteLine("Enter Price :");
            int p = Convert.ToInt32(Console.ReadLine());

            Book b = new Book(i,t,a,p);
            b.display();
            Console.ReadKey();
        }
    }
}
