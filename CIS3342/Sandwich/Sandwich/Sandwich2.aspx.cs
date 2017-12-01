using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sandwich
{
    public partial class Sandwich2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String Size = Request["Size"];
            lblSize.Text = "You Selected " + Size + " As the Size";

            String Bread = Request["Bread"];
            lblSandwich.Text = "You Selected " + Bread + " Bread";

            String Toasted = Request["Toasted"];
            lblToasted.Text = "You Selected " + Toasted + " To Toasted";

            String Meat = Request["Meat"];
            lblMeat.Text = "You selected " + Meat;

            String Cheese = Request["Cheese"];
            lblCheese.Text = "You selected " + Cheese;

            String Veggie = Request["Veggie"];
            lblVeggie.Text = "You selected " + Veggie;

            String Sauce = Request["Sauce"];
            lblSauce.Text = "You selected " + Sauce;

            String Extra = Request["Extra"];
            lblExtra.Text = "You selected " + Extra;
        }
    }
}  