using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySolution2.Pages
{
    public partial class TestViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ViewState是基类Control的属性
            // 摘要:
            //     获取字典，允许您保存和还原多个请求在同一页的服务器控件的视图状态的状态信息。
        }

        int i = 0;// 用于计数(可以通过声明为static解决)

        protected void btnCount_Click(object sender, EventArgs e)
        {
            // 第一次之后再点击的时候，需要获得上一次保存下来的i的值
            if (ViewState["count"] != null)
            {
                i = (int)ViewState["count"];
            }
            i++;

            // 将i的值保存至视图状态中
            ViewState["count"] = i;// 装箱成object类型去存储
            Response.Write(i);
        }
    }
}