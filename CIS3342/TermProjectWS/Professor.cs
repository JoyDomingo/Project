using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TermProjectWS
{
    public class Professor
    {
        private int id;
        private string department;

        public int ProfId
        {
            get { return id; }
            set { id = value; }
        }

        public string ProfDepartment
        {
            get { return department; }
            set { department = value; }
        }
    }
}