using System;
using System.Collections.Generic;
using System.Text;

namespace Periytyminen
{
    class Vehicle
    {
    
        
        protected string type;
        protected string brand;
        protected string year;
        protected double price;

        
        public Vehicle()
        {
            type = "blank";
            brand = "blank";
            year = "blank";
            price = 0;
        }

       
        public Vehicle(string type, string brand, string year, double price)
        {
            this.type = type;
            this.brand = brand;
            this.year = year;
            this.price = price;
        }

       
        public virtual string PrintData()
        {
            return $"Type: {this.type}\nBrand: {this.brand}\nYear: {this.year}\nPrice: {this.price:c}";
        }

       
        public override string ToString()
        {
            return ($"Type: {this.type}\nBrand: {this.brand}\nYear: {this.year}\nPrice: {this.price:c}");
        }
    }
}