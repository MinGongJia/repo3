using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySolution2.Pages
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTransfer_Click(object sender, EventArgs e)
        {
            // 第二个参数：表示是否保留原页面中的form表单数据或QueryString中的数据
            // true：保留；false：不保留
            Server.Transfer("~/Pages/MainReceive.aspx",true);
        }
    }
}