<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="MySolution2.Pages.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>聊天室主页面</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCurrentUser" runat="server"></asp:Label>
            <asp:Label ID="lblOnline" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
