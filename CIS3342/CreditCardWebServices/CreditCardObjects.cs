using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreditCardWebServices
{
    public class CreditCardObjects
    {
        private int Number;
        private string firstName;
        private string lastName;
        private int cvv;
        private float availamount;
        private float owed;
        private string exDate;

        public string date
        {
            get { return exDate; }
            set { exDate = value; }
        }
        public float amountOwed
        {
            get { return owed; }
            set { owed = value; }
        }
        public float availamountBalance
        {
            get { return availamount; }
            set { availamount = value; }
        }
        public int cardNumber
        {
            get { return Number; }
            set { Number = value; }
        }

        public string first
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string last
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int code
        {
            get { return cvv; }
            set { cvv = value; }
        }
    }
}