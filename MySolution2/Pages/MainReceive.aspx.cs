﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MySolution2.Pages
{
    public partial class MainReceive : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Request.Form["userName"];
            lblMsg.Text = "用户名：" + userName;
        }
    }
}