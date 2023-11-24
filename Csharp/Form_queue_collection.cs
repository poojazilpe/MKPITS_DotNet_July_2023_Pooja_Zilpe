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

namespace Form_queue_collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue q = new Queue();
        private void button1_Click(object sender, EventArgs e)
        {
            q.Enqueue(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in q)
            {
                sb.Append(s + " " + "\n");
            }
            label2.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            q.Dequeue();
            foreach(string s in q)
            {
                sb1.Append(s + " " + "\n");
            }
            label2.Text = sb1.ToString();
        }
    }
}
