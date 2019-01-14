using System;
using System.Collections.Generic;
using System.Text;

namespace Autoluokka
{
    class Car
    {
        public string brand;
        public int speed;

        public Car()
        {
            this.brand = "";
            this.speed = 0;
        }

        public void AskData()
        {
            
            Console.WriteLine("Merkki: ");
            this.brand = Console.ReadLine();
            Console.WriteLine("Huippunopeus (km/h): ");
            this.speed = int.Parse(Console.ReadLine());
        }    
        
        public void Printinfo()
        {
            Console.WriteLine($"Auton tiedot:\nMerkki: {this.brand}" +
                $"\nHuippunopeus: {this.speed}km/h\n");

        }

        public void Accelerate()
        {
            Console.WriteLine("Laita 0, jos et halua kiihdyttää, muulloin kiihdytä: ");
            this.speed += int.Parse(Console.ReadLine());
        }
        public void Brake()
        {
            Console.WriteLine("Haluatko jarruttaa? 1 = kyllä tai 2 = ei");
            if (int.Parse(Console.ReadLine()) == 1)
            {
                double braking = (this.speed * 90) / 100;
                Console.WriteLine($"Jarrutus suoritettu, uusi nopeus: {braking}km/h");
            }
            else if (int.Parse(Console.ReadLine()) == 2)
            {
                Console.WriteLine("Jarrutusta ei suoritettu");
            }
            else
            { 
                Console.WriteLine("Väärä syöte!");
            }
        }
    }
}
