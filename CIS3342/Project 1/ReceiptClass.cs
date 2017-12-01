using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_1
{
    public class ReceiptClass
    {
        static string receipt;
        static string sizeString = "You picked: ";
        static string extra = "";
        static string extra1 = "";
        static string extra2 = "";
        static string extra3 = "";
        static string extra4 = "";
        static string extra5 = "";
        static string meatString;
        static string cheeseString;
        static string drinkString;
        static string snackString;
        static string breadPrint;
        static string toastedPrint;

        public static double TaxTotal(double total)
        {
            double tax;

            tax = total * 0.06;
            return tax;
        }

        public static void BreadPrint(string item)
        {
            if (item == "Wheat")
            {
                breadPrint = "Wheat Bread <br/ >";
            }
            else if (item == "Italian")
            {
                breadPrint = "Italian Bread <br />";
            }
        }

        public static void SizePrint(string item)
        {


            if (item == "Small")
            {
                sizeString += "Small + $5.00 <br />";
            }
            else if (item == "Medium")
            {
                sizeString += "Medium + $8.00 <br />";
            }
            else if (item == "Large")
            {
                sizeString += "Large + $10.00 <br />";
            }

        }

        public static void Toasted(string item)
        {
            if (item == "Yes")
            {
                toastedPrint = "Toast Sandwich <br />";
            }
            else if (item == "No")
            {
                toastedPrint = "Do not Toast Sandwich <br />";
            }
        }

        public static void MeatPrint(string item)
        {
            if (item == "Bacon")
            {
                meatString += "Bacon + $1.00 <br />";
            }
            else if (item == "Pastrami")
            {
                meatString += "Pastrami + $1.00 <br />";
            }
            else if (item == "Salami")
            {
                meatString += "Salami + $1.00 <br />";
            }
            else if (item == "Turkey")
            {
                meatString = "Turkey + $0.00 <br />";
            }
            else if (item == "Ham")
            {
                meatString = "Ham + $0.00 <br />";
            }
            else if (item == "Roast Beef")
            {
                meatString = "Roast Beef + $0.00 <br />";
            }
            else
            {
                meatString = "";
            }

        }

        public static void CheesePrint(string item)
        {
            if (item == "American")
            {
                cheeseString = "American <br />";
            }
            else if (item == "Swiss")
            {
                cheeseString = "Swiss <br />";

            }
            else if (item == "Provolone")
            {
                cheeseString = "Provolone <br />";
            }
            else if (item == "Mozzarella")
            {
                cheeseString = "Mozzarella <br />";
            }
            else if (item == "Pepperjack")
            {
                cheeseString = "PepperJack + $0.50 <br />";
            }
            else
            {
                cheeseString = "";
            }
        }

        public static void extraPrint(string ExtraTop)
        {

            if (ExtraTop == "Avocado")
            {
                extra1 = "Avocado + $0.50<br />";
            }
            else if (ExtraTop == "ExtraMeat")
            {
                extra2 = "Extra Meat + $0.50<br />";
            }
            else if (ExtraTop == "ExtraSauce")
            {
                extra3 = "Extra Sauce + $0.50<br />";
            }
            else if (ExtraTop == "ExtraCheese")
            {
                extra4 = "Extra Cheese + $0.50<br />";
            }
            else if (ExtraTop == "Guacamole")
            {
                extra5 = "Guacamole + $0.50<br />";
            }
            else
            {
                extra = "No Extra Toppings Added <br />";
            }
        }

        public static void DrinkPrint(string item)
        {
            if (item == "Coke")
            {
                drinkString = "Coke + $2.5";
            }
            else if (item == "Water")
            {
                drinkString = "Water + $2.5";
            }
            else if (item == "Juice")
            {
                drinkString = "Juice + $2.5";
            }
            else
            {
                drinkString = "";
            }
        }

        public static void SnackPrint(string item)
        {
            if (item == "Chips")
            {
                snackString = "Chips + $2.50";
            }
            else if (item == "Cookies")
            {
                snackString = "Cookies + $2.50";
            }
            else if (item == "Fruit")
            {
                snackString = "Fruit + $2.50";
            }
            else
            {
                snackString = "";
            }
        }
        public static string MainReceipt(string veggie, string sauce)
        {
            receipt = "Your Receipt: <br />";
            receipt += sizeString + breadPrint + toastedPrint + meatString + cheeseString;
            receipt += veggie + "<br />" + sauce + "<br />" + extra1 + extra2 + extra3 + extra4 + extra5 + drinkString + snackString;

            return receipt;
        }
}

}