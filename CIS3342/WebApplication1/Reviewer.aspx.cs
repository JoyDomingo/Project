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
    public partial class Reviewer : System.Web.UI.Page
    {
        DBConnect myDB = new DBConnect();
        SqlCommand newCommand = new SqlCommand();
        GetData newData = new GetData();

        DatabaseClass newdataBase = new DatabaseClass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            gvReview.DataSource = newData.SelectReviews(ddlRestaurants.SelectedValue);
            gvReview.DataBind();
        }

        protected void Signin_Click(object sender, EventArgs e)
        {
            Response.Redirect("NormalPage.aspx");
        }

        protected void btnReservations_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reservations.aspx");
        }

        protected void btnview_Click(object sender, EventArgs e)
        {

            ddlRestaurants.DataSource = newData.AllRestaurantName();
            ddlRestaurants.DataValueField = "RestaurantName";
            ddlRestaurants.DataTextField = "RestaurantName";
            ddlRestaurants.DataBind();

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lblAddReview.Visible = true;
            lblCostRating.Visible = true;
            lblFoodRating.Visible = true;
            lblServiceRating.Visible = true;
            ddlCostRating.Visible = true;
            ddlFoodRating.Visible = true;
            ddlServices.Visible = true;
            txtReview.Visible = true;

            btnAddtoData.Visible = true;

            ddlRestaurants.DataSource = newData.AllRestaurantName();
            ddlRestaurants.DataValueField = "RestaurantID";
            ddlRestaurants.DataTextField = "RestaurantName";
            ddlRestaurants.DataBind();
        }

        protected void btnAddtoData_Click(object sender, EventArgs e)
        {
            int cost = int.Parse(ddlCostRating.SelectedValue);
            int food = int.Parse(ddlFoodRating.SelectedValue);
            int service = int.Parse(ddlServices.SelectedValue);
            int resid = int.Parse(ddlRestaurants.SelectedValue);

            string review = txtReview.Text;

            newdataBase.AddReview(review, food, service, cost, resid);

            Response.Redirect("Reviewer.aspx");
        }

        protected void btnEditReview_Click(object sender, EventArgs e)
        {

        }
    }
}