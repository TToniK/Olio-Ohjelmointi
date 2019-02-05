using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_practice
{
    interface IProduct
    {
        object GetProduct();
        string CalculateTotal();
    }

    class Product : IProduct
    {
        readonly string _name = null;
        readonly double _price = 0;
        readonly int _ammount = 0;
    

        public Product(string name, double price, int ammount)
        {
            _name = name;
            _price = price;
            _ammount = ammount;
        }

        public object GetProduct()
        {
            return $"Tuote: {_name}, Hinta: {_price:c}, Määrä: {_ammount}";
        }

        public string CalculateTotal()
        {
            double Total = _price * _ammount;
            return $"Tuotteiden hinta yhteensä = {Total:c}";
        }

        public override string ToString()
        {
            return base.ToString();
            
        }
    }
}
