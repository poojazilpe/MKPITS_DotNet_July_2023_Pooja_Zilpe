using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_student1
{
    class Program
    {
        class Student
        {
            string name;
            int roll_no,total;
            float avg;
            int[] marks = new int[5];
            public void getdata(string name,int roll_no,int [] m)
            {
                this.name = name;
                this.roll_no = roll_no;
                this.marks = m;

                
            }
            public void displaydata()
            {
               
                for (int i = 0; i < 5; i++)
                {
                    total = total + marks[i];
                }
                avg = total / 5.0f;
                Console.WriteLine("Name :" + name);
                Console.WriteLine("Roll No :" + roll_no);

                Console.WriteLine("Total :" + total);
                Console.WriteLine("Average :" + avg);


            }
        }
        static void Main(string[] args)
        {
            int[] m = new int[5];
            Student stud = new Student();
            Console.WriteLine("Enter name & Roll No :");
            string n = Console.ReadLine();
            int r= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks :");
            for(int i=0;i<5;i++)
            {
                m[i] = Convert.ToInt32(Console.ReadLine());
            }
            stud.getdata(n, r,m);
            stud.displaydata();
            Console.ReadLine();

        }
    }
}
