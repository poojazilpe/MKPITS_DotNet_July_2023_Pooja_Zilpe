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

namespace Form_stack_collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack sk = new Stack();
        private void button1_Click(object sender, EventArgs e)
        {
            sk.Push(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string s in sk)
            {
                sb.Append("Name : " + s+"\n");
            }
            label2.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sk.Pop();
            foreach (string s in sk)
            {
                sb.Append("\n Name : " + s);
            }
            label2.Text = sb.ToString();

        }
    }
}
