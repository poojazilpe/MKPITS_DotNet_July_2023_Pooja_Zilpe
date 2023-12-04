using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_combobox_bonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string name = textBox1.Text;
            int sal = Convert.ToInt32(textBox2.Text);
            string design = comboBox1.Text;
            float bonus=0.0f;
            float tsal;
            switch(design)
            {
                case "manager":
                    bonus = sal * 0.45f;
                    break;
                case "clerk":
                    bonus = sal * 0.25f;
                    break;
                case "peon":
                    bonus = sal * 0.15f;
                    break;
                    
            }
            tsal = sal + bonus;
            if (checkBox1.Checked && checkBox2.Checked)
            {
                sb.Append("Bonus :" + bonus+"\n");
                sb.Append("Total Salary :" + tsal + "\n");
            }
            else if(checkBox1.Checked)
            {
                sb.Append("Bonus :" + bonus + "\n");
            }
            else if (checkBox2.Checked)
            {
                sb.Append("Total Salary :" + tsal + "\n");
            }
            label4.Text = sb.ToString();
                
        }
    }
}
