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

namespace adoconnectionclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = database.getConnection();
            if(con != null)
            {
                MessageBox.Show("Connect successful");
                con.Close();
            }
            else
            {
                MessageBox.Show("Could not connect server");
            }    

        }
    }
}
