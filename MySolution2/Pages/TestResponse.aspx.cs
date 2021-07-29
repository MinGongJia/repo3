using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySolution2.Pages
{
    public partial class TestResponse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            Response.Write("普通的文本字符串<br>");
            Response.Write("<input type='button' value='动态按钮' name='btn' id='btn'><br />");
            Response.Write("<script>alert('hello');</script>");

        }

        protected void btnEnd_Click(object sender, EventArgs e)
        {
            Response.Write("<input type='button' value='动态按钮1' name='btn1' id='btn1'><br />");
            Response.End();
            Response.Write("<input type='button' value='动态按钮2' name='btn2' id='btn2'><br />");
        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            string userName = Request.Form["userName"];
            string pwd = Request.Form["pwd"];
            // 跳转到AdminMain.aspx页面，宁缺将需要传递的值以查询字符串传递到管理员页面
            Response.Redirect("../AdminMain.aspx?name=" + userName + "&pwd=" + pwd);
        }
    }
}