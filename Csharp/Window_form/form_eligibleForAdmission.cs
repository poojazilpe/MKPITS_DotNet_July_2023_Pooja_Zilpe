using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_EligibleforAdmission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int math, phy, che, total;
            math = Convert.ToInt32(textBox1.Text);
            phy = Convert.ToInt32(textBox2.Text);
            che = Convert.ToInt32(textBox3.Text);
            total = math + phy + che;
            label4.Text = "Total = " + total;
            if(math>=65 && phy>=55 && che>=50 && total==180)
            {
                label5.Text = "The candidate  eligible for Admission";
            }
            else
            {
                label5.Text = "The candidate  eligible for Admission";
            }
        }
    }
}
