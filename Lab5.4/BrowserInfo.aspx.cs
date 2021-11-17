using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5._4
{
    public partial class BrowserInfo : System.Web.UI.Page
    {
        [Obsolete]
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<H1>您的浏览器相关信息如下</H1><BR>");
            Response.Write("浏览器名称：" + Request.Browser.Browser + "<BR>");
            Response.Write("浏览器类型：" + Request.Browser.Type + "<BR>");
            Response.Write("浏览器版本：" + Request.Browser.Version  + "<BR>");
            Response.Write("操作系统平台：" + Request.Browser.Platform + "<BR>");
            Response.Write("浏览器是否为测试版：" + Request.Browser.Beta + "<BR>");
            Response.Write("是否为16位环境：" + Request.Browser.Win16 + "<BR>");
            Response.Write("是否为32位环境：" + Request.Browser.Win32 + "<BR>");
            Response.Write("浏览器是否支持框架：" + Request.Browser.Frames + "<BR>");
            Response.Write("浏览器是否支持表格：" + Request.Browser.Tables + "<BR>");
            Response.Write("浏览器是否支持Cookie：" + Request.Browser.Cookies + "<BR>");
            Response.Write("浏览器是否支持VBScript：" + Request.Browser.VBScript + "<BR>");
            Response.Write("浏览器是否支持JavaScript：" + Request.Browser.JavaScript + "<BR>");
            Response.Write("浏览器是否支持ActiveXControl：" + Request.Browser.ActiveXControls + "<BR>");

            Response.Write("<P>客户端请求的路径为："+HttpContext.Current.Request.Url);
            Response.Write("<P>客户端主机地址为："+HttpContext.Current.Request.UserHostAddress);
            Response.Write("<P>客户端主机名称为："+HttpContext.Current.Request.UserHostName);
        }
    }
}