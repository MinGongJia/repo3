using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySolution2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        // Page_Load：每次的页面请求都会触发load事件，都会执行Page_Load里面的代码
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("<script>alert('服务器端自动执行的脚本')</script>");
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('服务器端点击执行的脚本')</script>");
        }
    }
}