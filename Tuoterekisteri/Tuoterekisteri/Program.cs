using System;
using System.Globalization;

namespace Tuoterekisteri
{
    class Program
    {

        public static string Choice()
        {
            Console.WriteLine("Tuoterekisteriohjelma\nValitse toiminto: ");
            Console.WriteLine("[A] = Tulosta kaikki tuotteet");
            Console.WriteLine("[B] = Tulosta tietyt tuotteet ryhmän mukaan");
            Console.WriteLine("[C] = Loppuneet tuotteet");
            Console.WriteLine("[D] = Sulje TUOTEREKISTERI");
            string action = Console.ReadLine();
            return action;
        }

        static void Main(string[] args)
        {
            

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = new CultureInfo("fi-FI");

            Item item = new Item();
            Filemanager fileManager = new Filemanager();

            
            string Input = null;
            string message = "";

            do
            {
                Input = Choice();
                switch (Input.ToUpper())
                {
                    case "A":
                        Console.WriteLine(fileManager.ListItems());
                        break;

                    case "B":
                        Console.WriteLine("Valitse tuoteryhmä: ");
                        Console.WriteLine("1 = Lajittelu ja säilytys");
                        Console.WriteLine("2 = Paperit ja lehtiöt");
                        Console.WriteLine("3 = Kynät");
                        Console.WriteLine("4 = Kortit ja kirjekuoret");
                        string group = Console.ReadLine();
                        Console.Write(fileManager.PrintByGroup(group));
                        break;

                    case "C":
                        fileManager.PrintRanOut();
                        break;

                    case "D":
                        message = "Suljetaan ohjelma";
                        break;

                    default:
                        message = "Valitse toiminnoista A,B,C tai paina 'D' poistuaksesi";
                        break;
                }
                Console.WriteLine(message);
                Console.ReadKey();
                Console.Clear();
            }

            while (Input.ToUpper() != "D");
        }
    }
}
