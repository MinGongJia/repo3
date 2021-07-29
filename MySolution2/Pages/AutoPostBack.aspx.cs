using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySolution2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;// 姓名
            string msg = "";
            switch (DateTime.Now.Hour)
            {
                case 21:
                case 22:
                    msg = "吃午饭";
                    break;
                default:
                    msg = "工作";
                    break;
            }

            msg = name + msg;

            lblMsg.Text = msg;
        }
    }
}