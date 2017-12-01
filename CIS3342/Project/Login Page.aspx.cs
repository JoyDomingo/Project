using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace Project
{
    public partial class Login_Page : System.Web.UI.Page
    {
        BlackboardSvc.Blackboard pxy = new BlackboardSvc.Blackboard();

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["check"] = 0;
            if (!IsPostBack && Request.Cookies["CIS3342_TP"] != null)
            {
                HttpCookie newCookie = Request.Cookies["CIS3342_TP"];
                txtUserName.Text = newCookie.Values["UserName"].ToString();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            int user = int.Parse(txtUserName.Text);
            string type = pxy.Login(user, txtPassword.Text, "API");
            string name = pxy.getName(user);

            if (type == null)
            {
                lblMessage.Text = "Account does not exist";
            }

            else if (type == "Student")
            {
                if (chkRememberMe.Checked)
                {
                    HttpCookie cookie = new HttpCookie("CIS 3342_TP");
                    cookie.Values["UserName"] = txtUserName.Text;
                    cookie.Expires = new DateTime(2025, 1, 1);

                    Response.Cookies.Add(cookie);
                }
                Session["check"] = 1;
                Response.Redirect("StudentPage.aspx?user=" + name + "&id=" + txtUserName.Text);
            }
            else if (type == "Admin")
            {
                if (chkRememberMe.Checked)
                {
                    HttpCookie cookie = new HttpCookie("CIS 3342_TP");
                    cookie.Values["UserName"] = txtUserName.Text;
                    cookie.Expires = new DateTime(2025, 1, 1);

                    Response.Cookies.Add(cookie);
                }
                Session["check"] = 2;
                Response.Redirect("AdminPage.aspx?user=" + name + "&id=" + txtUserName.Text);
            }
            else if (type == "Professor")
            {
                if (chkRememberMe.Checked)
                {
                    HttpCookie cookie = new HttpCookie("CIS 3342_TP");
                    cookie.Values["UserName"] = txtUserName.Text;
                    cookie.Expires = new DateTime(2025, 1, 1);

                    Response.Cookies.Add(cookie);
                }
                Session["check"] = 3;
                Response.Redirect("ProfessorPage.aspx?user=" + name + "&id=" + txtUserName.Text);
            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }
    }
}