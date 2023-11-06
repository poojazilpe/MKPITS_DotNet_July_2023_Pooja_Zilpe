using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading_0to4parameter
{
    class Book
    {
        int bookid;
        String title, author;
        int price;

        public void getdata()
        {
            bookid = 1;
            title = "Oracle";
            author = "James";
            price = 200;

        }
        //method overloaded 
        public void getdata(int bookid)
        {
            this.bookid = bookid;

        }
        public void getdata(int bookid, String title)
        {
            this.bookid = bookid;
            this.title = title;

        }
        public void getdata(int bookid, String title, String author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;

        }
        public void getdata(int bookid, String title, String author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Book Id = " + bookid);
            Console.WriteLine("Book Title = " + title);
            Console.WriteLine("Book Author= " + author);
            Console.WriteLine("Price = " + price);



        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdata();
            b.display();
            Console.WriteLine("-----------------book1 details ----------");
            Book b1 = new Book();
            b1.getdata(111, "Csharp");
            b1.display();

            Console.WriteLine("-----------------book2 details ----------");
            Book b2 = new Book();
            b2.getdata(111, "Csharp", "Pooja");
            b2.display();

            Console.WriteLine("-----------------book3 details ----------");

            Book b3 = new Book();
            b3.getdata(111, "Csharp", "Pooja", 444);
            b3.display();

            Console.WriteLine("-----------------book4 details ----------");

            Console.ReadLine();

        }
    }
}
