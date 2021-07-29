using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySolution2.Pages
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // IsPostBack：页面的请求是否是首次请求，还是回传请求
            // 首次请求：false
            // 回传请求：true。(当前页面将表单回传给自己)
            //Response.Write(IsPostBack);

            if (!IsPostBack)// 如果是首次访问，执行
            {
                txt.Text = DateTime.Now.ToString();
                // 如果不是首次请求，则TextBox中的内容不更新
            }
        }
    }
}