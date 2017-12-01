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
    public partial class Reviews : System.Web.UI.Page
    {
        DBConnect myDB = new DBConnect();
        SqlCommand newCommand = new SqlCommand();
        SqlCommand newCommandCity = new SqlCommand();

        Update newUpdate = new Update();
        GetData newData = new GetData();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvReviews.DataSource = newData.ResWithType();
            gvReviews.DataBind();
        }

        protected void gvReviews_RowUpdating(Object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;
            
            gvReviews.EditIndex = -1;            

            //gvReviews.DataSource = newData.SelectReviews();
            gvReviews.DataBind();

        }
    }
}