using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TermProjectWS
{
    public class Students
    {
        private int id;
        private int grad;

        public int StudentID
        {
            get { return id; }
            set { id = value; }
        }
        public int StudentGradYear
        {
            get { return grad; }
            set { grad = value; }
        }
    }
}