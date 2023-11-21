using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_shape
{
    class shape
    {
        public int l;
        public int b;
        

        public virtual void calculatearea(int l,int b)
        {
            Console.WriteLine("Area ");
        }

    }
    class rectangle:shape
    {
       
        public override void calculatearea(int l,int b)
        {
            this.l = l;
            this.b = b;
            float area = l * b;
            Console.WriteLine("Area of rectangle : "+area);
        }
    }
    class circle : shape
    {
        
        public override void calculatearea(int l,int b)
        {
            this.l = l;
            this.b = b;
            float area = 0.5f*l*b;
            Console.WriteLine("Area of triangle : " + area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            shape s;
            s= new rectangle();
            s.calculatearea(5,6);
            s = new circle();
            s.calculatearea(2,3);
            Console.ReadKey();
        }
    }
}
