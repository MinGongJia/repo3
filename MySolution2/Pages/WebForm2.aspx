<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MySolution2.Pages.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录并使用数据库验证</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <label for="">用户名：</label>
                <input type="text" name="userName" value="" id="txtUserName" />
            </div>
            <div>
                <label for="">密码：</label>
                <input type="text" name="userPwd" value="" id="txtPwd" />
            </div>
            <div>
                <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" />
            </div>
        </div>
    </form>
</body>
</html>
