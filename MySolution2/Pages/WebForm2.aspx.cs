using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySolution2.LinQ;

namespace MySolution2.Pages
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = Request.Form["userName"];// 获取以查询字符串发送的请求数据
            string userPwd = Request.Form["userPwd"];

            UserDBDataContext db = new UserDBDataContext();
            // 返回序列中的第一个元素；如果未找到该元素，则返回默认值。
            UserInfos user = db.UserInfos.FirstOrDefault(s=>s.UserName == userName && s.UserPwd == userPwd );
            if (user != null)
            {
                // 对于写往客户端的地址，不能使用~为特殊字符
                // 此时服务端会直接让客户端重定向，不会执行script代码
                //Response.Write("<script>alert('登录成功!');</script>");
                //Response.Redirect("Server.aspx?userName=" + userName);

                // 实现先弹出脚本，再跳转(通过客户端脚本实现)
                Response.Write("<script>alert('登录成功!');" +
                    // 对可能包含中文字符的变量进行编码
                    "window.location.href='Server.aspx?userName=" + Server.UrlEncode(userName) + "'</script>");
            } else
            {
                Response.Write("<script>alert('用户名或密码错误!');</script>");
            }
        }
    }
}