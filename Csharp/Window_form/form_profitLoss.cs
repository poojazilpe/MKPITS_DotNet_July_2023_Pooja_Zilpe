using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_profitLoss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s, c, p, l;
            s = Convert.ToInt32(textBox1.Text);
            c = Convert.ToInt32(textBox2.Text);
            p = s - c;
            l = c - s;
            if(s>c)
            {
                label3.Text = "Profit amount : " + p;
            }
            else
            {
                label3.Text = "Loss amount : " + l;
            }
        }
    }
}
