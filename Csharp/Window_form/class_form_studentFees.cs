using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_form_studentFees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student1[] stu = new Student1[10];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            stu[0] = new Student1();
            stu[1] = new Student1();
            stu[2] = new Student1();
            stu[3] = new Student1();
            stu[4] = new Student1();
            stu[5] = new Student1();
            stu[6] = new Student1();
            stu[7] = new Student1();
            stu[8] = new Student1();
            stu[9] = new Student1();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<10)
            {
                stu[cnt].RollNo = Convert.ToInt32(textBox1.Text);
                stu[cnt].Name = (textBox2.Text);
                stu[cnt].Fees = Convert.ToInt32(textBox3.Text);
                stu[cnt].Date = (textBox4.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();

                if (cnt==10)
                {
                    button1.Enabled = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("Details of 10 Student Accepted");


                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Details of 10 student :"+"\n");
            for (int i = 0; i < 10; i++)
            {
                sb.Append("---------------------------------" + "\n");
                sb.Append("Student Roll No :" + stu[i].RollNo + "\n");
                sb.Append("Student Name :" + stu[i].Name + "\n");
                sb.Append("Student Fees :" + stu[i].Fees+ "\n");
                sb.Append("Student Date :" + stu[i].Date + "\n");
                sb.Append("---------------------------------" + "\n");
            }
            richTextBox1.Text = sb.ToString();
            
            int high = stu[0].Fees;
            int foundat = 0;
            for(int i=0;i<10;i++)
            {
                if(high<stu[i].Fees)
                {
                    high = stu[i].Fees;
                    foundat = i;
                }
            }
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Student Roll No : " + stu[foundat].RollNo + "\n");
            sb1.Append("Student Name : " + stu[foundat].Name + "\n");
            sb1.Append("Student Fees : " + stu[foundat].Fees + "\n");
            sb1.Append("Student Date : " + stu[foundat].Date + "\n");
            label6.Text =sb1.ToString();
        }
    }
}
