using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_days1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(textBox1.Text);
            if(day == 1)
            {
                label2.Text = "Monday";
            }
            else if (day == 2 )
            {
                label2.Text = "Tuesday";
            }
            else if (day == 3)
            {
                label2.Text = "Wednesday";
            }
            else if (day == 4)
            {
                label2.Text = "Thursday";
            }
            else if (day == 5)
            {
                label2.Text = "Friday";
            }
            else if (day == 6)
            {
                label2.Text = "Saturday";
            }
            else if (day == 7)
            {
                label2.Text = "Sunday";
            }
            else 
            {
                label2.Text = "Invalid";
            }
        }
    }
}
