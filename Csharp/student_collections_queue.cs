using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace student_collection_queue
{
    class Student
    {
        public int rno;
        public string name;
        public Student(int rno,string name)
        {
            this.rno = rno;
            this.name = name;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Pooja");
            Student s2 = new Student(2, "Chandu");
            Student s3 = new Student(3, "Kareena");
            Queue q = new Queue();
            q.Enqueue(s1);
            q.Enqueue(s2);
            q.Enqueue(s3);
            foreach(Student s in q)
            {
                Console.WriteLine("Student Roll No : " + s.rno);
                Console.WriteLine("Student Name: " + s.name);
            }
            Student r = (Student)q.Dequeue();
            Console.WriteLine("item deque " + r.rno + " : " + r.name);
            Console.WriteLine("after deque ");
            foreach (Student s in q)
            {
                Console.WriteLine("name " + s.name);
            }

            Console.ReadLine();


        }
    }
}
