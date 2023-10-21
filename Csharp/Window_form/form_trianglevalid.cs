using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_trianglevalid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox1.Text);
            int c = Convert.ToInt32(textBox1.Text);
            if(a+b+c==180)
            {
                label4.Text = "Triangle are valid";

            }
            else
            {
                label4.Text = "Triangle are not valid";

            }
            
        }
    }
}
