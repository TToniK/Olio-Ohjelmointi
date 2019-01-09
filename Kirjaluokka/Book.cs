using System;
using System.Collections.Generic;
using System.Text;

namespace Kirjaluokka
{
    class Book
    {

        public string title;
        public string author;
        public string id;
        public double price;

       
        public Book(string title, string author, string id, int price)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.price = price;
            
        }
        public void Printinfo()
        {
            Console.WriteLine($"Kirjan tiedot:\nNimi: {this.title}" + 
                $"\nKirjailija: {this.author}\n" + 
                $"Id: {this.id}\n" + 
                $"Hinta: {this.price.ToString()} euroa\n");
        }
        public void CompareBook(Book book)
        {
            if (this.price > book.price)
                Console.WriteLine($"Kirja {this.title} on kalliimpi kuin {book.title}");
            else
                Console.WriteLine($"Kirja {book.title} on kalliimpi kuin {this.title}");
        }
    }
}
  
