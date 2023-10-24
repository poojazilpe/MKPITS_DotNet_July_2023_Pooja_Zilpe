using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_note
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int note500, note100, note50, note20, note10, note5, note2, note1;
            note500 = note100 = note50 = note20 = note10 = note5 = note2 = note1 = 0;
            int amt =Convert.ToInt32(textBox1.Text);
            if(amt>=500)
            {
                note500 = amt / 500;
                amt = amt -(note500 * 500);
            }
            if (amt >= 100)
            {
                note100 = amt / 100;
                amt = amt - (note100 * 100);
            }
            if (amt >= 50)
            {
                note50 = amt / 50;
                amt = amt - (note50 * 50);
            }
            if (amt >= 20)
            {
                note20 = amt / 20;
                amt = amt - (note20 * 20);
            }
            if (amt >= 10)
            {
                note10 = amt / 10;
                amt = amt - (note10 * 10);
            }
            if (amt >= 5)
            {
                note5 = amt / 5;
                amt = amt - (note5 * 5);
            }
            if (amt >= 2)
            {
                note2 = amt / 2;
                amt = amt - (note2 * 2);
            }
            if (amt >= 1)
            {
                note1 = amt / 1;
                amt = amt - (note1* 1);
            }
            label2.Text = "500 = " + note500;
            label3.Text = "100 = " + note100;
            label4.Text = "50 = " + note50;
            label5.Text = "20 = " + note20;
            label6.Text = "10 = " + note10;
            label7.Text = "5 = " + note5;
            label8.Text = "2 = " + note2;
            label9.Text = "1 = " + note1;
            
        }
    }
}
