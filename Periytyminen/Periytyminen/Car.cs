using System;
using System.Collections.Generic;
using System.Text;

namespace Periytyminen
{
    class Car : Vehicle
    {
        protected int engine;
        protected string model;
        protected int numberOfDoors;

        public Car()
        {
            engine = 0;
            model = "blank";
            numberOfDoors = 0;
        }

        public Car(string type, string brand, string year, double price, int engine, string model, int numberOfDoors)
            : base(type, brand, year, price)
        {
            this.engine = engine;
            this.model = model;
            this.numberOfDoors = numberOfDoors;
        }

        public override string PrintData()
        {
            return $"{base.PrintData()}\nEngine: {this.engine}\nModel: {this.model}\nNumber of doors: {this.numberOfDoors}";
        }

      
        public override string ToString()
        {
            return $"{base.ToString()}\nEngine: {this.engine}\nModel: {this.model}\nNumber of doors: {this.numberOfDoors}";
        }

      
        public override bool Equals(object obj)
        {
            Car carItem = obj as Car; 
            if (carItem == null)
            {
                return false;
            }
            else
            {
                return this.brand.Equals(carItem.brand) &&
                       this.model.Equals(carItem.model) &&
                       this.price.Equals(carItem.price) &&
                       this.engine.Equals(carItem.engine) &&
                       this.numberOfDoors.Equals(carItem.numberOfDoors) &&
                       this.year.Equals(carItem.year); 
            }
        }

    }
}

