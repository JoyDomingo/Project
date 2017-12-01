using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Utilities;


namespace WebApplication1
{
    public class GetData
    {
        SqlCommand newCommand = new SqlCommand();
        SqlParameter restaurantParameter = new SqlParameter();
        SqlParameter userParameter1 = new SqlParameter();
        SqlParameter userParameter2 = new SqlParameter();
        SqlParameter userParameter3 = new SqlParameter();
        SqlParameter userParameter4 = new SqlParameter();
        SqlParameter userParameter5 = new SqlParameter();
        DBConnect myDB = new DBConnect();
        DataSet myDataSet;

        public DataSet getRestaurants()
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "GetRestaurants";
            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet ResWithType()
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "AllResWithType";
            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet getRestaurantName(string resName)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "GetRestaurantName";
            newCommand.Parameters.AddWithValue("@ResName", resName);
            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet GetRestaurantType(string resType)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "GetRestaurantType";
            newCommand.Parameters.AddWithValue("@ResType", resType);
            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet UserLogin(string type)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "GetUserType";
            newCommand.Parameters.AddWithValue("@UserName", type);

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }


        public DataSet SelectReviews(string restaurant)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "SelectReviews";
            newCommand.Parameters.AddWithValue("@restaurant", restaurant);
            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet GetUserName(string user)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "GetUserName";
            newCommand.Parameters.AddWithValue("UserName", user);
            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet GetUserType (string user)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "GetUserType";
            newCommand.Parameters.AddWithValue("UserName", user);
            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet GetRepRestaurant (string userName)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "GetUserType";
            newCommand.Parameters.AddWithValue("UserName", userName);
            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet AllRestaurantName()
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "RestaurantName";
            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

    }
}