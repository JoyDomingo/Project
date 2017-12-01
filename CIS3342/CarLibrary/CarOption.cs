using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class CarOption
    {

        string description;
        double packagePrice;
        int totalSold;



        public string Packdescription
        {
            get { return description; }
            set { description = value; }
        }

        public double price
        {
            get { return packagePrice; }
            set { packagePrice = value; }
        }

    }
}
