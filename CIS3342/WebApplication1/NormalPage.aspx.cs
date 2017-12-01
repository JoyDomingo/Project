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


    public partial class WebForm1 : System.Web.UI.Page
    {
        DBConnect myDB = new DBConnect();
        SqlCommand newCommand = new SqlCommand();
        GetData newData = new GetData();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Signin_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignIn Page.aspx");
        }

        protected void btnSearchType_Click(object sender, EventArgs e)
        {
            string resType = txtSearchType.Text;

            gvMainPage.DataSource = newData.GetRestaurantType(resType);
            gvMainPage.DataBind();

        }

        protected void btnAllRestaurant_Click(object sender, EventArgs e)
        {
            gvMainPage.DataSource = newData.getRestaurants();
            gvMainPage.DataBind();

        }

        protected void btnSearchName_Click(object sender, EventArgs e)
        {
            string resName = txtSearchName.Text;

            gvMainPage.DataSource = newData.getRestaurantName(resName);
            gvMainPage.DataBind();

        }

        protected void btnNewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddUser.aspx");
        }
    }
}