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
    public partial class Reservations : System.Web.UI.Page
    {
        SqlCommand newCommand = new SqlCommand();
        DBConnect myDB = new DBConnect();
        DatabaseClass newdatabase = new DatabaseClass();
        GetData newData = new GetData();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblRestaurantName.Visible = true;
            ddlRestaurantName.Visible = true;
            btnSelect.Visible = true;
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            lblReservations.Visible = true;
            ddlTime.Visible = true;
            clrReservations.Visible = true;
            btnAddDone.Visible = true;

            ddlRestaurantName.DataSource = newData.AllRestaurantName();
            ddlRestaurantName.DataValueField = "RestaurantID";
            ddlRestaurantName.DataTextField = "RestaurantName";
            ddlRestaurantName.DataBind();
        }

        protected void btnAddDone_Click(object sender, EventArgs e)
        {

            ddlRestaurantName.DataSource = newData.AllRestaurantName();
            ddlRestaurantName.DataValueField = "RestaurantID";
            ddlRestaurantName.DataTextField = "RestaurantName";
            ddlRestaurantName.DataBind();

            string reservation = clrReservations.SelectedDate.ToString();
            int resId = int.Parse(ddlRestaurantName.SelectedValue);
            string timeReservation = ddlTime.SelectedValue.ToString();

            newdatabase.AddReservation(reservation, timeReservation, resId);

            Response.Redirect("NormalPage.aspx");
        }

        protected void btnMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("NormalPage.aspx");
        }

        protected void btnReservations_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reservations.aspx");
        }
    }
}