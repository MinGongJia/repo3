using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;
using MySolution2.AdoClass;

namespace MySolution2
{
    public class Global : System.Web.HttpApplication
    {
        public static string LastUserName { get; set; }// 保存最后登录成功的用户名

        public static List<User> ListUsers { get; set; }// 保存所用的在线用户列表

        /// <summary>
        /// 记录操作日志
        /// </summary>
        /// <param name="exe">日志内容</param>
        public static void WriteLog(string exe)
        {
            string path = "C:/Users/31527/source/repos/MySolution2/MySolution2/resources/web.log";
            using (StreamWriter sw = File.AppendText(path))
            {
                DateTime now = DateTime.Now;
                string content = now.ToLongDateString() + ":" + now.Millisecond + ":执行操作：" + exe;
                sw.WriteLine(content);
            }
        }

        /// <summary>
        /// 应用程序启动时触发
        /// </summary>
        protected void Application_Start(object sender, EventArgs e)
        {
            // 此处的代码是最早且仅被执行一次的代码
            WriteLog("应用程序启动！");
        }

        // 会话启动时触发
        protected void Session_Start(object sender, EventArgs e)
        {
            WriteLog(Session.SessionID + "会话创建");
        }

        // 开始请求页面时触发
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            WriteLog("开始请求：" + Request.RawUrl);
            // 结果为"2021年7月7日:63:执行操作：开始请求：/Pages/TestApplication.aspx"
        }

        // 启用身份验证时触发
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        // 应用程序出错时触发
        protected void Application_Error(object sender, EventArgs e)
        {

        }

        // 会话结束时触发
        protected void Session_End(object sender, EventArgs e)
        {
            WriteLog(Session.SessionID + "会话结束");
        }

        // 应用程序结束时触发
        protected void Application_End(object sender, EventArgs e)
        {
            WriteLog("应用程序结束");
        }
    }
}