using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_dictionary_attendance_collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, Attendance> d = new Dictionary<int, Attendance>();
        Attendance a = null;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new Attendance(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
            d.Add(Convert.ToInt32(textBox1.Text), a);
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
            
            foreach(KeyValuePair<int,Attendance> k in d)
            {
                if(k.Value.pre=="a")
                {
                    totala++;
                }
                if (k.Value.pre == "p")
                {
                    totalp++;
                }

                sb.Append("Student Roll No :" + k.Key+"\n");
                sb.Append("Student Name :" + k.Value.name+"\n");
                sb.Append("Student DOA :" + k.Value.dot+"\n");
                sb.Append("Student Presenty(a or p) :" + k.Value.pre+"\n");

                sb.Append("--------------------------------------"+"\n");
                sb.Append("Student Total Presenty :" + totalp+"\n");
                sb.Append("Student Total Absenty :" + totala+"\n");
                sb.Append("--------------------------------------"+"\n");

            }
            label5.Text = sb.ToString();
        }
    }
}
