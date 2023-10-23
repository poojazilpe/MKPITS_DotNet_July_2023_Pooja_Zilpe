using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_elictricbill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int cid, unit;
            float total, surcharge = 0, finalamt = 0, chrgunit = 0;
            string name;
            cid = Convert.ToInt32(textBox1.Text);
            name = (textBox2.Text);
            unit = Convert.ToInt32(textBox3.Text);
            if(unit<199)
            {
                chrgunit = 1.20f;
            }
            else if(unit>=200 && unit<400)
            {
                chrgunit = 1.50f;
            }
            else if (unit >= 400 && unit < 600)
            {
                chrgunit = 1.80f;
            }
            else
            {
                chrgunit = 2.00f;
            }
            total = unit * chrgunit;
            if(total>=400)
            {
                surcharge = total * 0.15f;
            }
            finalamt = total + surcharge;
            label4.Text = "Customer Id : "+cid;
            label5.Text = "Customer Name : " + name;
            label6.Text = "Unit Consumed : " + unit;
            label7.Text = "Total : " + total;
            label8.Text = "Surcharge : " + surcharge;
            label9.Text = "Final Amount: " + finalamt;
            label10.Text = "Charge Unit : " + chrgunit;

        }
    }
}
