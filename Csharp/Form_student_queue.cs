using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace form_student_queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue q = new Queue();
        Student s;
        private void button1_Click(object sender, EventArgs e)
        {
            s = new Student(Convert.ToInt32(textBox1.Text), textBox2.Text);

            q.Enqueue(s);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Student s in q)
            {
                sb.Append("Roll No : "+s.rno+"Name : " +s.name+ "\n");
            }
            label3.Text = sb.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            q.Dequeue();
            StringBuilder sb1 = new StringBuilder();
            foreach (Student s in q)
            {
                sb1.Append("Roll No : " + s.rno + "Name : " + s.name + "\n");
            }
            label3.Text = sb1.ToString();
        }
    }
}
