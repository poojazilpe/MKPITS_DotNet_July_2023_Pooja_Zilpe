using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_customer_product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            switch(comboBox1.Text)
            {
                case "Electronics" :
                    comboBox2.Items.Add("Laptop");
                    comboBox2.Items.Add( "Freez");
                    comboBox2.Items.Add ("Washing Machine");
                    break;

                case "Furniture":
                    comboBox2.Items.Add("Sofaset");
                    comboBox2.Items.Add("Dressing Table");
                    comboBox2.Items.Add("Bed");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Customer Name : " + textBox1.Text);
            sb.Append("Customer Number : " + maskedTextBox1.Text);
            if(textBox1.Text== "" && textBox2.Text== "" && textBox3.Text=="")
            {
                MessageBox.Show("Enter Details");
            }
            else
            {
                sb.Append("Customer Name : " + textBox1.Text);
                sb.Append("Customer Number : " + maskedTextBox1.Text);
                sb.Append("Product Category : " + comboBox1.Text);
                sb.Append("Product Item : " + comboBox2.Text);
                sb.Append("Quantity : " + textBox2.Text);
                sb.Append("Rate : " + textBox3.Text);
                int qty = Convert.ToInt32(textBox2.Text);
                int rate= Convert.ToInt32(textBox3.Text);
                int Total = qty * rate;
                sb.Append("Total : " + Total);
            }
            label8.Text = sb.ToString();
        }
    }
}
