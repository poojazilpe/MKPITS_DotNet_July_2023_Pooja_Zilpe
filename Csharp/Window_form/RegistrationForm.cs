using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_mdi
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name : " + textBox1.Text + "\n");
            sb.Append("Email : " + textBox2.Text + "\n");
            sb.Append("Age : " + numericUpDown1.Value+"\n");
            string gender = null;
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            sb.Append("Gender : "+gender+"\n");
            sb.Append("Country : " + comboBox1.Text + "\n");
            sb.Append("City : " + comboBox2.Text + "\n");

            label8.Text = sb.ToString();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            switch(comboBox1.Text)
            {
                case "India":
                    comboBox2.Items.Add( "Nagpur");
                    comboBox2.Items.Add("Amravti");
                    break;
                case "USA":
                    comboBox2.Items.Add("LA");
                    comboBox2.Items.Add("California");
                    break;
                    

            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
                
        }
    }
}
