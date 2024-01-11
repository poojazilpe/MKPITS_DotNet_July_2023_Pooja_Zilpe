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

namespace Productcategory
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public enum Nationality { Indian,NRI}
        Nationality nat;

        string cs = "server=DESKTOP-3NEL5ND\\SQLEXPRESS; integrated security=true;database=Product_store";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            getcategory();
            getproduct();
            getprice();
            nat = Nationality.Indian;

        }
        public void getcategory()
        {
            con = new SqlConnection(cs);
            da = new SqlDataAdapter("select * from TableProductCategory", con);
            ds = new DataSet();
            da.Fill(ds, "tpc");
            comboBox1.DataSource = ds.Tables["tpc"];
            comboBox1.DisplayMember = "Product_Type_Name";
            comboBox1.ValueMember = "Product_Category_id";
        }
        public void getproduct()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                con = new SqlConnection(cs);
                da = new SqlDataAdapter("select * from TableProduct where Product_Category_id=@pci", con);
                da.SelectCommand.Parameters.AddWithValue("@pci", comboBox1.SelectedValue);
                ds = new DataSet();
                da.Fill(ds, "tp");
                comboBox2.DataSource = ds.Tables["tp"];
                comboBox2.DisplayMember = "ProductName";
                comboBox2.ValueMember = "ProductId";
            }
        }
        public void getprice()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                con = new SqlConnection(cs);
                da = new SqlDataAdapter("select * from TableProduct where ProductId=@pid", con);
                da.SelectCommand.Parameters.AddWithValue("@pid", comboBox2.SelectedValue);
                ds = new DataSet();
                da.Fill(ds, "tp1");
                foreach(DataRow dr in ds.Tables["tp1"].Rows)
                {
                    textBox9.Text = dr["ProductPrice"].ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  textBox10.Text = "0";
            textBox11.Text = "0";

            getproduct();

            string catname = comboBox1.Text;
            if (comboBox1.Text != "System.Data.DataRowView")
            {
                con = new SqlConnection(cs);
                da = new SqlDataAdapter("select * from TableProductGSTDetail where GstDetail_Name=@gn", con);
                da.SelectCommand.Parameters.AddWithValue("@gn", catname);
                ds = new DataSet();
                da.Fill(ds, "tpgd");
                foreach(DataRow dr in ds.Tables["tpgd"].Rows)
                {
                    textBox3.Text = dr["cgst"].ToString();
                    textBox4.Text = dr["sgst"].ToString();
                    textBox5.Text = dr["igst"].ToString();
                }
            }
            
            
        }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox10.Text = "0";
            textBox11.Text = "0";
            getprice();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar!='.')
            {
                e.Handled = true;
                MessageBox.Show("Enter only number");

            }
        }

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                nat = Nationality.Indian;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                nat = Nationality.NRI;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                double quantity = Convert.ToDouble(textBox10.Text);
                double price = Convert.ToDouble(textBox9.Text);
                double ta = quantity * price;
                textBox11.Text = ta.ToString();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            



        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            //double gst = Convert.ToDouble(textBox11.Text) * Convert.ToDouble(textBox3.Text) / 100;
            
            //textBox6.Text = gst.ToString();




        }
    }
}
