using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_book
{
    class Program
    {
        class Book 
        {
            string title, author;
            int year;
            int [] book;
            public void getdata(string title,string author,int year)
            {
                this.title = title;
                this.author = author;
                this.year = year;
                
            }
            public void displaydata()
            {
                
                Console.WriteLine("Title :" + title);
                Console.WriteLine("Author :" + author);
                Console.WriteLine("Year :" + year);
            }
        }

        static void Main(string[] args)
        {
            Book[] b1 = new Book[3];
            b1[0] = new Book();
            b1[1] = new Book();
            b1[2] = new Book();
            string t = null;
            string a = null;
            int y = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Title : ");
                t = Console.ReadLine();

                Console.WriteLine("Enter Author  : ");
                a = Console.ReadLine();

                Console.WriteLine("Enter Year : ");
                y = Convert.ToInt32(Console.ReadLine());
                b1[i].getdata(t, a, y);
            }
                for (int i = 0; i < 3; i++)
                {
                    b1[i].displaydata();

                }
                Console.ReadKey();

            }
        }
    }

