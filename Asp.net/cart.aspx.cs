using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace myntra
{
    public partial class cart : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-3NEL5ND\\SQLEXPRESS;integrated security=true;database=Product_store");
        SqlCommand command;
        protected void Page_Load(object sender, EventArgs e)
        {
            string prodid = Request.QueryString["ProdId"].ToString();
            Session["ProdId"] = prodid;
            // Response.Write("prodid " + Session["prodid"].ToString());

            string prodname = null;
            string proddescription = null;
            int prodprice = 0;
            int qty = 0;
            string sessionid = null;
            string prodimage = null;

            string query = "select * from Product11 where prodid=@prodid";
            command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@prodid", prodid);
            con.Open();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                prodname = dr["prodname"].ToString();
                proddescription = dr["proddescription"].ToString();
                prodprice = Convert.ToInt32(dr["prodprice"].ToString());
                qty = 1;
                sessionid = Session.SessionID;
                prodimage = dr["prodimg"].ToString();

            }
            dr.Close();

            //now save the record in cart1 table
            query = "insert into ctable3 values(@prodid, @prodname, @proddescription, @prodprice, @prodimg, @sessionid, @quantity)";
            SqlCommand com1 = new SqlCommand();
            com1 = new SqlCommand(query, con);
            com1.Parameters.AddWithValue("@prodid", prodid);
            com1.Parameters.AddWithValue("@prodname", prodname);

            com1.Parameters.AddWithValue("@proddescription", proddescription);
            com1.Parameters.AddWithValue("@prodprice", prodprice);
            com1.Parameters.AddWithValue("@prodimg", prodimage);
            com1.Parameters.AddWithValue("@sessionid", sessionid);
            com1.Parameters.AddWithValue("@quantity", qty);

            com1.ExecuteNonQuery();

            con.Close();

            //displaying the data from ctable3 into datalist control
            string qr = "select * from ctable3 where sessionid=@sessionid";

            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            da.SelectCommand.Parameters.AddWithValue("@sessionid", sessionid);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "cart");
            DataList1.DataSource = ds.Tables["cart"];
            DataList1.DataBind();

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}