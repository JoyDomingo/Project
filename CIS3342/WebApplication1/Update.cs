using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Utilities;

namespace WebApplication1
{
    public class Update
    {
        SqlCommand newCommand = new SqlCommand();
        SqlParameter restaurantParameter = new SqlParameter();
        SqlParameter userParameter = new SqlParameter();
        DBConnect myDB = new DBConnect();
        DataSet myDataSet;

        public DataSet UpdateRestaurant(string name, int resType, string state, string city)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "UpdateRestaurant";

            restaurantParameter = new SqlParameter("@RestaurantType", resType);
            restaurantParameter.Direction = ParameterDirection.Input;
            restaurantParameter.SqlDbType = SqlDbType.Int;
            restaurantParameter.Size = 50;
            newCommand.Parameters.Add(restaurantParameter); 

            restaurantParameter = new SqlParameter("@RestaurantState", state);
            restaurantParameter.Direction = ParameterDirection.Input;
            restaurantParameter.SqlDbType = SqlDbType.VarChar;
            restaurantParameter.Size = 50;
            newCommand.Parameters.Add(restaurantParameter);

            restaurantParameter = new SqlParameter("@RestaurantCity", city);
            restaurantParameter.Direction = ParameterDirection.Input;
            restaurantParameter.SqlDbType = SqlDbType.VarChar;
            restaurantParameter.Size = 50;
            newCommand.Parameters.Add(restaurantParameter);

            restaurantParameter = new SqlParameter("@RestaurantName", name);
            restaurantParameter.Direction = ParameterDirection.Input;
            restaurantParameter.SqlDbType = SqlDbType.VarChar;
            restaurantParameter.Size = 100;
            newCommand.Parameters.Add(restaurantParameter);

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }
    }
}