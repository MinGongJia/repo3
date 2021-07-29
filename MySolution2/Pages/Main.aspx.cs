using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySolution2.AdoClass;

namespace MySolution2.Pages
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Global.WriteLog("Main页面加载完成");
            if (Application["userList"] != null)
            {
                List<User> userList = (List<User>)Application["userList"];

                lblCurrentUser.Text = "当前在线的用户是：";
            }
        }
    }
}