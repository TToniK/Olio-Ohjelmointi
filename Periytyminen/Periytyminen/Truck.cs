using System;
using System.Collections.Generic;
using System.Text;

namespace Periytyminen
{
    class Truck : Car
    {
     
        
        protected int loadWeight;
        protected double consumptionPerKg;

        
        public Truck()
        {
            loadWeight = 0;
            consumptionPerKg = 0;
        }

        
        public Truck(string type, string brand, string year, double price, int engine, string model, int numberOfDoors, int loadWeight, double consumptionPerKg)
            : base(type, brand, year, price, engine, model, numberOfDoors)
        {
            this.loadWeight = loadWeight;
            this.consumptionPerKg = consumptionPerKg;
        }

       
        public double CalculateConsumption()
        {
            double totalConsumption = this.loadWeight * this.consumptionPerKg;
            return totalConsumption;
        }
    }
}