using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4._3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeComponent();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("A</br>");
            throw (new ArgumentNullException());
        }

        private void InitializeComponent()
        {
            this.Error += new System.EventHandler(this.WebForm1_Error);
            this.Load += new System.EventHandler(this.WebForm1_Load);

        }
        private void WebForm1_Error(object sender, EventArgs e)
        {
            Exception objErr = Server.GetLastError().GetBaseException(); // 获取错误
            Response.Write(objErr.ToString()+"</br>");
            Server.ClearError();
        }

        private void WebForm1_Load(object sender, EventArgs e)
        {
            Response.Write("B</br>");
        }
    }

    }
