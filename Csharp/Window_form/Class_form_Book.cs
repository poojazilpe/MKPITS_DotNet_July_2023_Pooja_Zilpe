using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_form_Book
{
    public partial class Form1 : Form
    {

        private int cnt = 0;
        private Book[] book1 = new Book[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cnt < 3)
            {
                book1[cnt] = new Book();
                book1[cnt].getdata(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
                cnt++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                if (cnt == 3)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    MessageBox.Show("Click on Result button");



                }
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < book1.Length; i++)
            {
                if (book1[i] != null)
                {
                    sb.Append("Title: " + book1[i].title);
                    sb.Append("\nAuthor: " + book1[i].author);
                    sb.Append("\nYear: " + book1[i].year + "\n");
                }
            }

            label4.Text = sb.ToString();

        }

    }
        }
    

