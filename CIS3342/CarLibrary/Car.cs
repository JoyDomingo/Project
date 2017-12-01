using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace CarLibrary
{
    public class CarClass
    {

        string carModel;
        string carMake;
        string Color;
        double basePrice;
        string totalCost; // baseprice plus all the additional packages
        int year;
        double total;

        public CarClass()
        {

        }

        public CarClass(string carMake, string carModel, int carYear, double price)
        {
            this.carMake = carMake;
            this.carModel = carModel;
            this.year = carYear;
            this.basePrice = price;
        }

        public string CarMake
        {
            get { return carMake; }
            set { carMake = value; }
        }

        public string CarModel
        {
            get { return carModel; }
            set { carModel = value; }
        }

        public string totalprice
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public int carYear
        {
            get { return year; }
            set { year = value; }
        }

        public double carPrice
        {
            get { return basePrice; }
            set { basePrice = value; }
        }

        public string CarColor
        {
            get { return Color; }
            set { Color = value; }
        }


        public double totalPackages(ArrayList List)
        {
            double total = 0;

            for (int i = 0; i < List.Count; i++)
            {
                CarOption carPack = (CarOption)List[i];
                total += carPack.price;
            }
            return total;
        }

        public void totalCarPrice()
        {
            basePrice += total;
        }

    }
}
