using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_rectangle
{
    class program
    {
        class Rectangle
        {
            int height, width;
        float area;
            public void getdata(int height,int width)
            {
            this.height = height;
            this.width = width;
            area = height * width;
            }
        public void displaydata()
        {
            Console.WriteLine("Area of rectangle :" + area);
        }
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.getdata(5, 10);
            rect.displaydata();
            Console.ReadKey();
        }
    }
}
