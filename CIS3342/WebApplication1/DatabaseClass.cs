using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public class DatabaseClass
    {
        SqlCommand newCommand = new SqlCommand();
        SqlParameter restaurantParameter = new SqlParameter();
        SqlParameter userParameter = new SqlParameter();
        DBConnect myDB = new DBConnect();
        DataSet myDataSet;
        SqlParameter reservationParameter = new SqlParameter();
        SqlParameter reviewParameter = new SqlParameter();

        public DataSet AddRestaurant(string resName, int resType, string resState, string resCity)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "CreateRestaurant";


            restaurantParameter = new SqlParameter("@ResName", resName);
            restaurantParameter.Direction = ParameterDirection.Input;
            restaurantParameter.SqlDbType = SqlDbType.VarChar;
            restaurantParameter.Size = 50;
            newCommand.Parameters.Add(restaurantParameter);

            restaurantParameter = new SqlParameter("@ResType", resType);
            restaurantParameter.Direction = ParameterDirection.Input;
            restaurantParameter.SqlDbType = SqlDbType.Int;
            restaurantParameter.Size = 50;
            newCommand.Parameters.Add(restaurantParameter);

            restaurantParameter = new SqlParameter("@ResState", resState);
            restaurantParameter.Direction = ParameterDirection.Input;
            restaurantParameter.SqlDbType = SqlDbType.VarChar;
            restaurantParameter.Size = 50;
            newCommand.Parameters.Add(restaurantParameter);

            restaurantParameter = new SqlParameter("@ResCity", resCity);
            restaurantParameter.Direction = ParameterDirection.Input;
            restaurantParameter.SqlDbType = SqlDbType.VarChar;
            restaurantParameter.Size = 50;
            newCommand.Parameters.Add(restaurantParameter);

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet addUser(string username, string firstName, string lastName, int usertype)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "InsertUserName";

            userParameter = new SqlParameter("@UserFirstName", firstName);
            userParameter.Direction = ParameterDirection.Input;
            userParameter.SqlDbType = SqlDbType.VarChar;
            userParameter.Size = 50;
            newCommand.Parameters.Add(userParameter);

            userParameter = new SqlParameter("@newUser", username);
            userParameter.Direction = ParameterDirection.Input;
            userParameter.SqlDbType = SqlDbType.VarChar;
            userParameter.Size = 50;
            newCommand.Parameters.Add(userParameter);

            userParameter = new SqlParameter("@UserLastName", lastName);
            userParameter.Direction = ParameterDirection.Input;
            userParameter.SqlDbType = SqlDbType.VarChar;
            userParameter.Size = 50;
            newCommand.Parameters.Add(userParameter);

            userParameter = new SqlParameter("@UserType", usertype);
            userParameter.Direction = ParameterDirection.Input;
            userParameter.SqlDbType = SqlDbType.Int;
            userParameter.Size = 50;
            newCommand.Parameters.Add(userParameter);


            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;


        }

        public DataSet AddReservation(string date, string time, int restaurant)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "AddReservations";

            reservationParameter = new SqlParameter("@Date", date);
            reservationParameter.Direction = ParameterDirection.Input;
            reservationParameter.SqlDbType = SqlDbType.VarChar;
            reservationParameter.Size = 50;
            newCommand.Parameters.Add(reservationParameter);

            reservationParameter = new SqlParameter("@time", time);
            reservationParameter.Direction = ParameterDirection.Input;
            reservationParameter.SqlDbType = SqlDbType.VarChar;
            reservationParameter.Size = 50;
            newCommand.Parameters.Add(reservationParameter);

            reservationParameter = new SqlParameter("@RestaurantID", restaurant);
            reservationParameter.Direction = ParameterDirection.Input;
            reservationParameter.SqlDbType = SqlDbType.Int;
            reservationParameter.Size = 50;
            newCommand.Parameters.Add(reservationParameter);

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet AddReview(string review, int food, int service, int cost, int resID)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "AddReviews";

            reviewParameter = new SqlParameter("@Reviews", review);
            reviewParameter.Direction = ParameterDirection.Input;
            reviewParameter.SqlDbType = SqlDbType.VarChar;
            reviewParameter.Size = 50;
            newCommand.Parameters.Add(reviewParameter);

            reviewParameter = new SqlParameter("@food", food);
            reviewParameter.Direction = ParameterDirection.Input;
            reviewParameter.SqlDbType = SqlDbType.Int;
            reviewParameter.Size = 50;
            newCommand.Parameters.Add(reviewParameter);

            reviewParameter = new SqlParameter("@service", service);
            reviewParameter.Direction = ParameterDirection.Input;
            reviewParameter.SqlDbType = SqlDbType.Int;
            reviewParameter.Size = 50;
            newCommand.Parameters.Add(reviewParameter);

            reviewParameter = new SqlParameter("@cost", cost);
            reviewParameter.Direction = ParameterDirection.Input;
            reviewParameter.SqlDbType = SqlDbType.Int;
            reviewParameter.Size = 50;
            newCommand.Parameters.Add(reviewParameter);

            reviewParameter = new SqlParameter("@resId", resID);
            reviewParameter.Direction = ParameterDirection.Input;
            reviewParameter.SqlDbType = SqlDbType.Int;
            reviewParameter.Size = 50;
            newCommand.Parameters.Add(reviewParameter);

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }
        

    }
}