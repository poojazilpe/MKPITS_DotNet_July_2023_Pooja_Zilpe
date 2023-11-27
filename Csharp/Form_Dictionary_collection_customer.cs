using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Dictionary_collection_customer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> d = new Dictionary<int, string>();
        private void button1_Click(object sender, EventArgs e)
        {
            Customer c=new Customer( Convert.ToInt32(textBox1.Text),textBox2.Text);
            d.Add(c.id, c.name);
            textBox1.Clear();
            textBox2.Clear();
            textBox2.Focus();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<int,string> k in d)
            {
                sb.Append("Id: " + k.Key + "Name : " + k.Value + "\n");
            }
            label3.Text = sb.ToString();
        }
    }
}
