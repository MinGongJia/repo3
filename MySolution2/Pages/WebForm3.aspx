<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="MySolution2.Pages.WebForm31" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>3.使用按钮的PostBackUrl传递值</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名：<asp:TextBox ID="userName" runat="server"></asp:TextBox>
            密码：<asp:TextBox ID="userPwd" runat="server"></asp:TextBox>
            <!-- PostBackUrl转换成前端的onclick事件 默认PostBackUrl为当前页面的URL地址，自己提交给自己
                所以此时再定义Onclick事件并不会在服务端执行-->
            <asp:Button ID="btnSend" runat="server" Text="传递值" PostBackUrl="~/Pages/ServerReceive.aspx" />
        </div>
    </form>
</body>
</html>
