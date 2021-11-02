using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4._4
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

        }

        private void InitializeComponent()
        {
            this.Load += new System.EventHandler(this.WebForm1_Load);

        }

        private void WebForm1_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String str="";
            str+= "DropDownList列表项如下:" + "</br>";
            str = My(DropDownList1.Items, str);
            str += "ListBox列表项如下:" + "</br>";
            str = My(ListBox1.Items, str);
            str += "CheckBoxList列表项如下:" + "</br>";
            str = My(CheckBoxList1.Items, str);
            str += "RadioButtonList列表项如下:" + "</br>";
            str = My(RadioButtonList1.Items, str);
            Label1.Text = str;
        }
        private String My(ListItemCollection item,String str)
        {
            foreach (ListItem i in item)
            {
                str += i.Text+"</br>";
            }
            return str;
        }
    }
}