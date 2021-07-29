using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySolution2.AdoClass;

namespace MySolution2.Pages
{
    public partial class TestApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Global.WriteLog("Login页面加载完成");
        }

        List<User> userList = null;

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string userPwd = txtUserPwd.Text;

            // 由于Application是全局对象，可能有多个用户同时操作它，为了避免发生一些并发性的冲突，当某个
            // 用户操作它时，将其进行加锁，其他用户就无法操作
            Application.Lock();
            // 省略真实的判断
            // 把最后登录成功的用户名存储至Application中
            Application["lastUserName"] = userName;

            if (Application["userList"] != null)
            {
                userList = (List<User>)Application["userList"];
            } else
            {
                userList = new List<User>();
            }

            userList.Add(new User { UserName = userName, UserPwd = userPwd });

            // 将所有的在线人员集合保存至Application集合中
            Application["userList"] = userList;

            // 或者保存到Global类的静态属性中
            Global.LastUserName = userName;
            Global.ListUsers = userList;

            // 操作完成后，解锁
            Application.UnLock();

            Response.Redirect("~/Pages/Main.aspx");// 跳转至主页面
        }
    }
}