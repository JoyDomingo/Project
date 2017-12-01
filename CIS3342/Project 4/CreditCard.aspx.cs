using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using CreditCardClass;

namespace Project_4
{
    public partial class CreditCard : System.Web.UI.Page
    {
        CreditCardClass.CreditData newcard = new CreditCardClass.CreditData();
        DataSet myDataSet;
        CreditSvc.CreditCard pxy = new CreditSvc.CreditCard();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmitCardNumber_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtCreditNumber.Text);

            myDataSet = pxy.getAccountByNumber(number);

            gvViewAccount.DataSource = myDataSet;
            gvViewAccount.DataBind();

        }

        protected void btnGetAccount_Click(object sender, EventArgs e)
        {
            lblEnterCardNumber.Visible = true;
            txtCreditNumber.Visible = true;
            btnSubmitCardNumber.Visible = true;
            gvViewAccount.Visible = true;

            lblAddLastName.Visible = false;
            lblNewFirstName.Visible = false;
            lblNewCvv.Visible = false;
            lblNewMaxAmount.Visible = false;
            txtNewCvv.Visible = false;
            txtNewFirstName.Visible = false;
            txtNewLastName.Visible = false;
            ddlMaxBalance.Visible = false;
            btnCreate.Visible = false;
        }

        protected void btnAddCreditCard_Click(object sender, EventArgs e)
        {
            lblEnterCardNumber.Visible = true;
            txtCreditNumber.Visible = true;

            lblAddLastName.Visible = true;
            lblNewFirstName.Visible = true;
            lblNewCvv.Visible = true;
            lblNewMaxAmount.Visible = true;
            txtNewCvv.Visible = true;
            txtNewFirstName.Visible = true;
            txtNewLastName.Visible = true;
            ddlMaxBalance.Visible = true;
            btnCreate.Visible = true;
            ddlMaxBalance.DataSource = newcard.getMaxBalance();
            ddlMaxBalance.DataTextField = "MaxBalance";
            ddlMaxBalance.DataValueField = "BalanceID";
            ddlMaxBalance.DataBind();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            CreditSvc.CreditCardObjects credit = null;

            credit = new CreditSvc.CreditCardObjects();
            credit.first = txtNewFirstName.Text;
            credit.last = txtNewLastName.Text;
            credit.cardNumber = int.Parse(txtCreditNumber.Text);
            credit.code = int.Parse(txtNewCvv.Text);
            credit.availamountBalance = float.Parse(ddlMaxBalance.SelectedValue);
            credit.amountOwed = 0;
            lblError.Visible = true;
            if (pxy.AddCreditCard(credit, "1234"))
            {
                lblError.Text = "Credit Card Account Created";
            }
            else
            {
                lblError.Text = "Credit Card Account Not Created";
            }

        }

        protected void btnUpdateCreditCard_Click(object sender, EventArgs e)
        {
            lblEnterCardNumber.Visible = true;
            txtCreditNumber.Visible = true;
            
            btnSubmitCardNumber.Visible = false;
            gvViewAccount.Visible = false;

            lblAddLastName.Visible = false;
            lblNewFirstName.Visible = false;
            lblNewCvv.Visible = false;
            lblNewMaxAmount.Visible = false;
            txtNewCvv.Visible = false;
            txtNewFirstName.Visible = false;
            txtNewLastName.Visible = false;
            ddlMaxBalance.Visible = false;
            btnCreate.Visible = false;
            btnSubmitUpdate.Visible = true;
        }

        protected void btnSubmitUpdate_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtCreditNumber.Text);
            myDataSet = pxy.getAccountByNumber(number);

            gvUpdate.Visible = true;
            gvUpdate.DataSource = myDataSet;
            gvUpdate.DataBind();            
        }

        protected void gvUpdate_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;
            TextBox tBox;
            Label label;
            DropDownList ddlUpdate;

            label = (Label)gvUpdate.Rows[rowIndex].FindControl("lblUpdateCardNumber");
            int cardNumber = int.Parse(label.Text);

            label = (Label)gvUpdate.Rows[rowIndex].FindControl("lblUpdateAmountOwed");
            float owed = float.Parse(label.Text);

            tBox = (TextBox)gvUpdate.Rows[rowIndex].FindControl("txtUpdateFirstName");
            string first = tBox.Text;

            tBox = (TextBox)gvUpdate.Rows[rowIndex].FindControl("txtUpdateLastName");
            string last = tBox.Text;

            tBox = (TextBox)gvUpdate.Rows[rowIndex].FindControl("txtUpdateCvv");
            int cvv = int.Parse(tBox.Text);

            ddlUpdate = (DropDownList)gvUpdate.Rows[rowIndex].FindControl("ddlUpdateMax");
            int max = int.Parse(ddlUpdate.SelectedValue);

            gvUpdate.EditIndex = -1;

            CreditSvc.CreditCardObjects credit = null;

            credit = new CreditSvc.CreditCardObjects();
            credit.cardNumber = cardNumber;
            credit.first = first;
            credit.last = last;
            credit.code = cvv;
            credit.availamountBalance = max;
            credit.amountOwed = owed;

            lblError.Visible = true;
            if (pxy.UpdateCreditCardInfor(credit, "12345"))
            {
                lblError.Text = "Credit Card Account Created";

                gvUpdate.DataSource = myDataSet;
                gvUpdate.DataBind();
            }
            else
            {
                lblError.Text = "Credit Card Account Not Created";
            }

        }

        protected void btnSubmitTransaction_Click(object sender, EventArgs e)
        {            

            CreditSvc.CreditCardTransactions credit = null;

            credit = new CreditSvc.CreditCardTransactions();
            credit.PDescription = txtNewProductName.Text;
            credit.pPrice = float.Parse(txtNewProductPrice.Text);
            credit.CreditZipCode = int.Parse(txtNewZipCode.Text);
            credit.CreditState = txtNewState.Text;
            credit.CreditAddress = txtNewState.Text;
            credit.CreditCity = txtNewCity.Text;

            CreditSvc.CreditCardObjects CreditCard = null;

            CreditCard = new CreditSvc.CreditCardObjects();
            CreditCard.cardNumber = int.Parse(txtTransactionCardNumber.Text);
            CreditCard.code = int.Parse(txtTransactionCvv.Text);
            CreditCard.first = txtTransactionFirstName.Text;
            CreditCard.last = txtTransactionLastName.Text;
            CreditCard.date = txtTransactionExDate.Text;

            if (pxy.CompareCardTransaction(CreditCard))
            {
                lblError.Visible = true;

                if (pxy.AddNewTransactions(credit))
                {
                    lblError.Text = "Transaction Approved";
                }
                else
                {
                    lblError.Text = "Transaction Not Approved";
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Credit Card information was incorrect";
            }
        }
        protected void btnAddTransaction_Click(object sender, EventArgs e)
        {
            lblEnterCardNumber.Visible = false;
            txtCreditNumber.Visible = false;

            btnSubmitCardNumber.Visible = false;
            gvViewAccount.Visible = false;

            lblAddLastName.Visible = false;
            lblNewFirstName.Visible = false;
            lblNewCvv.Visible = false;
            lblNewMaxAmount.Visible = false;
            txtNewCvv.Visible = false;
            txtNewFirstName.Visible = false;
            txtNewLastName.Visible = false;
            ddlMaxBalance.Visible = false;
            btnCreate.Visible = false;

            lblProductDescription.Visible = true;
            lblNewProductPrice.Visible = true;
            lblNewAddress.Visible = true;
            lblNewCity.Visible = true;
            lblBillingInfo.Visible = true;
            lblNewZipCode.Visible = true;
            lblNewState.Visible = true;
            lblTransactionCardNumber.Visible = true;
            lblTransactionCvv.Visible = true;
            lblTransactionExpDate.Visible = true;
            lblTransactionFirstName.Visible = true;
            lblTransactionLastName.Visible = true;

            txtTransactionCardNumber.Visible = true;
            txtTransactionExDate.Visible = true;
            txtTransactionFirstName.Visible = true;
            txtTransactionLastName.Visible = true;
            txtTransactionCvv.Visible = true;
            txtNewAddress.Visible = true;
            txtNewProductName.Visible = true;
            txtNewProductPrice.Visible = true;
            txtNewZipCode.Visible = true;
            txtNewState.Visible = true;
            txtNewCity.Visible = true;

            btnSubmitTransaction.Visible = true;
        }

        protected void btnMakePayment_Click(object sender, EventArgs e)
        {

            lblEnterCardNumber.Visible = true;
            txtCreditNumber.Visible = true;
        }
    }
}