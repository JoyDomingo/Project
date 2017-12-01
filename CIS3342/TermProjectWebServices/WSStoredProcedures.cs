using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Utilities;

namespace TermProjectWebServices
{
    public class WSStoredProcedures
    {
        SqlCommand newCommand = new SqlCommand();
        SqlParameter UserParameter = new SqlParameter();
        DBConnect myDB = new DBConnect();
        DataSet myDataSet;

        public void AddNewCourse(int id, string name, string description, int credits)
        {
            newCommand.Parameters.Clear();
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "TermProjectAddNewUser";

            UserParameter = new SqlParameter("@courseID", id);
            UserParameter.Direction = ParameterDirection.Input;
            UserParameter.SqlDbType = SqlDbType.Int;
            UserParameter.Size = 50;
            newCommand.Parameters.Add(UserParameter);

            UserParameter = new SqlParameter("@courseName", name);
            UserParameter.Direction = ParameterDirection.Input;
            UserParameter.SqlDbType = SqlDbType.VarChar;
            UserParameter.Size = 50;
            newCommand.Parameters.Add(UserParameter);

            UserParameter = new SqlParameter("@description", description);
            UserParameter.Direction = ParameterDirection.Input;
            UserParameter.SqlDbType = SqlDbType.VarChar;
            UserParameter.Size = 100;
            newCommand.Parameters.Add(UserParameter);

            UserParameter = new SqlParameter("@credit", credits);
            UserParameter.Direction = ParameterDirection.Input;
            UserParameter.SqlDbType = SqlDbType.Int;
            UserParameter.Size = 50;
            newCommand.Parameters.Add(UserParameter);

            myDB.DoUpdateUsingCmdObj(newCommand);
        }

        public void DeleteCourse(int id)
        {
            newCommand.Parameters.Clear();
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "TermProjectDeleteCoruse";

            UserParameter = new SqlParameter("@id", id);
            UserParameter.Direction = ParameterDirection.Input;
            UserParameter.SqlDbType = SqlDbType.Int;
            UserParameter.Size = 50;
            newCommand.Parameters.Add(UserParameter);

            myDB.DoUpdateUsingCmdObj(newCommand);
        }

        public DataSet GetCourses()
        {
            newCommand.Parameters.Clear();
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "TermProjectGetCourse";


            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

    }
}