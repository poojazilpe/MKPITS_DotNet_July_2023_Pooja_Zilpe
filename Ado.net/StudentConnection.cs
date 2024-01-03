using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            string g = null;
            if(radioButton1.Checked)
            {
                g = "Male";
            }
            if(radioButton2.Checked)
            {
                g = "Female";
            }

            string h = null;
            if(checkBox1.Checked)
            {
                h = "Music";
            }
            if(checkBox2.Checked)
            {
                if(h!=null)
                {
                    h = h + " " + "Reading";
                }
                else
                {
                    h = "Reading";
                }
            }
            string result = s.InsertStudent(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            ClearText();

        }
        public void ClearText()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            string g = null;
            if(radioButton1.Checked)
            {
                g = "Male";
            }
            if(radioButton2.Checked)
            {
                g = "Female";
            }
            string h = null;
            if(checkBox1.Checked)
            {
                h = "Music";
            }
            else if(checkBox2.Checked)
            {
                if(h!=null)
                {
                    h = h + " " + "Reading";
                }
                else
                {
                    h = "Reading";
                }
            }
            string result = s.UpdateStudent(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            ClearText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            string result = s.DeleteStudent(Convert.ToInt32(textBox1.Text), textBox2.Text);
            label7.Text = result;
            ClearText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Student1> li = new List<Student1>();
            Student s = new Student();
            li = s.SearchStudent(Convert.ToInt32(textBox1.Text));
            textBox2.Text = li[0].Student_Name;
            string g = li[0].Gender;
            if(g=="Male")
            {
                radioButton1.Checked = true;
            }
            else if(g=="Female")
            {
                radioButton2.Checked = true;
            }
            string h = li[0].Hobby;
            if(h=="Music")
            {
                checkBox1.Checked = true;
            }
            else if(h=="Reading")
            {
                checkBox2.Checked = true;
            }
            comboBox1.Text = li[0].City;
            dateTimePicker1.text = li[0].Dob;
        }
    }
}
