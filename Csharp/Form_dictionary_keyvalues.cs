using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_dictionary_keyvalues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> d = new Dictionary<string, string>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.Add(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> keys = new List<string>(d.Keys);
            foreach (string s in keys)
            {
                sb.Append("Keys :" + s+"\n");
            }
            label3.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> keys = new List<string>(d.Values);
            foreach (string s in keys)
            {
                sb.Append("Values :" + s + "\n");
            }
            label4.Text = sb.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
             
            foreach (KeyValuePair<string, string> k in d)
            {
                sb.Append("key :"+k.Key+"Values :" + k.Value + "\n");
            }
            label4.Text = sb.ToString();
        }
    }
}
