<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestServer.aspx.cs" Inherits="MySolution2.Pages.TestServer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>6.Server对象</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnHtmlEncode" runat="server" Text="HTML编码" OnClick="btnHtmlEncode_Click" />
            <asp:Button ID="btnHtmlDecode" runat="server" Text="HTML解码" OnClick="btnHtmlDecode_Click" />
            <asp:Button ID="btnUrlEncode" runat="server" Text="Url编码" OnClick="btnUrlEncode_Click" />
            <asp:Button ID="btnUrlDecode" runat="server" Text="Url解码" OnClick="btnUrlDecode_Click" />
            <asp:Button ID="btnMapPath" runat="server" Text="MapPath" OnClick="btnMapPath_Click" />
            <asp:Button ID="btnTransfer" runat="server" Text="Transfer" OnClick="btnTransfer_Click" />
            <asp:Button ID="btnEx" runat="server" Text="Execute" OnClick="btnEx_Click" />
            <asp:Button ID="btnRedirect" runat="server" Text="Redirect" OnClick="btnRedirect_Click" />
        </div>
    </form>
</body>
</html>
