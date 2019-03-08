using System;
using System.Globalization;
using System.Collections.Generic;

namespace Interface_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = new CultureInfo("fi-FI");

            IList<Product> productlist = new List<Product>();

            Product product1 = new Product("Omena", 0.50, 3);
            Product product2 = new Product("Banaani", 0.30, 5);
            Product product3 = new Product("Päärynä", 0.70, 7);
            

            foreach(Product p in productlist)
            {
                Console.WriteLine(p.GetProduct());
                Console.Write("Hinta yhteensä: ");
                Console.Write(p.CalculateTotal());
                Console.Write(" €");
                Console.WriteLine("\n");
            }
            IList<Customer> customerlist = new List<Customer>()
            {
                new Customer("Matti", 1200),
                new Customer("Sari", 900),
                new Customer("Kalle", 5500)
            };

            foreach(Customer c in customerlist)
            {
                Console.WriteLine(c.GetCustomer());
                Console.Write("Bonuksen määrä: "); Console.Write(c.GetBonus()); Console.Write("%");
                Console.WriteLine("\n");
            }

            Console.ReadKey();

        }
        
        
    }

    
}
