using System;
using TicketPrice;

namespace LipunHinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olet ostamassa lippua. Vastaa seuraaviin kysymyksiin painamalla K (=kyllä) tai E (=ei)");
            Console.WriteLine("\n\n");
            Ticket ticket1 = new Ticket();
            ticket1.AskData();
            Console.WriteLine("\n\n");
            Console.WriteLine(ticket1.PriceCalculator());
            Console.ReadKey();
        }
    }
}

