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
    public partial class AddRestaurantPage : System.Web.UI.Page
    {
        SqlCommand newCommand = new SqlCommand();
        DBConnect myDB = new DBConnect();

        DatabaseClass newdatabase = new DatabaseClass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBackToMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("NormalPage.aspx");
        }

        protected void btnCreateRes_Click(object sender, EventArgs e)
        {
            string newName = txtAddResName.Text;
            int newType = int.Parse(ddlResType.SelectedValue);
            string resCity = txtAddCity.Text;
            string resState = txtAddResState.Text;

            newdatabase.AddRestaurant(newName, newType, resCity, resState);
            Response.Redirect("Representative.aspx");
        }

    }
}