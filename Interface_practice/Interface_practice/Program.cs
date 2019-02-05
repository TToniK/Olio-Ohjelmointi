using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;

namespace Interface_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = new CultureInfo("fi-FI");

            IList<Product> productlist = new List<Product>()
            {
                new Product("Omena", 0.50,3),
                new Product("Banaani", 0.30, 5),
                new Product("Päärynä", 0.70,7)
            };

            foreach(Product p in productlist)
            {
                Console.WriteLine(p.GetProduct());
                Console.WriteLine(p.CalculateTotal());
                Console.WriteLine("\n");
            }
            Console.ReadKey();

        }
        
        
    }

    
}
