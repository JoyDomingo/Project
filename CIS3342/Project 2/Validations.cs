using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_2
{
    public class Validations
    {
        public bool nameValidation(string name)
        {

            //int isNumber;

            if (name == "")
            {
                return false;
            }
            else if (name == null)
            {
                return false;
            }
            //else if (int.TryParse(name, out isNumber))
            //{
            //    return false;
            //}
            else
            {
                return true;
            }


        }

        public bool NumberValidation(string number)
        {
            //int isString;

            if (number == "")
            {
                return false;
            }
            else if (number == null)
            {
                return false;
            }
            //else if (int.TryParse(number, out isString))
            //{
            //    return false;
            //}
            else
            {
                return true;
            }

        }

        public bool addressValidation(string address)
        {

            if (address == "")
            {
                return false;
            }
            else if (address == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}