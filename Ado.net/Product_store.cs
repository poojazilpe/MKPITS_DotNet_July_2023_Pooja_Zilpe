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

namespace Product_Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string cs = "server=DESKTOP-3NEL5ND\\SQLEXPRESS; integrated security=true;database=Product_store";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        private void Form1_Load(object sender, EventArgs e)
        {
            pcategory();
            product();
        }
        public void pcategory()
        {
            try
            {
                con = new SqlConnection(cs);
                da = new SqlDataAdapter("select * from TableProductCategory", con);
                ds = new DataSet();
                da.Fill(ds, "TableProductCategory");
                comboBox1.DataSource = ds.Tables["TableProductCategory"];
                comboBox1.DisplayMember = "Product_Type_Name";
                comboBox1.ValueMember = "Product_Category_id";
            }
            catch(SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        public void product()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(cs);
                    da = new SqlDataAdapter("select * from TableProduct where Product_Category_id=@Product_Category_id", con);
                    da.SelectCommand.Parameters.AddWithValue("@Product_Category_id", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "TableProduct");
                    comboBox2.DataSource = ds.Tables["TableProduct"];
                    comboBox2.DisplayMember = "ProductName";
                    comboBox2.ValueMember = "ProductId";


                }
                catch(SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            product();
        }
        public enum Nationality { India,NRI}
        Nationality nat;
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            if(selectedDate.Date<DateTime.Today)
            {
                MessageBox.Show("Please select a payment date that is on or after today's date.");
            }
            else if(textBox1.Text=="")
            {
                MessageBox.Show("Full name can't be blank");
            }
            else
            {
                if(radioButton1.Checked)
                {
                    nat = Nationality.India;
                }
                else if(radioButton2.Checked)
                {
                    nat = Nationality.NRI;
                }
                MessageBox.Show("Nationality" + nat);
            }
            double contact = Convert.ToDouble(textBox2.Text);
            int qty= Convert.ToInt32(textBox3.Text);
            MessageBox.Show("Save record successfully");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        float gst = 0;
        float cgst, sgst, igst;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                gst = cgst + sgst;
            }
            else
            {
                gst=igst;
            }
        }
        public void gstdetail()
        {
            if(nat.ToString()=="India")
            {
                textBox4.Text = "20%";
                float ta = Convert.ToSingle(textBox5.Text);
                float qty = Convert.ToSingle(textBox3.Text);
                

            }
        }
    }
}
