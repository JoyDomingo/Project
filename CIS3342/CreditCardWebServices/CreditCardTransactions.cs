using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardClass
{
    public class CreditCardTransactions
    {
        private int Number;
        private string description;
        private float price;
        private string expirationDate;
        private string address;
        private int zipcode;
        private string state;
        private string city;
        public int cardNumber
        {
            get { return Number; }
            set { Number = value; }
        }
        public string PDescription
        {
            get { return description; }
            set { description = value; }
        }
        public float pPrice
        {
            get { return price; }
            set { price = value; }
        }
        public string cardDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }

        public string CreditAddress
        {
            get { return address; }
            set { address = value; }
        }
        public int CreditZipCode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }
        public string CreditState
        {
            get { return state; }
            set { state = value; }
        }
        public string CreditCity
        {
            get { return city; }
            set { city = value; }
        }
    }
}
