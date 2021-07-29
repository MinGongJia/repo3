<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExecSequence.aspx.cs" Inherits="MySolution2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>客户端与服务端脚本的执行顺序</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt" runat="server"></asp:TextBox>
            <asp:Button ID="btn" runat="server" Text="请点击" OnClick="btn_Click" />
        </div>
    </form>

    <script src="Scripts/jquery-3.3.1.js"></script>
    <script>
        $(function () {
            //alert("客户端自动执行的脚本");

            $("#btn").click(function () {
                alert("客户端点击执行的脚本");
            })
        })
    </script>
</body>
</html>
