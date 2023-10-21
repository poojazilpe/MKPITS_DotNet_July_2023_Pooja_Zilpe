using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_bonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int empno, total, salary, bonus=0;
            string name, design;
            empno = Convert.ToInt32(textBox1.Text);
            salary= Convert.ToInt32(textBox3.Text);
            name = (textBox2.Text);
            design = (textBox4.Text);
            if (design == "manager") 
            {
                bonus = 5000;
            }
            else if (design == "clerk") 
            {
                bonus = 2000;
            }
            else if (design == "peon") 
            {
                bonus = 1000;
            }
            total = salary + bonus;
            label5.Text = "Total Salary = " + total;
        }
    }
}
