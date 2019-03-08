using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Tuoterekisteri
{
    class Filemanager
    {
        private string FilePath;


        public Filemanager()
        {
            this.FilePath = @"C:\Users\karit\source\repos\Olio-Ohjelmointi\Tuoterekisteri\ItemsJson";
        }

       
        public string ListItems()
        {
            string listContent = String.Empty;
            try
            {
                listContent = ReadFile();
                return listContent;
            }
            catch (Exception e) 
            {
                return e.Message;
            }
        }

        public string ReadFile()
        {
            if (File.Exists(FilePath)) 
            {
                List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(this.FilePath));

                foreach (Item item in itemList) 
                {
                    Console.WriteLine();
                    Console.WriteLine($"Nimi: {item.Name}\nTuote ID: {item.Id}\nRyhmä: {item.GroupName}");
                }

                Console.WriteLine();
               
                Console.WriteLine("Haluatko hakea tietyn tavaran? Kyllä = [1] tai Ei = [2]");
                string response = Console.ReadLine();
                while(response != "1" || response != "2")
                {
                    Console.WriteLine("Paina 1 tai 2!");
                    Console.WriteLine("Haluatko hakea tietyn tavaran? Kyllä = [1] tai Ei = [2]");
                    response = Console.ReadLine();

                }
                if (response == "1")
                {
                    Console.WriteLine("Syötä tuote ID: ");
                    string inputId = Console.ReadLine();

                    foreach (Item item in itemList)
                    {
                        if (inputId == item.Id)
                        {
                            Console.WriteLine($"Nime: {item.Name}\nTuote ID: {item.Id}\nRyhmä: {item.GroupName}\nHinta: {item.Price}\nMäärä: {item.Amount}\nKommentti: {item.Comment}\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Mitään tuotteita ei haettu.");
                }
            }

            else if (!File.Exists(FilePath))
            {
                throw new Exception("Tiedostoa ei löytynyt.");
            }
            return "";
        }
    }
}
