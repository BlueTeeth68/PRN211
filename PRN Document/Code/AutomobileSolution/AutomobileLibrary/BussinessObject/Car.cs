using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.BussinessObject
{
    public class Car
    {
        public int CarID { get; private set; }
        public string CarName { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int ReleaseYear { get; set; }

        public Car() { }
        public Car(int carID, string carName, string manufacturer, decimal price, int releaseYear)
        {
            CarID = carID;
            CarName = carName;
            Manufacturer = manufacturer;
            Price = price;
            ReleaseYear = releaseYear;
        }


    }
}
