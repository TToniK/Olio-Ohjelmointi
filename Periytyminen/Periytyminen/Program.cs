using System;
using System.Globalization;

namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = new CultureInfo("fi-FI");

            

            Car sedan = new Car("Sedan", "Seat", "2001", 9000, 100, "Model 2", 4);
            Truck van = new Truck("Utility vehicle", "Toyota", "2015", 27000, 180, "Proace", 2, 15000, 0.00001);
            Car sport = new Car("Sport", "Ferrari", "2018", 1000000, 300, "812", 2);
            Truck truck = new Truck("Truck", "Mercedes Benz", "2015", 150000, 250, "Model 1", 2, 50000, 0.00002);

            

            Console.WriteLine("Tämä on kulkuväline-ohjelma");
            Console.WriteLine();
            Console.WriteLine(sedan.PrintData());
            Console.WriteLine();
            Console.WriteLine(sport.PrintData());
            Console.WriteLine("------------");

            

            Console.WriteLine(sedan.ToString());
            Console.WriteLine();
            Console.WriteLine(sport.ToString());
            Console.WriteLine("------------");

            

            if (sedan.Equals(sport))
            {
                Console.WriteLine("Autot ovat samat");
            }
            else
            {
                Console.WriteLine("Autot ovat erilaisia");
            }

            

            Console.WriteLine($"Hyötyajoneuvon kulutus: {van.CalculateConsumption()}L/kg.");
            Console.WriteLine();

            
            Car example = van as Car;
            Console.WriteLine(example.ToString());

            Console.ReadKey();
        }
    }
}