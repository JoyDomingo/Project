using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class StudentPage : System.Web.UI.Page
    {

        BlackboardSvc.Blackboard pxy = new BlackboardSvc.Blackboard();
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Request.QueryString["user"];
            string id = Request.QueryString["id"];

            int userID = int.Parse(id);
            lblName.Text = user;

            if ((int)Session["check"] == 0 || Session["check"] == null)
            {
                Response.Redirect("Login Page.aspx");
            }

            gvCourses.DataSource = pxy.StudentViewCourse(userID);
            gvCourses.DataBind();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login Page.aspx");
        }

    }
}