using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_form_EmpSalary
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        //creating array of objects
        Employee[] emp = new Employee[3];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0] = new Employee();
            emp[1] = new Employee();
            emp[2] = new Employee();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<3)
            {
                emp[cnt].EmpId = Convert.ToInt32(textBox1.Text);
                emp[cnt].EmpName = textBox2.Text;
                emp[cnt].salary = Convert.ToDouble(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                if (cnt == 3)
                {
                    button1.Enabled=false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("Details of 3 Employees Accepted.");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Details of Employee are :" + "\n");
            for(int i=0;i<3;i++)
            {
                sb.Append("-------------------------------------" + "\n");
                sb.Append("Employee Id : " + emp[i].EmpId + "\n");
                sb.Append("Employee Name : " + emp[i].EmpName + "\n");
                sb.Append("Employee Salary : " + emp[i].salary + "\n");
                sb.Append("-------------------------------------" + "\n");
            }
            label4.Text = sb.ToString();
            //code for high salary
            double high = emp[0].salary;
            int foundat = 0;
            for(int i=0;i<3;i++)
            {
                
                    if (high< emp[i].salary)
                    {
                        high = emp[i].salary;
                        foundat = i;
                    }
                
            }
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("employee with highest salary : \n");
            sb1.Append("Employee Id : " + emp[foundat].EmpId + "\n");
            sb1.Append("Employee Name : " + emp[foundat].EmpName + "\n");
            sb1.Append("Employee Salary: " + emp[foundat].salary + "\n");
            label5.Text = sb1.ToString();
        }
    }
}
