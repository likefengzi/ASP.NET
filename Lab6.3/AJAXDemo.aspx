<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AJAXDemo.aspx.cs" Inherits="Lab6._3.UpdatePanelDemo" %>

<!DOCTYPE html >

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UpdatePanel示例程序</title>
    <style type="text/css">
        #insideupdatepanel {
            font-family: verdana;
            font-size: 9pt;
            color: #003300;
            background-color: #EEEEFF;
        }

        #Div1, #Div2 {
            font-family: verdana;
            font-size: 9pt;
            color: #003300;
            background-color: #efefef;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <%--这是放在UpdatePanel内部的内容--%>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <div id="insideupdatepanel">
                    <fieldset>
                        <legend>UpdatePanel内部</legend>
                        <asp:Label ID="lblInfo1" runat="server"></asp:Label><br />
                        <asp:Button ID="btn1" runat="server" Text="在内部显示时间" OnClick="btn1_Click" />
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" 
                            Text="更新UpdataPanel2" />
                    </fieldset>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btn4" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>


        <%--这是放在另一个UpdatePanel内部的内容--%>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" ChildrenAsTriggers="False"
            UpdateMode="Conditional">
            <ContentTemplate>
                <div id="Div2">
                    <fieldset>
                        <legend>第二个UpdatePanel内部</legend>
                        <asp:Label ID="lblInfo3" runat="server"></asp:Label><br />
                        <asp:Button ID="btn3" runat="server" Text="在内部显示时间" OnClick="btn3_Click" />
                        <asp:Button ID="btn4" runat="server" Text="更新UpdatePanel1"
                            OnClick="btn4_Click" />
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>C#</asp:ListItem>
                            <asp:ListItem>.NET</asp:ListItem>
                            <asp:ListItem>面向对象编程</asp:ListItem>
                            <asp:ListItem>软件工程</asp:ListItem>
                        </asp:DropDownList>
                    </fieldset>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>



        <%--这是放在UpdatePanel外面的内容--%>
        <div id="Div1">
            <fieldset>
                <legend>UpdatePanel的外部</legend>
                <asp:Label ID="lblInfo2" runat="server"></asp:Label><br />
                <asp:Button ID="btn2" runat="server" Text="外部刷新网页" OnClick="btn2_Click" />
            </fieldset>
        </div>
    </form>
</body>
</html>
