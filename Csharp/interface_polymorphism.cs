using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_Polymorphism
{
    interface Ianimal
    {
        void Makesound();
    }
    class dog : Ianimal
    {
       public void Makesound()
        {
            Console.WriteLine( "Dog is bark....");
        }
    }
    class cat : Ianimal
    {
        public void Makesound()
        {
            Console.WriteLine("cat is maw maw....");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ianimal [] a = new Ianimal[2];
            a[0] = new dog();
            a[1] = new cat();
            for(int i=0;i<a.Length;i++)
            {
                a[i].Makesound();
            }
            Console.ReadKey();

        }
    }
}
