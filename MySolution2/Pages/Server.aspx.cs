using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySolution2.LinQ;
using MySolution2.AdoClass;

namespace MySolution2.Pages
{
    public partial class Server : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 对可能包含中文字符的变量进行解码操作
            string username = Server.UrlDecode(Request.QueryString["userName"]);
            UserDBDataContext db = new UserDBDataContext();
            // UserDBDataContent与UserInfos都是系统自动创建的
            UserInfos user = db.UserInfos.FirstOrDefault(s => s.UserName == username); 
            if (user != null)// 数据库中查询到了结果
            {
                txtName.Text = username;
            }
        }
    }
}