using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_form_LibraryBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LibraryBook[] book = new LibraryBook[3];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            book[0] = new LibraryBook();
            book[1] = new LibraryBook();
            book[2] = new LibraryBook();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<3)
            {
                book[cnt].title = textBox1.Text;
                book[cnt].author = textBox1.Text;
                if(checkBox1.Checked)
                {
                    book[cnt].isavailable = true;
                }
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                if(cnt==3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;

                    button2.Enabled = true;
                    MessageBox.Show("details of 3 books accepted");

                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Available books are : " + "\n");
            for (int i = 0; i < 3; i++)
            {
                if (book[i].isavailable == true)
                {
                    sb.Append("----------------------------------------\n");
                    sb.Append("title: " + book[i].title + "\n");
                    sb.Append("author : " + book[i].author + "\n");

                    sb.Append("----------------------------------------\n");
                }
            }

            label3.Text = sb.ToString();

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Not Available books are : " + "\n");
            for (int i = 0; i < 3; i++)
            {
                if (book[i].isavailable == false)
                {
                    sb1.Append("----------------------------------------\n");
                    sb1.Append("title: " + book[i].title + "\n");
                    sb1.Append("author : " + book[i].author + "\n");

                    sb1.Append("----------------------------------------\n");
                }
            }

            label4.Text = sb1.ToString();

        }
    }
}
