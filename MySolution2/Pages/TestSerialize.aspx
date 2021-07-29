<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestSerialize.aspx.cs" Inherits="MySolution2.Pages.TestSerialize" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        span {
            display:inline-block;
            width:80px;
            text-align:right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <span>姓名：</span>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </div>
            <div>
                <span>年龄：</span>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnAddStudent" runat="server" Text="添加学员" OnClick="btnAddStudent_Click" />
            </div>
        </div>
    </form>
</body>
</html>
