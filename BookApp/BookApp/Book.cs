using System;
using System.Collections.Generic;
using System.Text;

namespace BookApp
{
    class Book
    {

        public string title;
        public string author;
        public string id;
        public string publisher;
        public static string theme;
        public double price;
      

        public Book(string title, string author, string id, int price, string publisher, string givenTheme)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.price = price;
            this.publisher = publisher;
            theme = givenTheme;
        }
        public void Printinfo()
        {
            Console.WriteLine($"Kirjan tiedot:\nNimi: {this.title}" +
                $"\nKirjailija: {this.author}\n" +
                $"Id: {this.id}\n" +
                $"Hinta: {this.price.ToString()} euroa\n" + $"Kustantaja: {this.publisher}\n" + 
                $"Teema: {theme}");
        }
        public void CompareBook(Book book)
        {
            if (this.price > book.price)
                Console.WriteLine($"Kirja {this.title} on kalliimpi kuin {book.title}");
            else if (this.price == book.price)
                Console.WriteLine($"Kirja {book.title} on saman hintainen kuin {this.title}");
            else
                Console.WriteLine($"Kirja {book.title} on kalliimpi kuin {this.title}");
        }
        public Book(Book previousBook)
        {
            title = previousBook.title;
            author = previousBook.author;
            id = previousBook.id;
            publisher = previousBook.publisher;
            price = previousBook.price;
        }
        public string Search(string search)
        {
            return $"Hakuasi vastaava tulos löytyi: {title},\n{author},\n{id},\n{price} euroa,\n{publisher},\n{theme}";
        }
        public static void SwitchTheme()
        {
            theme = "komedia";
        }
        public override string ToString()
        {
            return $"Kirjan nimi: {title}\nKirjailija: {author}\nKustantaja: {publisher}\nHinta: {price}euroa\nTeema: {theme}";
        }
        
    }

}
