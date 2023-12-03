using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_hra_basic_salary_Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp= new Employee();
            
            string name = textBox1.Text;
            int basic_salary = Convert.ToInt32(textBox2.Text);
            string designation = textBox3.Text;
            emp.display(name,basic_salary,designation);
            label4.Text = "Hra : " + emp.hra;
            label5.Text = "Bonus : " + emp.bonus;

            
            label6.Text = "Total Salary: " + emp.total;

        }
    }
}
