<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginWeb.aspx.cs" Inherits="MySolution2.Pages.LoginWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名：<asp:TextBox ID="txtacc" runat="server"></asp:TextBox><asp:Label ID="lblAcc" runat="server" Text=""></asp:Label><br />
            密码：<asp:TextBox ID="txtpwd" runat="server"></asp:TextBox><asp:Label ID="lblPwd" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="取消" />
        </div>
    </form>
    <script src="../Scripts/jquery-3.3.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#btnLogin").click(function (event) {
                var account = $("#txtacc").val();
                var pwd = $("#txtpwd").val();

                if (account == "") {
                    $("#lblAcc").html("用户名不能为空！").css("color", "red");
                    event.preventDefault();// 可以阻止按钮的默认行为
                    // return false;也可以阻止，但是会影响下面代码的执行
                } else {
                    $("#lblAcc").html("");
                }

                if (pwd == "") {
                    $("#lblPwd").html("密码不能为空！").css("color", "red");
                    event.preventDefault();
                } else {
                    $("#lblPwd").html("");
                }
            })
        })
    </script>
</body>
</html>
