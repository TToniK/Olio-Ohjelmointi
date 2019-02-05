using System;


namespace BookApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tämä on kehittyneempi versio kirjaohjelmasta");
            Book book1 = new Book("Aapinen", "Mikael Agricola", "001", 10, "Kustantaja 1", "Draama");
            Book book2 = new Book(book1)
            {
                title = "Satu",
                author = "Satuilija",
                id = "002",
                publisher = "Sanoma Oy",
                price = 20
            };
            Book book3 = new Book(book1)
            {
                title = "Tarinat",
                author = "Tarinoitsija",
                id = "003",
                publisher = "Kustantaja 3",
                price = 5
            };
            Book book4 = new Book(book1)
            {
                title = "Life is strange",
                author = "McDonalds",
                id = "004",
                publisher = "Kustantaja 4",
                price = 45
            };
            Console.WriteLine("Haluatko nähdä kaikkien kirjojen tiedot vai hakea kirjaa? Valitse 1 [=Näytä] tai 2 [=Hae] tai 0 [=Jatka]");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                book1.Printinfo();
                Console.WriteLine("----------------------\n");
                book2.Printinfo();
                Console.WriteLine("----------------------\n");
                book3.Printinfo();
                Console.WriteLine("----------------------\n");
                book4.Printinfo();
                Console.WriteLine("----------------------\n");
                Console.WriteLine("Haluatko asettaa kaikkien kirjojen teemaksi 'komedia'?\n" +
                    "1[=kyllä] tai 2[=ei]");
                int choice1 = int.Parse(Console.ReadLine());
                if (choice1 == 1)
                {
                    Book.SwitchTheme();
                    Console.WriteLine(book1.ToString());
                    Console.WriteLine("----------------------\n");
                    Console.WriteLine(book2.ToString());
                    Console.WriteLine("----------------------\n");
                    Console.WriteLine(book3.ToString());
                    Console.WriteLine("----------------------\n");
                    Console.WriteLine(book4.ToString());
                    Console.WriteLine("----------------------\n");
                   
                    Console.WriteLine("Jos kirja on yli 30 euroa, saa kirjasta silloin 10% alennuksen");
                    Console.WriteLine($"{book1.title}: {book1.price} euroa");
                    Console.WriteLine($"{book2.title}: {book2.price} euroa");
                    Console.WriteLine($"{book3.title}: {book3.price} euroa");
                    Console.WriteLine($"{book4.title}: {book4.price} euroa");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Jatketaan ilman muutoksia");
                    Console.WriteLine("Jos kirja on yli 30 euroa, saa kirjasta silloin 10% alennuksen");
                    Console.WriteLine($"{book1.title}: {book1.price} euroa");
                    Console.WriteLine($"{book2.title}: {book2.price} euroa");
                    Console.WriteLine($"{book3.title}: {book3.price} euroa");
                    Console.WriteLine($"{book4.title}: {book4.price} euroa");
                    Console.ReadKey();
                }

            }
            else if (choice == 2)
            {

                Console.WriteLine("Mitä kirjaa etsit: ");
                string look = Console.ReadLine();
                if (look == book1.title)
                {
                    Console.WriteLine(book1.Search(book1.title));
                }
                else if (look == book2.title)
                {
                    Console.WriteLine(book2.Search(book2.title));
                }
                else if (look == book3.title)
                {
                    Console.WriteLine(book3.Search(book3.title));
                }
                else if (look == book4.title)
                {
                    Console.WriteLine(book4.Search(book4.title));
                }
                else
                {
                    Console.WriteLine("Ei tuloksia");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Haluatko asettaa kaikkien kirjojen teemaksi 'komedia'?\n" +
                    "1[=kyllä] tai 2[=ei]");
                int choice1 = int.Parse(Console.ReadLine());
                if (choice1 == 1)
                {
                    Book.SwitchTheme();
                    Console.WriteLine(book1.ToString());
                    Console.WriteLine("----------------------\n");
                    Console.WriteLine(book2.ToString());
                    Console.WriteLine("----------------------\n");
                    Console.WriteLine(book3.ToString());
                    Console.WriteLine("----------------------\n");
                    Console.WriteLine(book4.ToString());
                    Console.WriteLine("----------------------\n");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Jatketaan ilman muutoksia");
                    
                }
                Console.WriteLine("Jos kirja on yli 30 euroa, saa kirjasta silloin 10% alennuksen");
                Console.WriteLine($"{book1.title}: {book1.price} euroa");
                Console.WriteLine($"{book2.title}: {book2.price} euroa");
                Console.WriteLine($"{book3.title}: {book3.price} euroa");
                Console.WriteLine($"{book4.title}: {book4.price} euroa");
                Console.ReadKey();
            }
        }
                
               
               
        
               
    }
}
