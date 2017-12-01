using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Request.QueryString["user"];
            string id = Request.QueryString["id"];

            int userID = int.Parse(id);
            lblName.Text = user;

            if ((int)Session["check"] == 0)
            {
                Response.Redirect("Login Page.aspx");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login Page.aspx");
        }
    }
}