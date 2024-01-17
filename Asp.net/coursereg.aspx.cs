using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace loginform
{
    public partial class coursereg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (RadioButton4.Checked)
            {
                
                TextBox3.Text = "1000";

            }

        }
      public  enum category { Student, It }
       public category cat;
        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Full Name : " + TextBox1.Text + "<br>");
            
            
            string g = null;
            if (RadioButton1.Checked)
            {
                g = RadioButton1.Text;
            }
            else if (RadioButton2.Checked)
            {
                g = RadioButton2.Text;
            }
            else if (RadioButton3.Checked)
            {
                g = RadioButton3.Text;
            }
            sb.Append("Gender : " + g + "<br>");
            string c = null;
            if (RadioButton4.Checked)
            {
                c = RadioButton4.Text;
            }
            else if (RadioButton5.Checked)
            {
                c = RadioButton5.Text;
            }
            sb.Append("Category : " + c + "<br>");
            sb.Append("Country : " + DropDownList1.Text + "<br>");
            sb.Append("State : " + DropDownList2.Text + "<br>");
            sb.Append("Date : " + TextBox2.Text + "<br>");
            sb.Append("Total Amount :" + TextBox3.Text + "<br>");
            sb.Append("Fee Paid :" + TextBox4.Text + "<br>");
            sb.Append("Balance Amount :" + TextBox5.Text + "<br>");
            Label1.Text = sb.ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            string a = DropDownList1.Text;
            DropDownList2.Items.Clear();


            switch (a)
            {
                case "India":
                    DropDownList2.Items.Add("Maharashtra");
                    DropDownList2.Items.Add("MP");
                    DropDownList2.Items.Add("UP");
                    break;

                case "USA":
                    DropDownList2.Items.Add("LA");
                    DropDownList2.Items.Add("LY");
                    break;

            }
            
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string a = DropDownList2.Text;
            DropDownList3.Items.Clear();


            switch (a)
            {
                case "Maharashtra":
                    DropDownList3.Items.Add("Nagpur");
                    DropDownList3.Items.Add("Amravati");
                    DropDownList3.Items.Add("Bhandara");
                    break;

                case "MP":
                    DropDownList3.Items.Add("Chhatisgadh");
                    DropDownList3.Items.Add("Jabalpur");
                    DropDownList3.Items.Add("Bhopal");
                    break;

                case "UP":
                    DropDownList3.Items.Add("Jharkhand");
                    DropDownList3.Items.Add("Bihar");

                    break;

                case "LA":
                    DropDownList3.Items.Add("Colombo");
                    DropDownList3.Items.Add("Nuziland");

                    break;

                case "LY":
                    DropDownList3.Items.Add("Canada");
                    DropDownList3.Items.Add("Dubai");


                    break;

            }
            
        }
        
        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
            if(RadioButton4.Checked)
            {
                cat = category.Student;
                TextBox3.Text = "1000";
                TextBox4.Text = "0";
                TextBox5.Text = "0";

            }
        }
        double fp;
        double bamt; 

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            

            if (cat.ToString()=="Student")
            {
               

                double ta = Convert.ToDouble(TextBox3.Text);
                fp = ta * 0.5f;
                double amt = Convert.ToDouble(TextBox4.Text);
                if (amt < fp)
                {
                   Response.Write("Minimum amount to be paid 50%");
                    TextBox5.Text = "0";
                }
                else
                {
                    bamt = ta - amt;
                    TextBox5.Text = bamt.ToString();
                }
            }
            else if (cat.ToString() == "It")
            {
                
                double ta = Convert.ToDouble(TextBox3.Text);
                fp = ta * 0.8f;
                double amt = Convert.ToDouble(TextBox4.Text);
                if (amt < fp)
                {
                    Response.Write("Minimum amount to be paid 80%");
                    TextBox5.Text = "0";
                }
                else
                {
                    bamt = ta - amt;
                    TextBox5.Text = bamt.ToString();
                }
                

            }
        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton5.Checked)
            {
                cat = category.It;
                TextBox3.Text = "3000";
                TextBox4.Text = "0";
                TextBox5.Text = "0";


            }
            
        }
        
    }
}