using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace CreditCardClass
{
    public class CreditData
    {
        SqlCommand newCommand = new SqlCommand();
        SqlParameter cardParameter = new SqlParameter();
        DBConnect myDB = new DBConnect();
        DataSet myDataSet;
        public DataSet AddNewCreditCard(int CreditCardNumber, string firstName, string lastName, int code, float availAmount, float owed)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "AddNewCreditCard";

            cardParameter = new SqlParameter("@cardNumber", CreditCardNumber);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.Int;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@firstName", firstName);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.VarChar;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@lastName", lastName);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.VarChar;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@cardCode", code);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.Int;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@availAmount", availAmount);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.Float;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@owed", owed);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.Float;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet UpdateCreditCard(string firstName, string lastName, int card, int cvv, float available, float owed)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "UpdateCardAccount";

            cardParameter = new SqlParameter("@firstName", firstName);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.VarChar;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@lastName", lastName);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.VarChar;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@cardNumber", card);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.Int;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@Cvv", cvv);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.Int;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@avail", available);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.Float;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@owed", owed);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.Float;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet GetCardAccount(int cardNumber)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "GetCreditCardAccount";

            cardParameter = new SqlParameter("@cardNumber", cardNumber);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.Int;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet AddNewTransaction(int number, string description, float price, string date, int zipcode, string address, string state, string city)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "AddTransactions";

            cardParameter = new SqlParameter("@cardNumber", number);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.Int;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@description", description);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.VarChar;
            cardParameter.Size = 100;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@price", price);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.Float;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@expDate", date);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.VarChar;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@ZipCode", zipcode);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.Int;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@address", address);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.VarChar;
            cardParameter.Size = 100;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@state", state);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.VarChar;
            cardParameter.Size = 100;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@city", city);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.VarChar;
            cardParameter.Size = 100;
            newCommand.Parameters.Add(cardParameter);

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet getMaxBalance()
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "GetMaxBalance";

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet CreditCardTransaction(int cardNumber, string first, string last, int cvv, string date)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "SelectAllTransactions";

            cardParameter = new SqlParameter("@CreditCardNumber", cardNumber);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.Int;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@First", first);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.VarChar;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@last", last);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.VarChar;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@cvv", cvv);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.Int;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);

            cardParameter = new SqlParameter("@exDate", date);
            cardParameter.Direction = ParameterDirection.Input;
            cardParameter.SqlDbType = SqlDbType.VarChar;
            cardParameter.Size = 50;
            newCommand.Parameters.Add(cardParameter);


            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }
    }
}
