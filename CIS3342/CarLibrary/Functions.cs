using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilities;


namespace CarLibrary
{
    public class Functions
    {       

        DBConnect myDB = new DBConnect();

        public void updateSale(string carMake, string Model, double total)
        {
            double price = Convert.ToDouble(total);
            string sales = "UPDATE Cars SET TotalSales = TotalSales + " + price + " WHERE CarMake = '" + carMake + "'";
            myDB.DoUpdate(sales);
        }

        public void updateQuantity (string carMake, string Model)
        {
            string quantity = "UPDATE Cars SET TotalQuantitySold = TotalQuantitySold + 1 WHERE CarMake = '" + carMake + "'";
            myDB.DoUpdate(quantity);
        }

        public void updatePackageSold(string package)
        {
            string Carpackage = "UPDATE Packages SET TotalQuantitySold = TotalQuantitySold + 1 WHERE PackageDescription = '" + package + "'";
            myDB.DoUpdate(Carpackage);
        }

        
    }
}
