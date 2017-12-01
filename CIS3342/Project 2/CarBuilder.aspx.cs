using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using CarLibrary;
using Utilities;
using System.Globalization;


namespace Project_2
{
    public partial class Test_2 : System.Web.UI.Page
    {
        DBConnect myDB = new DBConnect();
        Validations newVal = new Validations();
        ArrayList arrCarPackages = new ArrayList();
        double total = 0;
        const int first = 0;
        const int second = 1;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                string selectSQL = "SELECT DISTINCT CarMake FROM Cars  ";
                ddlMaker.DataSource = myDB.GetDataSet(selectSQL);
                ddlMaker.DataTextField = "CarMake";
                ddlMaker.DataBind();

                // Bind initial values for model dropdown
                DataSet mDataSet = myDB.GetDataSet("SELECT CarID, CarModel FROM Cars WHERE CarMake = '" + ddlMaker.Text + "'");
                ddlModel.DataSource = mDataSet;
                ddlModel.DataTextField = "CarModel";
                ddlModel.DataValueField = "CarID";
                ddlModel.DataBind();
            }

            else
            {
                DataSet myDataset = myDB.GetDataSet("SELECT CarID, CarModel FROM Cars WHERE CarMake = '" + ddlMaker.Text + "'");


                ddlModel.DataSource = myDataset;
                ddlModel.DataTextField = "CarModel";
                ddlModel.DataValueField = "CarID";
                //ddlModel.DataBind();

            }
        }

        protected void ddlModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string packageSql = "SELECT p.Price, p.PackageDescription FROM Packages p, Cars c WHERE p.CarID = c.CarID AND p.CarID = " + ddlModel.SelectedValue;
            //Response.Write(packageSql);                               
            gvCar.DataSource = myDB.GetDataSet(packageSql);
            gvCar.DataBind();
        }

        protected void ddlMaker_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet myDataset = myDB.GetDataSet("SELECT CarID, CarModel FROM Cars WHERE CarMake = '" + ddlMaker.Text.ToString() + "'");

            //Response.Write(modelSql);
            ddlModel.DataSource = myDataset;
            ddlModel.DataTextField = "CarModel";
            ddlModel.DataValueField = "CarID";
            ddlModel.DataBind();
        }

        public void hide()
        {
            ddlMaker.Visible = false;
            ddlMaker.Enabled = false;
            ddlModel.Visible = false;
            ddlModel.Enabled = false;
            gvCar.Enabled = false;
            gvCar.Visible = false;
            tbxAddress.Visible = false;
            tbxName.Visible = false;
            tbxNumber.Visible = false;
            tbxNumber.Enabled = false;
            tbxName.Enabled = false;
            tbxAddress.Enabled = false;
            lblAddress.Visible = false;
            lblName.Visible = false;
            lblNumber.Visible = false;
            lblDealership.Visible = false;
            lblColor.Visible = false;
            lblCarModel.Visible = false;
            lblCarMake.Visible = false;
            lblAddress.Visible = false;
            ddlColor.Visible = false;
            ddlDealership.Visible = false;
            btnBuildCar.Visible = false;
            btnBuildCar.Enabled = false;
            lblDealership.Visible = false;
            RbtnBuyRent.Visible = false;
            lblBuyRent.Visible = false;
        }

        public void show()
        {
            hide();
            lblOrder.Visible = true;
            gvOutput.Visible = true;
            gvOutput.Enabled = true;
            btnManagement.Visible = true;
            btnManagement.Enabled = true;
            lblOrder1.Visible = true;
            
        }

        //public void Footer()
        //{

        //    double total = 0;
        //    const int first = 0;
        //    const int second = 1;

        //    for(int i = 0; i < gvOutput.Rows.Count; i++)
        //    {                
        //        total = total + double.Parse(gvOutput.Rows[i].Cells[second].Text, System.Globalization.NumberStyles.Currency);
        //    }

        //    gvOutput.Columns[first].FooterText = "Totals: ";
        //    gvOutput.Columns[second].FooterText = total.ToString("C2");

        //    gvOutput.Columns[first].FooterStyle.ForeColor = System.Drawing.Color.Red;
        //    gvOutput.Columns[second].FooterStyle.ForeColor = System.Drawing.Color.Red;

        //    gvOutput.DataBind();
        //}

        protected void btnManagement_Click(object sender, EventArgs e)
        {
            gvOutput.Visible = false;
            gvOutput.Enabled = false;
            lblOrder.Visible = false;
            lblOrder1.Visible = false;

            DataSet myDataSet = myDB.GetDataSet("SELECT CarModel, TotalSales, TotalQuantitySold FROM Cars");
            gvManagement.DataSource = myDataSet;
            gvManagement.DataBind();
        }

        protected void btnBuildCar_Click(object sender, EventArgs e)
        {
            CarClass newCar = new CarClass();
            Functions newFunction = new Functions();

            if (newVal.nameValidation(tbxName.Text) == false)
            {
                Response.Write("Invalid Input. Please Try Again Name");
                tbxAddress.Text = "";
            }
            if (newVal.NumberValidation(tbxNumber.Text) == false)
            {
                Response.Write("Invalid Input. Please Try Again Number");
                tbxNumber.Text = "";
            }
            if (newVal.addressValidation(tbxAddress.Text) == false)
            {
                Response.Write("Invalid Input. Please Try Again Address");
                tbxAddress.Text = "";
            }
            else
            {
                if (RbtnBuyRent.SelectedValue == "Rent" || RbtnBuyRent.SelectedValue == "Buy")
                {
                    CarOption newOption;
                    for (int i = 0; i < gvCar.Rows.Count; i++)
                    {
                        newOption = new CarOption();
                        CheckBox chkPackages;
                        chkPackages = (CheckBox)gvCar.Rows[i].FindControl("chkPackages");

                        if (chkPackages.Checked)
                        {
                            newCar = new CarClass();
                            string pricepackage = gvCar.Rows[i].Cells[1].Text;
                            string packageDesc = gvCar.Rows[i].Cells[2].Text;
                            newOption.price = Convert.ToDouble(pricepackage);
                            newOption.Packdescription = packageDesc;
                            arrCarPackages.Add(newOption);

                            //UPDATE
                            newFunction.updatePackageSold(packageDesc);
                        }

                    }

                    DataSet car = myDB.GetDataSet("SELECT CarYear FROM Cars WHERE CarMake = '" + ddlMaker.Text + "'");
                    int year = Convert.ToInt32(car.Tables[0].Rows[0]["CarYear"].ToString());

                    DataSet price = myDB.GetDataSet("SELECT BasePrice FROM Cars WHERE CarMake = '" + ddlMaker.SelectedValue + "' AND CarID = '" + ddlModel.SelectedValue + "'");
                    double carPrice = Convert.ToDouble(price.Tables[0].Rows[0]["BasePrice"].ToString());

                    DataSet model = myDB.GetDataSet("SELECT CarModel FROM Cars WHERE CarMake = '" + ddlMaker.SelectedValue + "'");
                    string carm = Convert.ToString(model.Tables[0].Rows[0]["CarModel"].ToString());

                    newCar.CarMake = ddlMaker.Text;
                    newCar.CarModel = carm;
                    newCar.carPrice = carPrice;
                    newCar.carYear = year;
                    newCar.CarColor = ddlColor.SelectedValue;

                    newFunction.updateQuantity(newCar.CarMake, newCar.CarModel);
                    newFunction.updateSale(newCar.CarMake, newCar.CarModel, newCar.carPrice);

                    show();

                    for (int i = 0; i < gvOutput.Rows.Count; i++)
                    {
                        total = total + double.Parse(gvOutput.Rows[i].Cells[second].Text);
                    }

                    double grandtotal = total + carPrice;

                    string otherOrder = "";

                    if (ddlDealership.Text == "Yes")
                    {
                        otherOrder += "The Dealership will contact you directly";
                    }
                    else
                    {
                        otherOrder += "The dealership will not contact you";
                    }

                    string buyRent = "";

                    if (RbtnBuyRent.Text == "Buy")
                    {
                        buyRent += "You chose to buy your car";
                    }
                    else
                    {
                        buyRent += "You chose to rent your car";
                    }

                    string order = "You ordered  a " + newCar.CarColor + " " + newCar.CarMake + " " + newCar.CarModel
                        + " " + "base priced at " + newCar.carPrice;
                    lblOrder.Text = order;

                    string order2 = "Customer Information: <br />" + "Name: " + tbxName.Text + "<br />" + "Address: " + tbxAddress.Text + "<br />" + "Phone Number: " + tbxNumber.Text + "<br />"
                        + "<br />" + otherOrder + "<br />" + buyRent + "<br />" + "Your Grand Total Is " + grandtotal.ToString();
                    lblOrder1.Text = order2;

                    gvOutput.DataSource = arrCarPackages;
                    gvOutput.DataBind();
                    

                }
                else
                {
                    Response.Write("Please Pick Buy or Rent");
                }
            }
        }
    }
}
