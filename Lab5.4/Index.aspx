<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Lab5._4.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">用户名</td>
                <td class="auto-style1">
                    <input id="name" type="text" name="name" /></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style1">密码</td>
                <td class="auto-style1">
                    <input id="password" type="text" name="password" /></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="重置" OnClick="Button2_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
