using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abstact_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account a = null;
            int accno = Convert.ToInt32(textBox1.Text);
            int amt= Convert.ToInt32(textBox2.Text);
            string tt = textBox3.Text;
            if(tt=="saving")
            {
                a = new Saving();
            }
            else if (tt == "current")
            {
                a = new Current();
            }
            label4.Text = a.deposit(accno, amt);
            label5.Text = a.show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account a = null;
            int accno = Convert.ToInt32(textBox1.Text);
            int amt = Convert.ToInt32(textBox2.Text);
            string tt = textBox3.Text;
            if (tt == "saving")
            {
                a = new Saving();
            }
            else if (tt == "current")
            {
                a = new Current();
            }
            label4.Text = a.withdrawl(accno, amt);
            label5.Text = a.show();
        }
    }
}
