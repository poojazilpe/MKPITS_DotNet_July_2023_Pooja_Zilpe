using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_checkbox_bonus_salary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string name = textBox1.Text;
            int salary = Convert.ToInt32(textBox2.Text);
            float bonus = salary * 0.45f;
            float tsal = salary + bonus;
            if (checkBox1.Checked && checkBox2.Checked)
            {
                sb.Append("Bonus : " + bonus + "\n");
                sb.Append("Total Salary :" + tsal);

            }
           else if (checkBox1.Checked)
            {
                sb.Append("Bonus : " + bonus + "\n");
            }
            else if (checkBox2.Checked)
            {
                sb.Append("Total Salary :" + tsal);
            }
            
            label3.Text = sb.ToString();
            
        }
    }
}
