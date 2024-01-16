using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.net
{
    public partial class forfactorial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            int cnt;
            int fact = 1;
            for(cnt=num;cnt>0;cnt--)
            {
                fact = fact * cnt;
            }
            Label1.Text ="Factorial : "+ fact.ToString();
        }
    }
}