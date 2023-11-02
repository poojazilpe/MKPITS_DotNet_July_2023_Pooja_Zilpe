using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_form_product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = textBox1.Text;
            p.ProductPrice = Convert.ToInt32(textBox2.Text);
            p.StockQuantity= Convert.ToInt32(textBox3.Text);
           
            
            if(p.StockQuantity>0 && p.QuantityAvai>p.StockQuantity)
            {
                p.RemainQuantity = p.QuantityAvai - p.StockQuantity;
                p.total = p.StockQuantity * p.ProductPrice;
                StringBuilder sb = new StringBuilder();
                sb.Append("Product Name :" + p.ProductName + "\n");
                sb.Append("Product Price : " + p.ProductPrice + "\n");
                sb.Append("Remaining Stock Quantity : " + p.RemainQuantity + "\n");
                sb.Append("Total Price" + p.total + "\n");
                label4.Text = sb.ToString();
            }
            
            


        }
    }
}
