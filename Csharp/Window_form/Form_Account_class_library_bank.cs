using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank;

namespace Form_Account_class_library_bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account a = null;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.accno = Convert.ToInt32(textBox1.Text);
            string res = a.deposit(Convert.ToInt32(textBox2.Text));
            label4.Text = res;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.accno = Convert.ToInt32(textBox1.Text);
            string res = a.withdrawl(Convert.ToInt32(textBox2.Text));
            label4.Text = res;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="saving")
            {
                a = new Saving();
            }
            if (comboBox1.Text == "current")
            {
                a = new Current();
            }
        }
    }
}
