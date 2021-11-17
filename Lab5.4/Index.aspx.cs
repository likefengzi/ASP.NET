using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5._4
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //String name = TextBox1.Text.Trim();
            //String password = TextBox2.Text.Trim();
            String name = Request.Form["name"];
            String password = Request.Form["password"];
            
            if (name == "")
            {
                Response.Write("用户名不能为空");
                return;
            }
            else if (password == "")
            {
                Response.Write("密码不能为空");
                return;
            }
            else
            {
                if (name.Equals("张三") && password.Equals("123456"))
                {
                    Server.Transfer("View.aspx");
                }
                else
                {
                    Response.Write("用户名密码错误");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
