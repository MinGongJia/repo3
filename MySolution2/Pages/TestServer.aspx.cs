using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace MySolution2.Pages
{
    public partial class TestServer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHtmlEncode_Click(object sender, EventArgs e)
        {
            string str = "<span style='color:red'>我是一个span容器</span>";
            str = Server.HtmlEncode(str);// html标签的编码
            Response.Write(str);
        }

        protected void btnHtmlDecode_Click(object sender, EventArgs e)
        {
            string str = "&lt;span style ='color:red'&gt;我是一个span容器&lt;/span&gt";
            str = Server.HtmlDecode(str);// html标签的解码
            Response.Write(str);
        }

        protected void btnUrlEncode_Click(object sender, EventArgs e)
        {
            string url = "Main.aspx?userName=张三";
            string path = Server.UrlEncode(url);// url的编码
            Response.Write(path);
        }

        protected void btnUrlDecode_Click(object sender, EventArgs e)
        {
            string url = "Main.aspx%3fuserName%3d%e5%bc%a0%e4%b8%89";
            string path = Server.UrlDecode(url);// url的解码
            Response.Write(path);
        }

        protected void btnMapPath_Click(object sender, EventArgs e)
        {
            // 在服务端虚拟路径：~/. ~表示当前站点的根目录
            string path = "~/resources/test.txt";
            path = Server.MapPath(path);// 将虚拟路径转换为实际可用的物理路径
            Response.Write(path + "<br/>");
            StreamReader sr = File.OpenText(path);
            string content = sr.ReadToEnd();
            Response.Write(content);
        }

        protected void btnTransfer_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Pages/Server.aspx");
            // 在服务器端停止当前页的执行，根据url加载指定的页面，地址栏不会发生变化
        }

        protected void btnEx_Click(object sender, EventArgs e)
        {
            Server.Execute("~/Pages/Server.aspx");
            // 在当前上下文中执行指定的处理程序，没有终止当前页的执行；地址栏也没有变化
        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            // 服务器告诉客户端进行跳转，地址栏会发生变化
            Response.Redirect("~/Pages/Server.aspx");
        }
    }
}