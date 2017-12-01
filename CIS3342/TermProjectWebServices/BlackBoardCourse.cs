using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TermProjectWebServices
{
    public class BlackBoardCourse
    {
        private int id;
        private string name;
        private string description;
        private int credit;

        public int courseID
        {
            get { return id; }
            set { id = value; }
        }

        public string courseName
        {
            get { return name; }
            set { name = value; }
        }
        public string courseDescription
        {
            get { return description; }
            set { description = value; }
        }
        public int courseCredit
        {
            get { return credit; }
            set { credit = value; }
        }

    }

}