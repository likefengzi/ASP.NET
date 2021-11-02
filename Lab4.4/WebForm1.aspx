<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab4._4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ASP.NET控件</div>
        <p>
            DropDownList</p>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>C#</asp:ListItem>
                <asp:ListItem>C#2021</asp:ListItem>
                <asp:ListItem>LINQ</asp:ListItem>
                <asp:ListItem>WPF</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            &nbsp;</p>
        <p>
            ListBox</p>
        <p>
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem>C#</asp:ListItem>
                <asp:ListItem>C#2021</asp:ListItem>
                <asp:ListItem>LINQ</asp:ListItem>
                <asp:ListItem>WPF</asp:ListItem>
            </asp:ListBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            CheckBoxList</p>
        <p>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>C#</asp:ListItem>
                <asp:ListItem>C#2021</asp:ListItem>
                <asp:ListItem>LINQ</asp:ListItem>
                <asp:ListItem>WPF</asp:ListItem>
            </asp:CheckBoxList>
        </p>
        <p>
            &nbsp;</p>
        <p>
            RadioButtonList</p>
        <p>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>C#</asp:ListItem>
                <asp:ListItem>C#2021</asp:ListItem>
                <asp:ListItem>LINQ</asp:ListItem>
                <asp:ListItem>WPF</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="显示" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
