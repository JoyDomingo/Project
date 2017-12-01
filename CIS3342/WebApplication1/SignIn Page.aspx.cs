using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace WebApplication1
{
    public partial class SignIn_Page : System.Web.UI.Page
    {

        DBConnect myDB = new DBConnect();
        SqlCommand newCommand = new SqlCommand();
        SqlCommand newCommandCity = new SqlCommand();
        Update newUpdate = new Update();

        GetData newData = new GetData();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            //newData.GetUserType(userName);
            string type = newData.GetUserType(userName).ToString();

            if (type == "1")
            {
                Response.Redirect("UserPage.aspx");
            }
            else if (type == "2")
            {
                Response.Redirect("Reviewer.aspx");
            }
            else if (type == "3")
            {
                Response.Redirect("Representative.aspx");
            }
            else
            {
                Response.Redirect("AddUser.aspx");
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("NormalPage.aspx");
        }
    }
}