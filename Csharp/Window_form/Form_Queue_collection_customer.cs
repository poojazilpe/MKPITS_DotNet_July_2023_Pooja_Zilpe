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

namespace Form_Queue_collection_Customer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Customer c;
        Queue q = new Queue();
        private void button1_Click(object sender, EventArgs e)
        {
            c = new Customer(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text);
            q.Enqueue(c);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Customer c in q)
            {
                sb.Append("Customer Id : " + c.cust_id+"\n");
                sb.Append("Customer Name : " + c.name+"\n");
                sb.Append("Customer Email: " + c.email+"\n");
            }
            label4.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            q.Dequeue();
            StringBuilder sb = new StringBuilder();
            foreach (Customer c in q)
            {
                sb.Append("Customer Id : " + c.cust_id+"\n");
                sb.Append("Customer Name : " + c.name+"\n");
                sb.Append("Customer Email: " + c.email+"\n");
            }
            label4.Text = sb.ToString();
        }
    }
}
