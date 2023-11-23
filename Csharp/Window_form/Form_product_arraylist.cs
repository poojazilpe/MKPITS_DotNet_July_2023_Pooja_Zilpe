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

namespace Form_Product_arraylist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Product p;
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            p = new Product(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text));
            ar.Add(p);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Product p in ar)
            {
                sb.Append("Product Id : " + p.id + "\n");
                sb.Append("Product Name : " + p.name + "\n");
                sb.Append("Product Rate : " + p.rate + "\n");
                sb.Append("-----------------------------------\n");
            }
            label4.Text = sb.ToString();
        }
    }
}
