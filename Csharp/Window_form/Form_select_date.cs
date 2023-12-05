using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_select_date
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
            string dob = dateTimePicker1.Text;
            sb.Append("Date Of Birth :" + dob + "\n");

            int yr = dateTimePicker1.Value.Year;
            sb.Append("Date Of Year :" + yr + "\n");

            int cyr = DateTime.Now.Year;
            sb.Append("Current Year :" + cyr + "\n");

            int age = cyr - Convert.ToInt32(yr);
            sb.Append("Now your age is :" + age + "\n");
            label2.Text = sb.ToString();
        }
    }
}
