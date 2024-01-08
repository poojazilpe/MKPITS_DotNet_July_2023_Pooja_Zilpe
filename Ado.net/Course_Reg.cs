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

namespace Course_Reg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        string cs = "server=DESKTOP-3NEL5ND\\SQLEXPRESS;integrated security=true;database=Course_reg";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        private void Form1_Load(object sender, EventArgs e)
        {
            getnation();
            getstate();
            getcity();
            if (radioButton1.Checked)
                textBox2.Text = "1000";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getstate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getcity();
        }
        public void getnation()
        {
            try
            {
                con = new SqlConnection(cs);
                da = new SqlDataAdapter("select * from TableNation", con);
                ds = new DataSet();
                da.Fill(ds, "TableNation");
                comboBox1.DataSource = ds.Tables["TableNation"];
                comboBox1.DisplayMember = "NationName";
                comboBox1.ValueMember = "NationId";
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        public void getstate()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(cs);
                    da = new SqlDataAdapter("select * from TableState where NationId=@NationId", con);
                    da.SelectCommand.Parameters.AddWithValue("@NationId", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "TableState");
                    comboBox2.DataSource = ds.Tables["TableState"];
                    comboBox2.DisplayMember = "StateName";
                    comboBox2.ValueMember = "StateId";
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }

            }
        }
        public void getcity()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(cs);
                    da = new SqlDataAdapter("select * from TableCity where StateId=@StateId", con);
                    da.SelectCommand.Parameters.AddWithValue("@StateId", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "TableCity");
                    comboBox3.DataSource = ds.Tables["TableCity"];
                    comboBox3.DisplayMember = "CityName";
                    comboBox3.ValueMember = "CityId";
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }
        enum Category { Student, It_professional }
        enum Gender { Male,Female,Other}
        Category cat;
        Gender gen;

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text=="")
            {
                MessageBox.Show("Full name cant be blank");
            }
            else
            {
                // for category
                if(radioButton1.Checked)
                {
                    cat = Category.Student;
                }
                else if(radioButton2.Checked)
                {
                    cat = Category.It_professional;
                }
                MessageBox.Show("Category" + cat);

                if(radioButton3.Checked)
                {
                    gen = Gender.Male;
                }
                else if(radioButton4.Checked)
                {
                    gen = Gender.Female;
                }
                else if (radioButton5.Checked)
                {
                    gen = Gender.Other;
                }
                MessageBox.Show("Gender selected" + gen);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                cat = Category.It_professional;
                textBox2.Text = "3000";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }
        }
        public void calculatefees()
        {
            if (cat.ToString() == "Student") 
            {
                textBox2.Text = "1000";
                float ta = Convert.ToSingle(textBox2.Text);
                float fp = ta * 0.5f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 50 per");
                }
                else
                {
                    float bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
            else if (cat.ToString() == "It_professional")
            {
                textBox2.Text = "3000";

                float ta = Convert.ToSingle(textBox2.Text);
                float fp = ta * 0.8f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 80 per");
                }
                else
                {
                    float bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cat = Category.Student;
                textBox2.Text = "1000";
                textBox3.Text = "0";
                textBox4.Text = "0";
                //  calculatefees();
            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            calculatefees();
        }
    }
 }

