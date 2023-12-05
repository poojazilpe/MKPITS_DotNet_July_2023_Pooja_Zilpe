using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_student_nformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter Name");
                MessageBox.Show("Please enter Age");
            }
            
           
            if(numericUpDown1.Value<=18)
            {
                MessageBox.Show("please enter age greater than 18");

            }
            else
            {
                sb.Append("Name : " + textBox1.Text);
                sb.Append("Age : " + numericUpDown1.Value.ToString());
            }
            label3.Text = sb.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }
    }
}
