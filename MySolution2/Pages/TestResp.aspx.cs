using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySolution2
{
    public partial class TestResp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("hello world");
        }

        // 服务端代码
        protected void txt_TextChanged(object sender, EventArgs e)
        {
            string text = this.txt.Text;
            lblMsg.Text = "从文本框中获得的是：" + text;
        }
    }
}