<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="isPostBack.aspx.cs" Inherits="MySolution2.Pages.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>isPostBack是否是回传请求</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- 超链接请求自己不是回传请求 -->
            <a href="WebForm3.aspx">请求本页面</a>
            <asp:TextBox ID="txt" runat="server"></asp:TextBox>
            <!-- 默认将表单提交回当前页面 -->
            <asp:Button ID="btn" runat="server" Text="点击回传" />
        </div>
    </form>
</body>
</html>
