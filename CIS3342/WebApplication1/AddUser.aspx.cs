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
    public partial class AddUser : System.Web.UI.Page
    {
        SqlCommand newCommand = new SqlCommand();
        DBConnect myDB = new DBConnect();
        DatabaseClass newdatabase = new DatabaseClass();
        GetData newData = new GetData();
        DataSet myDataSet;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            string firstName = txtAddFirstName.Text;
            string lastName = txtAddLastName.Text;
            string userName = txtAddUserName.Text;
            int userType = int.Parse(ddlUserType.SelectedValue);

            myDataSet = newData.GetUserName(userName);

            if (myDataSet.Tables[0].Rows.Count != 0)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "UserName Taken Please Enter Another One";
            }
            else
            {             
                if (ddlUserType.SelectedValue =="1")
                {
                    Response.Redirect("UserPage.aspx");
                }
                else if (ddlUserType.SelectedValue == "2")
                {
                    Response.Redirect("Reviewer.aspx");
                }
                else if (ddlUserType.SelectedValue == "3")
                {
                    Response.Redirect("Representative.aspx");
                }
                newdatabase.addUser(userName, firstName, lastName, userType);
            }
            lblMessage.Visible = false;

        }
    }
}                                                