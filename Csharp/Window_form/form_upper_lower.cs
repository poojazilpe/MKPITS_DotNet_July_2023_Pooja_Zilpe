using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_upper_lowercase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ch;
            ch = Convert.ToChar(textBox1.Text);
            if(ch>='a' && ch<='z')
            {
                label2.Text = "This is lowercase";
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                label2.Text = "This is Uppercase";
            }
        }
    }
}
