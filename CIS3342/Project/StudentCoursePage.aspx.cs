using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class StudentCoursePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string courseName = Request.QueryString["courseName"];
            lblCourseName.Text = courseName;

            if ((int)Session["check"] == 0)
            {
                Response.Redirect("Login Page.aspx");
            }
        }
    }
}