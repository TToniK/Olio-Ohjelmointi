using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_practice
{
    interface IProduct
    {
        object GetProduct();
        double CalculateTotal();
    }

    class Product : IProduct
    {
        readonly string _name = null;
        readonly double _price = 0;
        readonly int _ammount = 0;
        internal int ammount;
        internal int price;

        public Product(string name, double price, int ammount)
        {
            _name = name;
            _price = price;
            _ammount = ammount;
        }

        public object GetProduct()
        {
            return $"Tuote: {_name}\nHinta: {_price:c}\nMäärä: {_ammount} kpl";
        }

        public double CalculateTotal()
        {
            double Total = _price * _ammount;
            return Total;
        }

        
    }
}
