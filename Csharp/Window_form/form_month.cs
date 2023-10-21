using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_days
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month;
            month = Convert.ToInt32(textBox1.Text);
            if(month== 1)
            {
                label2.Text = "January";
            }
            else if (month == 2)
            {
                label2.Text = "February";
            }
            else if (month ==3 )
            {
                label2.Text = "March";
            }
            else if (month == 4)
            {
                label2.Text = "April";
            }
            else if (month == 5)
            {
                label2.Text = "May";
            }
            else if (month == 6)
            {
                label2.Text = "June";
            }
            else if (month == 7)
            {
                label2.Text = "July";
            }
            else if (month == 8)
            {
                label2.Text = "August";
            }
            else if (month == 9)
            {
                label2.Text = "September";
            }
            else if (month == 10)
            {
                label2.Text = "October";
            }
            else if (month == 11)
            {
                label2.Text = "November";
            }
            else if (month == 12)
            {
                label2.Text = "December";
            }
            else
            {
                label2.Text = "Invalid";
            }





        }
    }
}
