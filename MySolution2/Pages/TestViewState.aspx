<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestViewState.aspx.cs" Inherits="MySolution2.Pages.TestViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnCount" runat="server" Text="点击计数" OnClick="btnCount_Click" />
        </div>
    </form>
</body>
</html>
