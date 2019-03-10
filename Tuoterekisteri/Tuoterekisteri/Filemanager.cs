using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Tuoterekisteri
{
    class Filemanager
    {
        private readonly string FilePath;
        private readonly string FilePathTest;


        public Filemanager()
        {
            this.FilePath = @"C:\Users\karit\source\repos\Olio-Ohjelmointi\Tuoterekisteri\ItemsJson\items.json";
            this.FilePathTest = @"C:\Users\karit\source\repos\Olio-Ohjelmointi\Tuoterekisteri\ItemsJson\itemstesting.json";
        }



        public string ListItems()
        {
            string content = String.Empty;
            try
            {
                content = ReadFile();
                return content;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private string ReadFile()
        {
            if (File.Exists(FilePath))
            {
                List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(this.FilePath));

                foreach (Item item in itemList)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Nimi: {item.Name}\nTuotenumero: {item.Id}\nTuoteryhmä: {item.GroupName}");
                }

                Console.WriteLine();
                Console.WriteLine("Haluatko tulostaa tiedot tietystä tuotteesta? Paina [K] = 'kyllä' tai [E] = 'ei'");
                string response = Console.ReadLine().ToUpper();
                if (response == "K")
                {
                    Console.WriteLine();
                    Console.WriteLine("Tulostetaan tuotenumerot: ");

                    foreach (Item item in itemList)
                    {
                        Console.WriteLine("----------------------------------------------------------------------------------------");
                        Console.WriteLine($"Nimi: {item.Name}, Tuotenumero: {item.Id}");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Syötä tuotenumero: ");
                    string inputId = Console.ReadLine();
                    bool found = false;

                    foreach (Item item in itemList)
                    {
                        if (inputId == item.Id)
                        {
                            found = true;
                            Console.WriteLine($"Nimi: {item.Name}\nTuotenumero: {item.Id}\nRyhmä: {item.GroupName}\nHinta: {item.Price:c}\nMäärä: {item.Amount}\nKommentti: {item.Comment}\n");
                        }
                    }
                    if (found != true)
                    {
                        Console.WriteLine("Väärä syöte");
                    }
                }
                else
                {
                    Console.WriteLine("Yhtään tuotetta ei haettu");
                }
            }

            else if (!File.Exists(FilePathTest))
            {
                throw new Exception("Tiedostoa ei löytynyt.");
            }
            return "";
        }

        public string PrintByGroup(string group)
        {
           
            List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(this.FilePath));
            
                foreach (Item item in itemList)
                {
                    if (group == "1")
                    {
                        if (item.GroupName == "Lajittelu ja säilytys")
                        {
                            Console.WriteLine($"Nimi: {item.Name}\nTuotenumero: {item.Id}\nRyhmä: {item.GroupName}\nHinta: {item.Price:C}\nMäärä: {item.Amount}\nKommentti: {item.Comment}\n");
                        }
                    }
                    else if (group == "2")
                    {
                        if (item.GroupName == "Paperit ja lehtiöt")
                        {
                            return $"Nimi: {item.Name}\nTuotenumero: {item.Id}\nRyhmä: {item.GroupName}\nHinta: {item.Price:C}\nMäärä: {item.Amount}\nKommentti: {item.Comment}\n";
                        }
                    }
                    else if (group == "3")
                    {
                        if (item.GroupName == "Kynät")
                        {
                            return $"Nimi: {item.Name}\nTuotenumero: {item.Id}\nRyhmä: {item.GroupName}\nHinta: {item.Price:C}\nMäärä: {item.Amount}\nKommentti: {item.Comment}\n";
                        }
                    }
                    else if (group == "4")
                    {
                        if (item.GroupName == "Kortit ja kirjekuoret")
                        {
                            return $"Nimi: {item.Name}\nTuotenumero: {item.Id}\nRyhmä: {item.GroupName}\nHinta: {item.Price:C}\nMäärä: {item.Amount}\nKommentti: {item.Comment}\n";
                        }
                    }
                    else
                    {
                        return "Valitse 1-4";
                    }
                }
           
            return "";
        }

        public void PrintRanOut()
        {
            List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(this.FilePath));

            foreach (Item item in itemList)
            {
                if (item.Amount == 0)
                {
                    Console.WriteLine($"Nimi: {item.Name}\nTuotenumero: {item.Id}\nRyhmä: {item.GroupName}\nHinta: {item.Price:c}\nMäärä: {item.Amount}\nKommentti: {item.Comment}\n");
                }
            }
        }


    }

}

