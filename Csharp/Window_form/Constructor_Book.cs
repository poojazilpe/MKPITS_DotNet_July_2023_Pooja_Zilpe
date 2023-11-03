using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Book
{
    class Book
    {
        int bookid, price;
        string title, author;
        public Book()
        {
            bookid = 1;
            title = "DotNet";
            author = "Pooja";
            price = 200;
        }
            public void display()
            {
            Console.WriteLine("Book Id : " + bookid);
            Console.WriteLine("Book Title : " + title);
            Console.WriteLine("Book Author : " + author);
            Console.WriteLine("Book Price : " + price);
            }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();
            Console.ReadKey();
        }
    }
}
