using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_alphabate_digit_character
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //wap to input any character and check wheather it is alphabate, digit or special character.
            int ch;
            ch = Convert.ToChar(textBox1.Text);
            
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                label2.Text = "This is a Alphabate";
            }
            else if (ch >='0' && ch <= '9')
            {
                label2.Text = "This is a Digit";
            }
            else
            {
                label2.Text = "This is a Special character";
            }
        }
    }
}
