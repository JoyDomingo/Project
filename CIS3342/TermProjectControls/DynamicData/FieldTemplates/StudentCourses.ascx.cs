﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Web.DynamicData;
using Utilities;

namespace TermProjectControls.DynamicData.FieldTemplates
{
    public partial class StudentCourses : System.Web.UI.UserControl
    {
        int courseID;
        string courseName;
        int studentID;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int CourseID
        {
            get { return courseID; }
            set { courseID = value; }            
        }
        public String CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public int GetStudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public override void DataBind()
        {
            DBConnect myDB = new DBConnect();
            String strSQL = "SELECT CourseID, CourseName FROM StudentCourses S INNER JOIN Courses c ON S.CourseID = c.CourseID WHERE StudentID = " + studentID;

            myDB.GetDataSet(strSQL);

            lblCourseID.Text = (String)myDB.GetField("CourseID", 0);
            lblCourseName.Text = (String)myDB.GetField("CourseName", 0);
        }
    }
}
