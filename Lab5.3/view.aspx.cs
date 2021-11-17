using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5._3
{
    public partial class view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["useInfo"] == null)
            {
                Response.Write("<B><font color='red'>您不是合法用户</font></B>");
                Response.Write("<P><A href='index.aspx'>进入主页面</A></P>");
            }
            else
            {
                Response.Write("<B>恭喜登录成功</B>");
            }
        }
    }
}