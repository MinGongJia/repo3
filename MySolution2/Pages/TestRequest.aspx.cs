using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySolution2.Pages
{
    public partial class TestRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpRequest req = Request;
            //Response.Write(req.RawUrl + "<br/>");
            //Response.Write(req.HttpMethod);
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            // 以POST方式提交表单，通过Request.Form可以获得表单中指定name的元素的值
            // 用于获取普通HTML标签控件
            string userName = Request.Form["userName"];
            string pwd = Request.Form["pwd"];

            // 当表单以GET方式提交时，获取参数
            //string userName = Request.QueryString["userName"];
            //string pwd = Request.QueryString["pwd"];

            if (userName == "admin" && pwd == "123")
            {
                Response.Write("<script>alert('登录成功！');window.location.href='../AdminMain.aspx'</script>");
            } else
            {
                Response.Write("<script>alert('用户名或密码错误！');</script>");

            }
        }
    }
}