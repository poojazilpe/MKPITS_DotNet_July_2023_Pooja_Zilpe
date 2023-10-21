using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_marksheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String grade;
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int num3 = Convert.ToInt32(textBox3.Text);
            int total = num1 + num2 + num3;
            float per = (total / 300.0f) * 100.0f;
            label4.Text = "Total = " + total;
            label5.Text = "Percentange = " + per;
            if (per >= 75)
            {
                grade = "Distinction";
            }
            else if (per >= 60 && per < 75) 
                grade = "First";
            else if (per >= 50 && per < 60) 
                grade = "Second";
            else if (per >= 40 && per < 50) 
                grade = "Third";
            else
                grade = "fail";
            label6.Text = "Grade = " + grade;

        }
    }
}
