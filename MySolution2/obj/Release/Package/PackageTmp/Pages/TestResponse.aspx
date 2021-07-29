<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestResponse.aspx.cs" Inherits="MySolution2.Pages.TestResponse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>5.Response对象</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名：<input type="text" name="userName" value="" id="txt"/><br />
            密码：<input type="password" name="pwd" value="" /><br />
            <asp:Button ID="btnWrite" runat="server" Text="Write方法" OnClick="btnWrite_Click" />
            <asp:Button ID="btnEnd" runat="server" Text="End方法" OnClick="btnEnd_Click" />
            <asp:Button ID="btnRedirect" runat="server" Text="Redirect方法" OnClick="btnRedirect_Click" />
        </div>
    </form>
</body>
</html>
