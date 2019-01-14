using System;
using System.Collections.Generic;
using System.Text;

namespace Firmaluokka
{
    class Company
    {
        string message = null;

        public Company()
        {
            this.Title = "Ei nimeä";
            this.Address = "Ei osoitetta";
            this.Phone = "Ei numeroa";
            this.Income = 0;
            this.Expense = 0;
        }

       public Company(Company previousCompany)
       {
            Title = previousCompany.Title;
            Address = previousCompany.Address;
            Phone = previousCompany.Phone;
            Income = previousCompany.Income;
            Expense = previousCompany.Expense;
       }


        public Company(string title, string address, string phone, int income, int expense)
        {
            Title = title;
            Address = address;
            Phone = phone;
            Income = income;
            Expense = expense;
        }
            public string Title { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public int Income { get; set; }
            public int Expense { get; set; }

        public string Info()
        {
            return "Firma: " + Title + "\nOsoite: " + Address + "\nPuhelinnumero: " + Phone.ToString() + "\nTulot: "
                + Income.ToString() + "\nMenot: " + Expense.ToString();
        }

        public string Win()
        {
            double winloss = (this.Income - this.Expense) / this.Expense * 100;
            if (winloss <= 100)
            {
                message = "Tulosprosentti: " + winloss + "%,\nyrityksellä menee kehnosti";
            }
            else if (winloss < 100 && winloss <= 200)
            {
                message = "Tulosprosentti: " + winloss + "%,\nyrityksellä menee tyydyttävästi";
            }
            if(winloss >200)
            {
                message = "Tulosprosentti: " + winloss + "%,\nyrityksellä menee hyvin";
            }
            return message;
         
           
        }
    }       
}
