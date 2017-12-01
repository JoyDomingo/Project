using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TermProjectWS
{
    /// <summary>
    /// Summary description for Blackboard
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Blackboard : System.Web.Services.WebService
    {
        DataSet myDataSet;
        TermProjectStoredProcedures newSP = new TermProjectStoredProcedures();

        [WebMethod]
        public string getName(int id)
        {
            string name = newSP.getName(id);
            return name;
        }
        [WebMethod]
        public string Login(int userName, string password, string API)
        {
            string type = newSP.GetLogin(userName, password);
            return type;
        }
        [WebMethod]
        public Boolean AddNewUser(User newUser)
        {
            int id = newUser.userID;
            string first = newUser.UserFirstName;
            string last = newUser.userLastName;
            string email = newUser.userEmail;
            string password = newUser.Userpassword;
            string type = newUser.userType;
            Boolean flag = newSP.AddNewUser(id, first, last, email, password, type);
            return flag;
        }
        [WebMethod]
        public Boolean AddNewStudent(Students newStudent)
        {
            int id = newStudent.StudentID;
            int grad = newStudent.StudentGradYear;
            Boolean flag = newSP.AddNewStudent(id, grad);
            return flag;
        }
        [WebMethod]
        public Boolean AddNewProfessor(Professor newProf)
        {
            int id = newProf.ProfId;
            string department = newProf.ProfDepartment;
            Boolean flag = newSP.AddNewProf(id, department);
            return flag;
        }
        [WebMethod]
        public DataSet StudentViewCourse(int id)
        {
            myDataSet = newSP.ViewStudentCourses(id);
            return myDataSet;
        }
        [WebMethod]
        public DataSet ProfessorCourses(int profId)
        {
            myDataSet = newSP.GetProfessorCourses(profId);
            return myDataSet;
        }
        [WebMethod]
        public void UpdateCourses(int id, string name, string description, int credit)
        {
            newSP.UpdateCourse(id, name, description, credit);
        }
        [WebMethod]
        public void UpdateSection(int id, int number, string day, string hours)
        {
            newSP.UpdateSections(id, number, day, hours);
        }
    }
}
