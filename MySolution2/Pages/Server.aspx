<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Server.aspx.cs" Inherits="MySolution2.Pages.Server" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="txtName">用户名</label>
            <asp:TextBox ID="txtName" runat="server" ReadOnly="true"></asp:TextBox>
        </div>
        <div>
            <h3>服务端页面</h3>
        </div>

    </form>
</body>
</html>
