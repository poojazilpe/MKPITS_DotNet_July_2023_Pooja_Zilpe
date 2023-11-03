using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_book_para
{
    class Book
    {
        int bookid, price;
        string title, author;
        
        //creating a constructor with no parameters
        public Book()
        {
            bookid = 1;
            title = "Oracle";
            author = "James";
            price = 200;
        }
        //constructor with 4 parameters(parameterized constructor)

        public Book(int bookid,string title,string author,int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Book Id :" + bookid);
            Console.WriteLine("Book Title :" + title);
            Console.WriteLine("Book Author :" + author);
            Console.WriteLine("Book Price :" + price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();
            Console.WriteLine("-----------------book1 details ----------");
            Book b1 = new Book(111, "C-sharp", "Martin", 2000); // this will call parameterized constructor
            b1.display();
            Console.WriteLine("-----------------book2 details ----------");

            Console.WriteLine("Enter Book Id:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Title:");
            string t = (Console.ReadLine());
            Console.WriteLine("Enter Book Author:");
            string a = (Console.ReadLine());
            Console.WriteLine("Enter Book Price:");
            int p = Convert.ToInt32(Console.ReadLine());
            Book b2 = new Book(i,t,a,p);
            b2.display();
            Console.ReadKey();
        }
    }
}
