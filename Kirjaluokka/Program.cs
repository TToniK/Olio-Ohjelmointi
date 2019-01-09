using System;

namespace Kirjaluokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma antaa kirjojen tiedot ja vertailee hinnat\n");
            Book myBook = new Book("ABC", "Toni K", "00155", 10);
            myBook.Printinfo();

            Book myBook2 = new Book("CBA", "Kari T", "00255", 25);
            myBook2.Printinfo();
            myBook.CompareBook(myBook2);
            Console.WriteLine("Paina mitä vain lopettaaksesi....");
            Console.ReadKey();

        }
    }
}

