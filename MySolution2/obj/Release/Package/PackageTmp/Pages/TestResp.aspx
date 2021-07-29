<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestResp.aspx.cs" Inherits="MySolution2.TestResp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请在此处输入内容：<asp:TextBox ID="txt" runat="server" OnTextChanged="txt_TextChanged" AutoPostBack="true"></asp:TextBox>
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
        </div>
    </form>

    <script src="Scripts/jquery-3.3.1.js"></script>
    <script>
        //// 浏览器端加载完Dom元素后执行的
        //$(function () {
        //    // 这里使用的是浏览器端的Id名称，这里系统自动生成的与name的属性值相同
        //    $("#txt").on("change", function () {
        //        // 为文本框的change绑定事件：用于提交表单内容
        //        $("#form1").submit();
        //    })
        //})
    </script>

</body>
</html>
