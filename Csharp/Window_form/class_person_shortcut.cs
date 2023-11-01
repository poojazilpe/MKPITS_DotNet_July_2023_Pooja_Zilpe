using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_person_shortcut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person3 p = new Person3();
            p.Name = textBox1.Text; // it will call set method 
            p.Age = Convert.ToInt32(textBox2.Text);
            p.Address = textBox3.Text;


            StringBuilder sb = new StringBuilder();
            sb.Append("Name : " + p.Name + "\n"); // it will call get method
            sb.Append("Age : " + p.Age + "\n");
            sb.Append("Address : " + p.Address + "\n");
            label4.Text = sb.ToString();


           
        }
    }
}
