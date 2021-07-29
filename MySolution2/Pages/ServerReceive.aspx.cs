using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySolution2.Pages
{
    public partial class ServerReceive : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 方式一：使用Request.Form[]：接收传递来的值
            //string userName = Request.Form["userName"];
            //string userPwd = Request.Form["userPwd"];

            //lblMsg.InnerText = "用户名：" + userName + "，密码：" + userPwd;

            // 方式二：PrevoiusPage：获得向当前页传递控件的页
            Page page = PreviousPage;
            if (page == null)
            {
                // 没有从任何页面跳转而来
                Response.Write("直接请求当前的页面,禁止访问");
            } else
            {
                Response.Write("通过替他页面跳转而来");
                // 服务器软件自己先将控件信息组装起来？
                // 根据服务器ID搜索服务端控件，返回的是控件的基类型Control
                TextBox txtUserName = (TextBox)page.FindControl("userName");
                string userName = txtUserName.Text;

                TextBox txtUserPwd = (TextBox)page.FindControl("userPwd");
                string userPwd = txtUserPwd.Text;

                lblMsg.InnerText = "用户名：" + userName + "，密码：" + userPwd;
            }
        }
    }
}