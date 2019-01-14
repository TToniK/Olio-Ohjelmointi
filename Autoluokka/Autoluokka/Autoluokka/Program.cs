using System;

namespace Autoluokka
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.AskData();
            Car myCar2 = new Car();
            Console.WriteLine("\n ");
            Console.WriteLine("Toisen auton tiedot\n ");
            myCar2.AskData();
            Console.WriteLine("\n ");
            myCar.Accelerate();
            myCar.Brake();
            myCar.Printinfo();
            myCar2.Printinfo();
            

            Console.ReadKey();
        }
    }
}
