using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TermProjectWS
{
    public class User
    {
        private int id;
        private string first;
        private string last;
        private string email;
        private string password;
        private string type;

        public int userID
        {
            get { return id; }
            set { id = value; }
        }

        public string UserFirstName
        {
            get { return first; }
            set { first = value; }
        }
        public string userLastName
        {
            get { return last; }
            set { last = value; }
        }
        public string userEmail
        {
            get { return email; }
            set { email = value; }
        }
        public string Userpassword
        {
            get { return password; }
            set { password = value; }
        }
        public string userType
        {
            get { return type; }
            set { type = value; }
        }

    }
}