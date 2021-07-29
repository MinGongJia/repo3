<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MySolution2.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%-- ASP.NET服务端控件 --%>
            <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>

            <%-- 控件 + 事件驱动模型 --%>
            <asp:Button ID="btnSetTime" runat="server" Text="设置时间" OnClick="btnSetTime_Click" /><br />

            <%-- html标签 --%>
            <input type="type" name="name" value="2020-5-11 10:32:00" />
        </div>
    </form>
</body>
</html>
