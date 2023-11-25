using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Form_stack_collection_Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee emp;
        Stack s = new Stack();
        private void button1_Click(object sender, EventArgs e)
        {
            emp = new Employee(Convert.ToInt32(textBox1.Text),textBox2.Text,Convert.ToInt32(textBox3.Text),textBox4.Text);
            s.Push(emp);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
           
            foreach(Employee emp in s)
            {
                sb.Append("Employee Id :" + emp.empid+"\n");
                sb.Append("Employee Name :" + emp.name+"\n");
                sb.Append("Employee Salary:" + emp.salary+"\n");
                sb.Append("Employee Designation :" + emp.design+"\n");
            }
            label5.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            s.Pop();
            foreach (Employee emp in s)
            {
                sb.Append("Employee Id :" + emp.empid+"\n");
                sb.Append("Employee Name :" + emp.name+"\n");
                sb.Append("Employee Salary:" + emp.salary+"\n");
                sb.Append("Employee Designation :" + emp.design+"\n");
            }
            label5.Text = sb.ToString();
        }
    }
}
