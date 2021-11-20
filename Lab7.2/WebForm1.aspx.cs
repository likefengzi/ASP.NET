using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7._2
{
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i;
            SqlDataSource1.UpdateCommand = "UPDATE Students SET Address = '厦门思明区海韵园' WHERE (Native = '福建厦门')";
            i=SqlDataSource1.Update();
            Label1.Text = "更新行数:" + i;
            SqlDataSource1.SelectCommand = "SELECT * FROM Students where Address='厦门大学'";
            SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            GridView1.DataBind();
            i = GridView1.Rows.Count;
            Label2.Text = "记录行数:" + i;
        }

    }
}