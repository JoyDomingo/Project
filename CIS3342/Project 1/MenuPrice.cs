using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_1
{
    public class MenuPrice
    {       

        static public double BreadSize(string item)
        {
            double sizePrice = 0;

            if (item == "Small")
            {
                sizePrice = 5.00;
            }
            else if (item == "Medium")
            {
                sizePrice = 8.00;
            }
            else if (item == "Large")
            {
                sizePrice = 10.00;
            }

            return sizePrice;
        }

        static public double BreadMeat (string item)
        {
            double meatPrice = 0;      
                  
            if(item == "Bacon" || item == "Pastrami" || item == "Salami")
            {
                meatPrice = 1.00;
            }
            else
            {

            }
            return meatPrice;            
        }

        static public double BreadCheese(string item)
        {
            double cheesePrice = 0;

            if ((item == "American") || (item == "Swiss") || (item == "Provolone") || (item == "Mozzarella"))
            {
                cheesePrice = 0;
            }
            else if (item == "Pepperjack")
            {
                cheesePrice = 0.50;
            }
            else
            {

            }
            return cheesePrice;

        }

        static public double BreadExtra(string item)
        {
            double extraPrice = 0;

            if (item == "Avocado")
            {
                extraPrice = .50;
            }
            else if (item == "ExtraMeat")
            {
                extraPrice = .50;
            }
            else if (item == "ExtraSauce")
            {
                extraPrice = .50;
            }
            else if (item == "ExtraCheese")
            {
                extraPrice = .50;
            }
            else if(item == "Guacamole")
            {
                extraPrice = .50;
            }
            else
            {

            }
            return extraPrice;
            
        }

        static public double MealDrink (string item)
        {
            double drinkPrice = 0;
            
            if (item == "Coke")
            {
                drinkPrice = 2.5;
            }
            else if(item == "Water")
            {
                drinkPrice = 2.5;
            }
            else if (item == "Juice")
            {
                drinkPrice = 2.5;
            }
            else
            {                
            }

            return drinkPrice;   
        }

        static public double MealSnack (string item)
        {
            double snackPrice = 0;
            
            if (item == "Chips")
            {
                snackPrice = 2.5;
            }
            else if (item == "Cookies")
            {
                snackPrice = 2.5;
            }
            else if (item == "Fruit")
            {
                snackPrice = 2.5;
            }
            else
            {

            }

            return snackPrice;
        }
        static public double getTip(string item)
        {
            double conTip;
            if (item == null)
            {
                conTip = 0;
            }
            else
            {
                conTip = Convert.ToDouble(item);
            }

            return conTip;
        }
        
        //static public string getTotal()
        //{

        //    string Stotal = total.ToString();
        //    return Stotal;
        //}        

    }
}