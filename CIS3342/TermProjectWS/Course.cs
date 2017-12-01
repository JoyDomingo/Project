using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TermProjectWS
{
    public class Course
    {
        private string courseName;
        private string courseDescription;
        private string courseDate;
        private string courseHours;
        private string courseCredits;
        private int id;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public string CourseDescription
        {
            get { return courseDescription; }
            set { courseDescription = value; }
        }

        public string Date
        {
            get { return courseDate; }
            set { courseDate = value; }
        }
        public string Hours
        {
            get { return courseHours; }
            set { courseHours = value; }
        }

        public string Credits
        {
            get { return courseCredits; }
            set { courseCredits = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}