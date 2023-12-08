using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_tab_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name : " + textBox1.Text+"\n");
            sb.Append("Date of Birth : " + maskedTextBox1.Text+"\n");
            sb.Append("Nationality : " + textBox2.Text+"\n");
            sb.Append("City : " + textBox3.Text+"\n");
            sb.Append("Address : " + richTextBox1.Text+"\n");
            sb.Append("Mother Tounge : " + textBox4.Text+"\n");
            sb.Append("Qualification : " + textBox5.Text+"\n");
            sb.Append("Address : " + textBox6.Text);
            label12.Text = sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First Name :" + textBox7.Text+"\n");
            sb.Append("Last Name :" + textBox8.Text+"\n");
            sb.Append("Father Name :" + textBox9.Text+"\n");
            sb.Append("Mother Name :" + textBox10.Text+"\n");
            sb.Append("Father Occupation :" + textBox11.Text+"\n");
            sb.Append("Mother Occupation :" + textBox12.Text+"\n");
            sb.Append("Date of Birth :" + maskedTextBox2.Text+"\n");
            sb.Append("Qualification :" + textBox14.Text+"\n");
            
            sb.Append("Address :" + richTextBox2.Text);
            string gender = null;
            if(radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                gender = radioButton3.Text;
            }
            sb.Append("Gender :" + gender+"\n");
            label22.Text = sb.ToString();
        }
    }
}
