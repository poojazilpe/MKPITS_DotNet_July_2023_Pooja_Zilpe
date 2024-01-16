using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.net
{
    public partial class forloopdisplayno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            int cnt = 1;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(cnt=1;cnt<=num;cnt++)
            {
                sb.Append(cnt + "<br>");
            }
            Label1.Text = sb.ToString();
        }
    }
}