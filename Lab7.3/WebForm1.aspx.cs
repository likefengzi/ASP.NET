using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7._3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataSource1.SelectParameters.Add("CustomerID", System.TypeCode.String, TextBox1.Text.Trim());
            //SqlDataSource1.SelectParameters["CustomerID"].DefaultValue = TextBox1.Text.Trim();
            SqlDataSource1.SelectCommand = "SELECT * FROM [Customers] WHERE CustomerID=@CustomerID";
            //SqlDataSource1.SelectParameters.RemoveAt(0);
            

            
        }

        protected void SqlDataSource1_Init(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
            
        }
    }
}