using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Book1
{
   // 2- create a class book and constructor with no parameters and another constructor with 4 parameters
    class Program
    {
        class Book
        {
            int BookId, Price;
            string Title, Author;
            //no parameter
            public Book()
            {
                Console.WriteLine("Constructor with parameter");
                Console.WriteLine("----------------------------");
                BookId = 1;
                Title = "Java";
                Author = "Pooja Zilpe";
                Price = 300;
            }
            //creating a  parameterized constructor with 4 parameters
            public Book(int BookId,string Title,string Author,int Price)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Constructor with parameter");
                Console.WriteLine("----------------------------");
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
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();

            Book b1 = new Book(2,"Python","Shashwat",500);
            b1.display();
            Console.ReadKey();
        }
    }
}
