using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Utilities;


namespace TermProjectWS
{
    public class TermProjectStoredProcedures
    {
        SqlCommand newCommand = new SqlCommand();
        SqlParameter UserParameter = new SqlParameter();
        SqlParameter StudentParameter = new SqlParameter();
        SqlParameter ProffesorParameter = new SqlParameter();
        SqlParameter courseParameter = new SqlParameter();
        SqlParameter LoginParameter = new SqlParameter();
        DBConnect myDB = new DBConnect();
        DataSet myDataSet;

        public string getName(int id)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "TermProjectGetName";

            LoginParameter = new SqlParameter("@id", id);
            LoginParameter.Direction = ParameterDirection.Input;
            LoginParameter.SqlDbType = SqlDbType.VarChar;
            LoginParameter.Size = 50;
            newCommand.Parameters.Add(LoginParameter);

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            string userName = myDB.GetField("UserFirstName", 0).ToString();
            return userName;
        }
        public string GetLogin(int id, string password)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "TermProjectGetLogin";

            LoginParameter = new SqlParameter("@id", id);
            LoginParameter.Direction = ParameterDirection.Input;
            LoginParameter.SqlDbType = SqlDbType.Int;
            LoginParameter.Size = 50;
            newCommand.Parameters.Add(LoginParameter);

            LoginParameter = new SqlParameter("@password", password);
            LoginParameter.Direction = ParameterDirection.Input;
            LoginParameter.SqlDbType = SqlDbType.VarChar;
            LoginParameter.Size = 50;
            newCommand.Parameters.Add(LoginParameter);

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            string userType = myDB.GetField("userType", 0).ToString();
            return userType;
        }
        public Boolean AddNewUser(int ID, string firstName, string lastName, string email, string password, string type)
        {
            newCommand.Parameters.Clear();
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "TermProjectAddNewUser";

            UserParameter = new SqlParameter("@ID", ID);
            UserParameter.Direction = ParameterDirection.Input;
            UserParameter.SqlDbType = SqlDbType.Int;
            UserParameter.Size = 50;
            newCommand.Parameters.Add(UserParameter);

            UserParameter = new SqlParameter("@firstName", firstName);
            UserParameter.Direction = ParameterDirection.Input;
            UserParameter.SqlDbType = SqlDbType.VarChar;
            UserParameter.Size = 50;
            newCommand.Parameters.Add(UserParameter);

            UserParameter = new SqlParameter("@lastName", lastName);
            UserParameter.Direction = ParameterDirection.Input;
            UserParameter.SqlDbType = SqlDbType.VarChar;
            UserParameter.Size = 50;
            newCommand.Parameters.Add(UserParameter);

            UserParameter = new SqlParameter("@email", email);
            UserParameter.Direction = ParameterDirection.Input;
            UserParameter.SqlDbType = SqlDbType.VarChar;
            UserParameter.Size = 50;
            newCommand.Parameters.Add(UserParameter);

            UserParameter = new SqlParameter("@password", password);
            UserParameter.Direction = ParameterDirection.Input;
            UserParameter.SqlDbType = SqlDbType.VarChar;
            UserParameter.Size = 50;
            newCommand.Parameters.Add(UserParameter);

            UserParameter = new SqlParameter("@usertype", type);
            UserParameter.Direction = ParameterDirection.Input;
            UserParameter.SqlDbType = SqlDbType.VarChar;
            UserParameter.Size = 50;
            newCommand.Parameters.Add(UserParameter);

            int flag = myDB.DoUpdateUsingCmdObj(newCommand);

            if (flag == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean AddNewStudent(int id, int year)
        {
            newCommand.Parameters.Clear();
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "TermProjectAddStudent";

            StudentParameter = new SqlParameter("@ID", id);
            StudentParameter.Direction = ParameterDirection.Input;
            StudentParameter.SqlDbType = SqlDbType.Int;
            StudentParameter.Size = 50;
            newCommand.Parameters.Add(StudentParameter);

            StudentParameter = new SqlParameter("@graduationYear", year);
            StudentParameter.Direction = ParameterDirection.Input;
            StudentParameter.SqlDbType = SqlDbType.Int;
            StudentParameter.Size = 50;
            newCommand.Parameters.Add(StudentParameter);

            int flag = myDB.DoUpdateUsingCmdObj(newCommand);

            if (flag == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean AddNewProf(int id, string department)
        {
            newCommand.Parameters.Clear();
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "TermProjectAddProf";

            ProffesorParameter = new SqlParameter("@ID", id);
            ProffesorParameter.Direction = ParameterDirection.Input;
            ProffesorParameter.SqlDbType = SqlDbType.Int;
            ProffesorParameter.Size = 50;
            newCommand.Parameters.Add(ProffesorParameter);

            ProffesorParameter = new SqlParameter("@department", department);
            ProffesorParameter.Direction = ParameterDirection.Input;
            ProffesorParameter.SqlDbType = SqlDbType.VarChar;
            ProffesorParameter.Size = 50;
            newCommand.Parameters.Add(ProffesorParameter);

            int flag = myDB.DoUpdateUsingCmdObj(newCommand);

            if (flag == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string getStudent(int id, string password)
        {
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "TermProjectGetLogin";

            LoginParameter = new SqlParameter("@id", id);
            LoginParameter.Direction = ParameterDirection.Input;
            LoginParameter.SqlDbType = SqlDbType.Int;
            LoginParameter.Size = 50;
            newCommand.Parameters.Add(LoginParameter);

            LoginParameter = new SqlParameter("@password", password);
            LoginParameter.Direction = ParameterDirection.Input;
            LoginParameter.SqlDbType = SqlDbType.VarChar;
            LoginParameter.Size = 50;
            newCommand.Parameters.Add(LoginParameter);

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            string userType = myDB.GetField("userType", 0).ToString();
            return userType;
        }
        public Boolean AddCourse(string name, string description, string date, string hours, int credits)
        {
            newCommand.Parameters.Clear();
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "TermProjectAddNewUser";

            courseParameter = new SqlParameter("@courseName", name);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.VarChar;
            courseParameter.Size = 50;
            newCommand.Parameters.Add(courseParameter);

            courseParameter = new SqlParameter("@description", description);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.VarChar;
            courseParameter.Size = 50;
            newCommand.Parameters.Add(courseParameter);

            courseParameter = new SqlParameter("@credit", credits);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.Int;
            courseParameter.Size = 50;
            newCommand.Parameters.Add(courseParameter);

            courseParameter = new SqlParameter("@date", date);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.VarChar;
            courseParameter.Size = 50;
            newCommand.Parameters.Add(courseParameter);

            courseParameter = new SqlParameter("@hour", hours);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.VarChar;
            courseParameter.Size = 50;
            newCommand.Parameters.Add(courseParameter);


            myDB.GetDataSetUsingCmdObj(newCommand);
            return true;
        }
        public Boolean DeleteCourse(int id)
        {
            newCommand.Parameters.Clear();
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "TermProjectAddProf";

            courseParameter = new SqlParameter("@id", id);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.Int;
            courseParameter.Size = 50;
            newCommand.Parameters.Add(courseParameter);

            myDB.GetDataSetUsingCmdObj(newCommand);
            return true;
        }

        public DataSet ViewStudentCourses(int id)
        {
            newCommand.Parameters.Clear();
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "TermProjectGetStudentCourses";

            courseParameter = new SqlParameter("@studentID", id);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.Int;
            courseParameter.Size = 50;
            newCommand.Parameters.Add(courseParameter);

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }
        public DataSet GetStudents()
        {
            newCommand.Parameters.Clear();
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "TermProjectGetStudents";

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public DataSet GetProfessorCourses(int id)
        {
            newCommand.Parameters.Clear();
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "ProfessorCourses";

            courseParameter = new SqlParameter("@ProfID", id);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.Int;
            courseParameter.Size = 50;
            newCommand.Parameters.Add(courseParameter);

            myDataSet = myDB.GetDataSetUsingCmdObj(newCommand);
            return myDataSet;
        }

        public void UpdateCourse(int id, string courseName, string description, int credit)
        {
            newCommand.Parameters.Clear();
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "TermProjectUpdateCourses";

            courseParameter = new SqlParameter("@courseID", id);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.Int;
            courseParameter.Size = 50;
            newCommand.Parameters.Add(courseParameter);

            courseParameter = new SqlParameter("@courseName", courseName);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.VarChar;
            courseParameter.Size = 50;
            newCommand.Parameters.Add(courseParameter);

            courseParameter = new SqlParameter("@courseDescription", description);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.VarChar;
            courseParameter.Size = 100;
            newCommand.Parameters.Add(courseParameter);

            courseParameter = new SqlParameter("@credit", credit);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.Int;
            courseParameter.Size = 50;
            newCommand.Parameters.Add(courseParameter);

            myDB.DoUpdateUsingCmdObj(newCommand);
        }
        public void UpdateSections(int id, int number, string day, string hours)
        {
            newCommand.Parameters.Clear();
            newCommand.CommandType = CommandType.StoredProcedure;
            newCommand.CommandText = "TermProjectUpdateSections";

            courseParameter = new SqlParameter("@courseID", id);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.Int;
            courseParameter.Size = 50;
            newCommand.Parameters.Add(courseParameter);

            courseParameter = new SqlParameter("@SectionNumber", number);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.Int;
            courseParameter.Size = 50;
            newCommand.Parameters.Add(courseParameter);

            courseParameter = new SqlParameter("@sectionDay", day);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.VarChar;
            courseParameter.Size = 50;
            newCommand.Parameters.Add(courseParameter);

            courseParameter = new SqlParameter("@sectionHours", hours);
            courseParameter.Direction = ParameterDirection.Input;
            courseParameter.SqlDbType = SqlDbType.VarChar;
            courseParameter.Size = 50;
            newCommand.Parameters.Add(courseParameter);

            myDB.DoUpdateUsingCmdObj(newCommand);
        }
    }
}
