using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5._4
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String name = Request.Form["name"];
            String password = Request.Form["password"];
            Response.Write("<H1>您的信息如下</H1>");
            Response.Write("<P>用户名："+name);
            Response.Write("<P>密码："+password);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("BrowserInfo.aspx");
        }
    }
}