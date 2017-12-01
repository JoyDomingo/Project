using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TermProjectWebServices
{
    /// <summary>
    /// Summary description for TermProject
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BlackBoardService : System.Web.Services.WebService
    {
        WSStoredProcedures newStoredProcedure = new WSStoredProcedures();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public Boolean AddCourse(BlackBoardCourse course)
        {
            int id = course.courseID;
            string name = course.courseName;
            string description = course.courseDescription;
            int credits = course.courseCredit;
            try
            {
                newStoredProcedure.AddNewCourse(id, name, description, credits);
                return true;
            }
            catch
            {
                return false;
            }            
        }

        [WebMethod]
        public Boolean DeleteCourse (BlackBoardCourse course)
        {
            int id = course.courseID;

            try
            {
                newStoredProcedure.DeleteCourse(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
        

    }
}
