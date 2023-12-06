using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_mdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm r = new RegistrationForm();
            r.MdiParent = this;
            r.Show();
        }

        private void accountFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm a = new AccountForm();
            a.MdiParent = this;
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm r = new RegistrationForm();
            r.MdiParent = this;
            r.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm a = new AccountForm();
            a.MdiParent = this;
            a.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RegistrationForm r = new RegistrationForm();
            r.MdiParent = this;
            r.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AccountForm a = new AccountForm();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrationFormToolStripMenuItem.Enabled = true;
            accountFormToolStripMenuItem.Enabled = true;
            toolStripButton1.Enabled = true;
            toolStripButton2.Enabled = true;
            if (textBox1.Text=="admin" && textBox2.Text=="admin")
            {
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
