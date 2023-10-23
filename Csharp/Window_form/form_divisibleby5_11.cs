using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_divisibleBy5_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//  wap to check wheather a no is divisible by 5 and 11 or not.
            int num;
            num = Convert.ToInt32(textBox1.Text);
            if(num%5==0 && num%11==0)
            {
                label2.Text = "No is divisible by 5 and 11";
            }
            else
            {
                label2.Text = "No is not divisible by 5 and 11";
            }
        }
    }
}
