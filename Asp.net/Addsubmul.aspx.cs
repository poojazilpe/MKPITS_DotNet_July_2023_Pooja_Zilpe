using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace loginform
{
    public partial class Addsubmul : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int add = 0;int sub = 0;int mul = 0;
            int n1 = Convert.ToInt32(TextBox1.Text);
            int n2 = Convert.ToInt32(TextBox2.Text);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            if(CheckBox1.Checked)
            {
                 add = n1 + n2;
                
            }
             if (CheckBox2.Checked)
            {
                 sub = n1 - n2;
                
            }
             if (CheckBox3.Checked)
            {
                 mul = n1 * n2;
                
            }
            sb.Append("Addition :" + add.ToString() + "<br>");
            sb.Append("Substraction :" + sub.ToString() + "<br>");
            sb.Append ("Multiplication :" + mul.ToString() );
            Label1.Text = sb.ToString();
        }
    }
}