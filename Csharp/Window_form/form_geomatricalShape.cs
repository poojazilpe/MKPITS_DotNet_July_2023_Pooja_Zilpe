using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_geomatricalShape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r, l, b, s,choice;
            float area;
            choice = Convert.ToInt32(textBox1.Text);
            if(choice==1)
            {
                r= Convert.ToInt32(textBox2.Text);
                area = 3.14f * r * r;
                label7.Text = "Area of Circle : " + area;
            }
            else if(choice==2)
                {
                    l = Convert.ToInt32(textBox4.Text);
                    b = Convert.ToInt32(textBox5.Text);
                area = l*b;
                    label7.Text = "Area of Rectangle : " + area;
                }
            else if (choice == 3)
            {
                s = Convert.ToInt32(textBox3.Text);
                
                area = s * s;
                label7.Text = "Area of Rectangle : " + area;
            }
            else
            {
                label7.Text = "Invalid no" ;
            }



        }
    }
}
