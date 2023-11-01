using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_form_student
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
            Student s = new Student();
            s.RollNo= Convert.ToInt32(textBox1.Text);
            s.Name = textBox2.Text;
            s.mark[0] = Convert.ToInt32(textBox3.Text);
            s.mark[1] = Convert.ToInt32(textBox4.Text);
            s.mark[2] = Convert.ToInt32(textBox5.Text);
            
            StringBuilder sb = new StringBuilder();
            s.getdata(s.RollNo, s.Name,s.mark);
            sb.Append("Student Roll No: " + s.RollNo+"\n" );
            sb.Append("Student Name: " + s.Name+"\n");
            sb.Append("Total : " + s.total+"\n");
            sb.Append("Avrage : " + s.avg+"\n");
            label6.Text = sb.ToString();


        }
    }
}
