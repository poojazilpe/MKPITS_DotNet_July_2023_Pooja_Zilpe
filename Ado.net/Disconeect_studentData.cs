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

namespace disconnect_studentData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=DESKTOP-3NEL5ND\\SQLEXPRESS;integrated security=true;database=mkpsample1");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cb = null;
        
        private void button1_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Student", con);
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, "stud");
            dataGridView1.DataSource = ds.Tables["stud"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables["stud"]);
                MessageBox.Show("Update sucessfully");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
