<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestRequest.aspx.cs" Inherits="MySolution2.Pages.TestRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>4.Request对象</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名：<input type="text" name="userName" value="" id="txt"/><br />
            密码：<input type="password" name="pwd" value="" /><br />
            <asp:Button ID="btn" runat="server" Text="登录" OnClick="btn_Click" />
        </div>
    </form>
</body>
</html>
