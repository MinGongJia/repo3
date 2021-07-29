using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySolution2.AdoClass;

namespace MySolution2.Pages
{
    public partial class TestSerialize : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        List<Student> stuList = null;// 保存所有的学员

        protected void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (ViewState["stuList"] != null)
            {
                // 对象也可以序列化
                stuList = (List<Student>)ViewState["stuList"];
            } else
            {
                stuList = new List<Student>();
            }
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);

            stuList.Add(new Student(name, age));

            // 学员集合保存至视图状态中
            ViewState["stuList"] = stuList;

            Response.Write("学生列表：<br />");
            int j = 0;
            foreach (Student stu in stuList)
            {
                j++;
                Response.Write(j + ". 姓名：" + stu.name + ",年龄：" + stu.age + "<br />");
            }
        }
    }
}