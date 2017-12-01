using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace WebApplication1
{
    public partial class User : System.Web.UI.Page
    {
        DBConnect myDB = new DBConnect();
        SqlCommand newCommand = new SqlCommand();
        GetData newData = new GetData();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Signin_Click(object sender, EventArgs e)
        {
            Response.Redirect("NormalPage.aspx");
        }

        protected void btnSearchType_Click(object sender, EventArgs e)
        {
            string resType = txtSearchType.Text;

            gvUserPage.DataSource = newData.GetRestaurantType(resType);
            gvUserPage.DataBind();
        }

        protected void btnSearchName_Click(object sender, EventArgs e)
        {
            string resName = txtSearchName.Text;

            gvUserPage.DataSource = newData.getRestaurantName(resName);
            gvUserPage.DataBind();
        }

        protected void btnAllRestaurant_Click(object sender, EventArgs e)
        {
            gvUserPage.DataSource = newData.getRestaurants();
            gvUserPage.DataBind();
        }

        protected void gvReviews_RowUpdating(Object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {

            int rowIndex = e.RowIndex;

            gvUserPage.EditIndex = -1;

        }

        protected void btnReservations_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reservations.aspx");
        }
    }
}