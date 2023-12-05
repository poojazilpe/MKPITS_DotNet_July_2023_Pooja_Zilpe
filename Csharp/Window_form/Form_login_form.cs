using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("User Name :" + textBox1.Text+"\n");
            sb.Append("Password :" + textBox2.Text+"\n");
            string gender = null;
            if(radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            sb.Append("Gender : " + gender + "\n");
            if(checkBox1.Checked)
            {
                sb.Append("Course :" + checkBox1.Text + "\n");
            }
            else if(checkBox2.Checked)
            {
                sb.Append("Course :" + checkBox2.Text + "\n");
            }
            sb.Append("City :" + comboBox1.Text + "\n");
            label6.Text = sb.ToString();


        }
    }
}
