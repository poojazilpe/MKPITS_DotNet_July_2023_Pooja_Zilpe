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
                da = new SqlDataAdapter("select * from TableNation1", con);
                ds = new DataSet();
                da.Fill(ds, "TableNation1");
                comboBox1.DataSource = ds.Tables["TableNation1"];
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
        public enum Category { Student, It_professional }
        public enum Gender { Male, Female, Other }
        Category cat;
        Gender gen;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Full name cant be blank");
            }
            else
            {
                // for category
                if (radioButton1.Checked)
                {
                    cat = Category.Student;
                }
                else if (radioButton2.Checked)
                {
                    cat = Category.It_professional;
                }
                MessageBox.Show("Category" + cat);

                if (radioButton3.Checked)
                {
                    gen = Gender.Male;
                }
                else if (radioButton4.Checked)
                {
                    gen = Gender.Female;
                }
                else if (radioButton5.Checked)
                {
                    gen = Gender.Other;
                }
                // MessageBox.Show("Gender selected" + gen);
                savecoursereg(cat, gen);
            }
        }
        public void savecoursereg(Category c, Gender g)
        {
            try
            {
                con.Open();
                string str = "insert into TableCourseRegDetail values (@CategoryId,@FullName,@GenderId)";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@CategoryId", Convert.ToInt32(c));
                cmd.Parameters.AddWithValue("@FullName", textBox1.Text);
                cmd.Parameters.AddWithValue("@GenderId", Convert.ToInt32(g));
                
                cmd.ExecuteNonQuery();
                con.Close();
                insertregaddress();
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        public void insertregaddress()
        {
            try
            {
                con.Open();
                string str = "select max(CourseRegId) from TableCourseRegDetail";
                SqlCommand cmd1 = new SqlCommand(str, con);
                int mcid = Convert.ToInt32(cmd1.ExecuteScalar());
                //MessageBox.Show(mcid.ToString());
                string str1 = "insert into TableRegAdddress values(@CourseRegId,@NationId,@StateId,@CityId)";
                SqlCommand cmd2 = new SqlCommand(str1, con);
                cmd2.Parameters.AddWithValue("@CourseRegId", mcid);
                cmd2.Parameters.AddWithValue("@NationId", comboBox1.SelectedValue);
                cmd2.Parameters.AddWithValue("@StateId", comboBox2.SelectedValue);
                cmd2.Parameters.AddWithValue("@CityId", comboBox3.SelectedValue);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Stored TableRegAddress");
                con.Close();
                insertFeeDetail();
            }
            catch(SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }



        }
    
        public void insertFeeDetail()
        {
            try
            {



                con.Open();

                string str = "select max(CourseRegId) from TableCourseRegDetail";
                SqlCommand cmd11 = new SqlCommand(str, con);
                int mcid = Convert.ToInt32(cmd11.ExecuteScalar());

                string str1 = "insert into TableFeeDetail values(@CourseRegId,@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                cmd1.Parameters.AddWithValue("@CourseRegID", mcid);
                cmd1.Parameters.AddWithValue("@TotalAmount", textBox2.Text);
                cmd1.Parameters.AddWithValue("@MinPer", fp);
                cmd1.Parameters.AddWithValue("@PaidAmount", textBox3.Text);
                cmd1.Parameters.AddWithValue("@BalAmount", textBox4.Text);
                cmd1.Parameters.AddWithValue("@PaidDate", dateTimePicker1.Value);
                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Stored TableFeeDetail");
            }
            catch(SqlException ee)
            {
                MessageBox.Show(ee.ToString());
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
        float fp = 0;
        float bamt = 0;

        public void calculatefees()
        {
            if (cat.ToString() == "Student") 
            {
                textBox2.Text = "1000";
                float ta = Convert.ToSingle(textBox2.Text);
                 fp = ta * 0.5f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 50 per");
                }
                else
                {
                     bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
            else if (cat.ToString() == "It_professional")
            {
                textBox2.Text = "3000";

                float ta = Convert.ToSingle(textBox2.Text);
                 fp = ta * 0.8f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 80 per");
                }
                else
                {
                     bamt = ta - amt;
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

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            getnation();
            getstate();
            getcity();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = true;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            dateTimePicker1.Text = DateTime.Now.ToString();


        }

    }
}

