using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_practice
{
    interface ICustomer
    {
        object GetCustomer();
        double GetBonus();
    }

    public class Customer : ICustomer
    {
        readonly string _name;
        readonly double _buyings;


        public Customer(string name, double buyings)
        {
            _name = name;
            _buyings = buyings;
        }
        public object GetCustomer()
        {
            return $"Asiakkaan nimi: {_name}\nOstosten arvo: {_buyings:c}";
        }
        public double GetBonus()
        {
           
            if (_buyings<=1000)
            {
                double Bonus = 2;
                return Bonus;
            }
            else if(_buyings>1000 && _buyings<=2000)
            {
                double Bonus = 3;
                return Bonus;
            }
            else
            {
                double Bonus = 5;
                return Bonus;
            }
        }
    }
}
