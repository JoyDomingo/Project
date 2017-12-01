using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using CreditCardClass;
using System.Collections;
using System.Data.SqlClient;
using Utilities;

namespace CreditCardWebServices
{
    /// <summary>
    /// Summary description for CreditCard
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CreditCard : System.Web.Services.WebService
    {
        SqlCommand newCommand = new SqlCommand();
        SqlParameter cardParameter = new SqlParameter();
        DBConnect myDB = new DBConnect();
        DataSet myDataSet;
        CreditData newCard = new CreditData();
        

        [WebMethod]
        public Boolean AddCreditCard(CreditCardObjects credit, string password)
        {

            if (credit != null)
            {
                int number = credit.cardNumber;
                string first = credit.first;
                string last = credit.last;
                int code = credit.code;
                float amount = credit.availamountBalance;
                float owed = credit.amountOwed;

                newCard.AddNewCreditCard(number, first, last, code, amount, owed);
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public DataSet getAccountByNumber(int cardNumber)
        {
            myDataSet = newCard.GetCardAccount(cardNumber);
            return myDataSet;
        }

        [WebMethod]
        public Boolean UpdateCreditCardInfor(CreditCardObjects credit, string password)
        {
            if (credit != null)
            {
                int number = credit.cardNumber;
                string first = credit.first;
                string last = credit.last;
                int code = credit.code;
                float amount = credit.availamountBalance;
                float owed = credit.amountOwed;
                myDataSet = newCard.UpdateCreditCard(first, last, number, code, amount, owed);

                return true;
            }
            else
            {
                return false;
            }
        }
        [WebMethod]
        public Boolean AddNewTransactions(CreditCardTransactions credit)
        {

            if (credit != null)
            {
                int number = credit.cardNumber;
                string desc = credit.PDescription;
                float price = credit.pPrice;
                string exDate = credit.cardDate;
                int zipcode = credit.CreditZipCode;
                string address = credit.CreditAddress;
                string state = credit.CreditState;
                string city = credit.CreditCity;

                newCard.AddNewTransaction(number, desc, price, exDate, zipcode, address, state, city);

                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public Boolean CompareCardTransaction(CreditCardObjects credit)
        {
            int cardNumber = credit.cardNumber;
            string first = credit.first;
            string last = credit.last;
            int cvv = credit.code;
            string date = credit.date;

            myDataSet = newCard.CreditCardTransaction(cardNumber, first, last, cvv, date);

            if (myDataSet != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //[WebMethod]
        //public ArrayList getTransactionsByNumber(int number, string password)
        //{
        //    ArrayList transactionList = new ArrayList();
        //    myDataSet = newCard.SelectAllTransaction(number);

        //    int count = 0;

        //    for (int i = 0; i < count; i++)
        //    {
        //        CreditCardTransactions credit = new CreditCardTransactions();
        //        credit.cardNumber = int.Parse(myDataSet.Tables["CreditCardNumber"].ToString());
        //        credit.first = myDataSet.Tables["CardFirstName"].ToString();
        //        credit.last = myDataSet.Tables["CardLastName"].ToString();
        //        credit.code = int.Parse(myDataSet.Tables["CreditCardCvv"].ToString());
        //        credit.PDescription = myDataSet.Tables["PurchaseDescription"].ToString();
        //        credit.pPrice = int.Parse(myDataSet.Tables["PurchasePrice"].ToString());
        //        credit.cardDate = myDataSet.Tables["ExpirationDate"].ToString();

        //        transactionList.Add(credit);
        //    }

        //    return transactionList;
        //}

        //[WebMethod]
        //public ArrayList AddNewTransactionToCard(CreditCardTransactions credit, string password)
        //{
        //    ArrayList transactionList = new ArrayList();

        //    int number = credit.cardNumber;
        //    string description = credit.PDescription;
        //    int price = credit.pPrice;
        //    string date = credit.cardDate;
        //    int cvv = credit.code;
        //    string first = credit.first;
        //    string last = credit.last;
        //    myDataSet = newCard.AddNewTransaction(number, description, price, date, cvv, first, last);

        //    transactionList.Add(myDataSet);

        //    return transactionList;
        //}

        //[WebMethod]
        //public Boolean UpdateCreditCardInfor(CreditCardObjects credit, string password)
        //{
        //    if (credit != null)
        //    {
        //        int number = credit.cardNumber;
        //        string first = credit.first;
        //        string last = credit.last;
        //        int code = credit.code;
        //        float amount = credit.availamountBalance;
        //        myDataSet = newCard.UpdateCreditCard(first, last, number, code, amount);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
