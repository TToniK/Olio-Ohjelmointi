using System;

namespace TicketPrice
{
    class Ticket
    {
        public double price;
        public string student;
        public string mtk;
        public string varus;
        public string age;
        string message;
        public int number;

        public Ticket()
        {
            this.price = 16.00;
            this.student = "";
            this.mtk = "";
            this.varus = "";
            this.age = "";
            this.number = 0;
            

        }

        public void AskData()
        {
            Console.WriteLine("Oletko opiskelija: ");
            student = Console.ReadLine();
            Console.WriteLine("Oletko MTK:n jäsen: ");
            mtk = Console.ReadLine();
            Console.WriteLine("Oletko varusmies: ");
            varus = Console.ReadLine();
            Console.WriteLine("Anna ikäsi numeroina: ");
            age = Console.ReadLine();
            while (!int.TryParse(age, out number))
            {
                Console.WriteLine($"Ikäsi ei voi olla '{age}', anna ikäsi numeroina");
                Console.WriteLine("Anna ikäsi numeroina: ");
                age = Console.ReadLine();
            }
        }

        public string PriceCalculator()
        {
            if (student.ToLower() == "k" && mtk.ToLower() == "k")
            {
                message = $"Alennuksesi on 65%, lipun hinta: {this.price = (100 - 65) * this.price / 100} euroa";
            }
            else if (student.ToLower() == "k" && mtk.ToLower() == "e")
            {
                message = $"Alennuksesi on 50%, lipun hinta: {this.price = (100 - 50) * this.price / 100} euroa";
            }
            else if (student.ToLower() == "e" && mtk.ToLower() == "k")
            {
                message = $"Alennuksesi on 15%, lipun hinta: {this.price = (100 - 15) * this.price / 100} euroa";
            }
            else if (varus.ToLower() == "k")
            {
                message = $"Alennuksesi on 50%, lipun hinta: {this.price = (100 - 50) * this.price / 100} euroa";
            }
            else if (number < 7)
            {
                message = "Ilmainen lippu!";
            }
            else if (number >= 65)
            {
                message = $"Alennuksesi on 50%, lipun hinta: {this.price = (100 - 50) * this.price / 100}";
            }
            else if (number >=7 && number <= 15)
            {
                message = $"Alennuksesi on 50%, lipun hinta: {this.price = (100 - 50) * this.price / 100}";
            }
            else
            {
                message = $"Ei alennusta, lipun hinta: {this.price} euroa";
            }
            return message;
        }     
    }
}
