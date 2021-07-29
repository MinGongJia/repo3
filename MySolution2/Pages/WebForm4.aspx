<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="MySolution2.Pages.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>4.使用Transfer传值</title>
    <style type="text/css">
        span {
            /* 
                如果设置了 display: inline-block，将保留上下外边距/内边距，而 display: inline 则不会
                与 display: block 相比，主要区别在于 display：inline-block 在元素之后不添加换行符，因
            此该元素可以位于其他元素旁边。
            */
            display:inline-block;
            width:80px;
            text-align:right;
        }

        .border {
            border-radius:20px;
            border:1px solid #ccc;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span>用户名：</span><asp:TextBox ID="userName" runat="server"></asp:TextBox><br />
            <span>密码：</span><asp:TextBox ID="userPwd" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Button ID="btnTransfer" runat="server" Text="Transfer" OnClick="btnTransfer_Click" />
        </div>
    </form>
    <script src="../scripts/jquery-3.3.1.js"></script>

    <script>
        /* 
            在JQuery中，“$”就是jQuery的别称，是jQuery库提供的一个回传函数，定义为“选取”，是“selector”
        的缩写；语法“$(selector)”，作用是根据“()”里的参数进行查找和选择html文档中的元素。
         */
        // 标签选择器$('p')、类选择器$('.myClass')、id选择器$('#myId')
        // 选择表单元素，使用":类型"

        /*
            其实，$(function(){})是jquery里面的一个写法，是$(document).ready(function(){})的简写，类似于
        原生js中的DOMContentLoaded事件。当页面DOM树加载完毕之后触发。注意的是它是dom数加载完毕，并不是页
        面所有资源加载完毕，例如图片，音视频等还没加载前触发。
         */
        $(function () {
            $(":text").addClass("border");
            $(":password").addClass("border");

            // 绑定focus事件
            $(":text").on("focus", function () {
                // 设置所有匹配元素的指定 CSS 属性。
                // $(selector).css(name,value)
                $(this).css("border","1px solid blue");
            })
        })
    </script>
</body>
</html>
