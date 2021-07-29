<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestApplication.aspx.cs" Inherits="MySolution2.Pages.TestApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>聊天室登录</title>
    <style>
        label {
            display:inline-block;
            width:80px;
            text-align:right;
        }
        #btnLogin {
            margin-left:130px;
        }
        div {
            margin-bottom:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <label for="txtUserName">用户名：</label><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtUserPwd">密码：</label><asp:TextBox ID="txtUserPwd" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" />
            </div>
        </div>
    </form>
</body>
</html>
