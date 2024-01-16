using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.net
{
    public partial class Areaofcircle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float r = Convert.ToSingle(TextBox1.Text);
            float area = 3.14f * r * r;
            Label1.Text = "Area Of Circle :"+area.ToString();
            float circ = 2 * 3.14f * r;
            Label2.Text = "Circumference Of Circle : " + circ.ToString();
        }
    }
}