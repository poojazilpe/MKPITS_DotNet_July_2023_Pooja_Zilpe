using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.net
{
    public partial class factorial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            int fact = 1;
            int cnt = 1;
            

            while(cnt<num)
            {
                fact = num * fact;
                num--;
                Label1.Text = "Factorial : " + fact.ToString();


            }
        }
    }
}