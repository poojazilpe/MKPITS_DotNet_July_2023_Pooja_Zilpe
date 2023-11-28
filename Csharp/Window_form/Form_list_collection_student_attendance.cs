using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_list_collection_studentattendace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> li = new List<string>();
        Attendance a = null;
        private void button1_Click(object sender, EventArgs e)
        {
            a = new Attendance(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
            li.Add(textBox1.Text);
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int totalp = 0;
            int totala = 0;
            StringBuilder sb = new StringBuilder();

            foreach (string s in li)
            {
                if (a.pre == "a")
                {
                    totala++;
                }
                if (a.pre == "p")
                {
                    totalp++;
                }

                sb.Append("Student Roll No :" + a.rno + "\n");
                sb.Append("Student Name :" + a.name + "\n");
                sb.Append("Student DOA :" + a.dot + "\n");
                sb.Append("Student Presenty(a or p) :" + a.pre + "\n");

                sb.Append("--------------------------------------" + "\n");
                sb.Append("Student Total Presenty :" + totalp + "\n");
                sb.Append("Student Total Absenty :" + totala + "\n");
                sb.Append("--------------------------------------" + "\n");

            }
            label5.Text = sb.ToString();
        }
    }
}
