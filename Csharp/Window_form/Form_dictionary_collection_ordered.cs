using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_dictionary_collection_employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, Orders> d = new Dictionary<int, Orders>();
        Orders o = null;
        private void button1_Click(object sender, EventArgs e)
        {
            o = new Orders(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            d.Add(Convert.ToInt32(textBox1.Text), o);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 0;
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<int,Orders>k in d)
            {
               
                int amount = k.Value.rate * k.Value.qty;
                total = total + amount;
                sb.Append("Order :" + k.Key + "Item Name :" + k.Value.name + "Rate :" + k.Value.rate + "Quantity :" + k.Value.qty +"Amount :"+amount +"\n");
                
            }
            label5.Text = sb.ToString();
            MessageBox.Show("Total amount " + total);

        }
    }
}
