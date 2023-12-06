using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_mdi
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 1000;
            int amt = Convert.ToInt32(textBox2.Text);
            StringBuilder sb = new StringBuilder();
            sb.Append("Account No :" + textBox1.Text + "\n");
            sb.Append("Amount :" +amt + "\n");
            
            if (radioButton1.Checked)
            {
                bal = bal + amt;
                sb.Append("Amount deposit successfuly"+"\n");
            }
            else if (radioButton2.Checked)
            {
                bal = bal - amt;
                
                if(amt>bal)
                {
                    sb.Append("Insufficent Balance"+"\n");
                }
                else
                {
                    sb.Append("Amount withdrawl successfuly"+"\n");
                }
            }
            sb.Append("Balance is :" + bal);
            label4.Text = sb.ToString();
        }
    }
}
