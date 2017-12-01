using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_1
{
    public partial class Test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request["name"];
            string number = Request["number"];
            string Size = Request["size"];            
            string Bread = Request["Bread"];
            string Toasted = Request["Toasted"];
            string Meat = Request["Meat"];
            string Cheese = Request["Cheese"];
            string Veggie = Request["Veggie"];
            string Sauce = Request["Sauce"];
            string ExtraA = Request["ExtraA"];
            string ExtraM = Request["ExtraM"];
            string ExtraC = Request["ExtraC"];
            string ExtraS = Request["ExtraS"];
            string ExtraG = Request["ExtraG"];
            string drink = Request["drink"];
            string snack = Request["snack"];
            string Tip = Request["Tip"];
            string extras = ExtraA + ExtraM + ExtraC + ExtraS + ExtraG;
            ReceiptClass.SizePrint(Size);
            ReceiptClass.BreadPrint(Bread);
            ReceiptClass.Toasted(Toasted);
            ReceiptClass.MeatPrint(Meat);
            ReceiptClass.CheesePrint(Cheese);
            ReceiptClass.DrinkPrint(drink);
            ReceiptClass.SnackPrint(snack);
            ReceiptClass.extraPrint(ExtraA);
            ReceiptClass.extraPrint(ExtraM);
            ReceiptClass.extraPrint(ExtraC);
            ReceiptClass.extraPrint(ExtraS);
            ReceiptClass.extraPrint(ExtraG);

            string total;
            string tax;


            string receipt = ReceiptClass.MainReceipt(Veggie, Sauce);

            string tip = "<br />Your tip is " + Tip + "<br />";
            double extraTotal = MenuPrice.BreadExtra(ExtraA) + MenuPrice.BreadExtra(ExtraM) + MenuPrice.BreadExtra(ExtraC) + MenuPrice.BreadExtra(ExtraS) + MenuPrice.BreadExtra(ExtraG);
            double mealTotal = MenuPrice.MealDrink(drink) + MenuPrice.MealSnack(snack);

            double OrderTotal =  MenuPrice.BreadSize(Size) + MenuPrice.BreadMeat(Meat)+ MenuPrice.BreadCheese(Cheese) + extraTotal + mealTotal + MenuPrice.getTip(Tip);
            total = "Your Total comes out to " + OrderTotal + " without tax";
            tax = "Your tax is: " + ReceiptClass.TaxTotal(OrderTotal);

            double totalTax = (OrderTotal + ReceiptClass.TaxTotal(OrderTotal));

            string GrandTotal = "Your GrandTotal with tax is: " + totalTax;

            lblReceipt.Text = receipt;
            lblTip.Text = tip;
            lblTotal.Text = total;
            lblTax.Text = tax;
            lblGrandTotal.Text = GrandTotal;
        }
    }
}