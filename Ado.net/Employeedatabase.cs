using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employeedatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if(radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            string str = "server=DESKTOP-3NEL5ND\\SQLEXPRESS;integrated security=true;database=Employeedb";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                string strcmd = "insert into employees values('" + textBox1.Text + "','"+comboBox1.Text+"','"+gender+ "','" + textBox3.Text + "','" + richTextBox1.Text + "')";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                cmd.ExecuteNonQuery();
                con.Close();
                label4.Text = "Record Insert Sucessful";
                textBox1.Clear();
                comboBox1.Items.Clear();
                
                textBox3.Clear();
                richTextBox1.Clear();
                textBox1.Focus();



            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "server=DESKTOP-3NEL5ND\\SQLEXPRESS;integrated security=true;database=Employeedb";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                string strcmd = "update employees set Emp_add= '" + richTextBox1.Text + "' where Emp_name='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                cmd.ExecuteNonQuery();
                con.Close();
                label4.Text = "Record update Sucessful";
                textBox1.Clear();
                comboBox1.Items.Clear();

                textBox3.Clear();
                richTextBox1.Clear();
                textBox1.Focus();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "server=DESKTOP-3NEL5ND\\SQLEXPRESS;integrated security=true;database=Employeedb";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                string strcmd = "delete from employees where  Emp_add= '" + richTextBox1.Text + "' or  Emp_name='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                cmd.ExecuteNonQuery();
                con.Close();
                label4.Text = "Record delete Sucessful";
                textBox1.Clear();
                comboBox1.Items.Clear();

                textBox3.Clear();
                richTextBox1.Clear();
                textBox1.Focus();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "server=DESKTOP-3NEL5ND\\SQLEXPRESS;integrated security=true;database=Employeedb";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                string strcmd = "select * from employees where Emp_name='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(strcmd, con);
                SqlDataReader dr;
                int flag = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    flag = 1;

                    richTextBox1.Text = dr["Emp_add"].ToString();
                    textBox3.Text = dr["Emp_contact"].ToString();
                }
                dr.Close();
                con.Close();
                if (flag == 0)
                {
                    label4.Text = "record not found";
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
    }
}

        
    

