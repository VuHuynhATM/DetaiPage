using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarAuto.models
{
    public class Car
    {
        public string carID { set; get;}
        public string carName { set; get; }
        public string carColor { set; get; }
        public float price { set; get; }
        public int carQuantity { set; get; }
        public string image { set; get; }
        public string carDes { set; get; }
        public string carCategory { set; get; }
        public bool status { set; get; }

        public Car()
        {
        }

        public Car(string carID, string carName, string carColor, float price, int carQuantity, string image, string carDes, string carCategory, bool status)
        {
            this.carID = carID;
            this.carName = carName;
            this.carColor = carColor;
            this.price = price;
            this.carQuantity = carQuantity;
            this.image = image;
            this.carDes = carDes;
            this.carCategory = carCategory;
            this.status = status;
        }

    }
}
