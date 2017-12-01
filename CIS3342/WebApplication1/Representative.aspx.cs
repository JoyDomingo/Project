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
    public partial class Representative : System.Web.UI.Page
    {
        DBConnect myDB = new DBConnect();
        SqlCommand newCommand = new SqlCommand();
        SqlCommand newCommandCity = new SqlCommand();
        Update newUpdate = new Update();

        GetData newData = new GetData();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAllRestaurant_Click(object sender, EventArgs e)
        {
            gvRepresentative.DataSource = newData.ResWithType();
            gvRepresentative.DataBind();

        }

        protected void gvRepresentative_SelectedIndexChanged(object sender, EventArgs e)
        {

            //txtState.Text = gvRepresentative.SelectedRow.Cells[5].Text;
            //txtCity.Text = gvRepresentative.SelectedRow.Cells[4].Text;
            //Response.Write(txtEditState.Text);
        }

        protected void gvRepresentative_RowUpdating(Object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;

            TextBox TBox;
            Label label;
            label = (Label)gvRepresentative.Rows[rowIndex].FindControl("lblName");
            string Name = label.Text;

            TBox = (TextBox)gvRepresentative.Rows[rowIndex].FindControl("txtCity");
            string City = TBox.Text;

            TBox = (TextBox)gvRepresentative.Rows[rowIndex].FindControl("txtState");
            string State = TBox.Text;

            DropDownList ddl;
            ddl = (DropDownList)gvRepresentative.Rows[rowIndex].FindControl("ddlType");
            int type = int.Parse(ddl.SelectedValue);

            gvRepresentative.EditIndex = -1;

            newUpdate.UpdateRestaurant(Name, type, State, City);

            gvRepresentative.DataSource = newData.ResWithType();
            gvRepresentative.DataBind();

        }

        protected void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddRestaurantPage.aspx");
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("NormalPage.aspx");
        }

        protected void btnReviews_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reviewer.aspx");
        }

        protected void btnReservations_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reservations.aspx");
        }
    }
}