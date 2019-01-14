using System;

namespace Firmaluokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on Firma-ohjelma\n\n");
            Company company1 = new Company("Leipomo", "Lappeenkatu 11","0404455",100000,50000);
            Company company2 = new Company(company1)
            {
                Title = "Kahvila",
                Address = "Valtakatu 5",
                Phone = "050654128",
                Income = 500000,
                Expense = 50000
            };
            Console.WriteLine(company1.Info());
            Console.WriteLine(company1.Win());
            Console.WriteLine("\n------------------------------\n");
            Console.WriteLine(company2.Info());
            Console.WriteLine(company2.Win());
            Console.ReadKey();
        }
    }
}
