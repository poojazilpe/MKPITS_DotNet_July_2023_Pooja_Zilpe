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

namespace Crudindexoperation
{
    public partial class Form1 : Form
    {
        public string connectionstring = "server=DESKTOP-3NEL5ND\\SQLEXPRESS;integrated security=true;database=Company";
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cb;
        public Form1()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select * from Employee2", connectionstring);
            ds = new DataSet();
            cb = new SqlCommandBuilder(da);
                da.Fill(ds, "Emp");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ds.Tables["Emp"];
            comboBox1.DisplayMember = "empid";

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["Emp"].NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = Convert.ToInt32(textBox4.Text);
            dr[4] = textBox5.Text;
            dr[5] = (textBox6.Text);
            dr[6] = Convert.ToInt32(textBox7.Text);
            ds.Tables["Emp"].Rows.Add(dr);
            da.Update(ds.Tables["Emp"]);
            MessageBox.Show("Data inserted Suceessfully");
            

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables["Emp"];
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in ds.Tables["Emp"].Rows)
            {
                if(dr[0].ToString()==textBox1.Text)
                {
                    try
                    {
                        dr[0] = textBox1.Text;
                        dr[1] = textBox2.Text;
                        dr[2] = textBox3.Text;
                        dr[3] = Convert.ToInt32(textBox4.Text);
                        dr[4] = textBox5.Text;
                        dr[5] = textBox6.Text;
                        dr[6] = Convert.ToInt32(textBox7.Text);
                       da.Update(ds.Tables["Emp"]);
                        MessageBox.Show("Update data Successfully");
                    }
                    catch(Exception ee)
                    {
                        MessageBox.Show(ee.ToString());
                    }
                    break;
                }
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            int intCounter = 0;
            DataRow drTarget;
            foreach (DataRow dr in ds.Tables["Emp"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        //dataSet.Tables["Emp"].Rows.Remove(dr);
                        //dr.Delete();
                        //Sqlda.Update(dataSet.Tables["Emp"]);
                        dr.Delete();
                        // No need to call Rows.Remove(dr) if you are using dr.Delete()

                        da.Update(ds.Tables["Emp"]);
                        ds.Tables["Emp"].AcceptChanges();
                        MessageBox.Show("Data Successfully Deleted..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();

        }
    }
}
