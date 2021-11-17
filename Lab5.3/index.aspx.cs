using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5._3
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String name = TextBox1.Text.Trim();
            String password = TextBox2.Text.Trim();
            if (name == "")
            {
                Response.Write("用户名不能为空");
                TextBox1.Focus();
                return;
            }
            else if (password == "")
            {
                Response.Write("密码不能为空");
                TextBox2.Focus();
                return;
            }
            else
            {
                if (name.Equals("张三") && password.Equals("123456"))
                {
                    Session["useInfo"] = "张三";
                    Response.Redirect("view.aspx");
                }
                else
                {
                    Response.Write("用户名密码错误");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
        }
    }
}