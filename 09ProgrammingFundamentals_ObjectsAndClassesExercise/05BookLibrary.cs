using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05BookLibrary
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library library = new Library();
            library.Books = new List<Book>();
           
            for (int i = 0; i < n; i++)
            {
                string[] bookIinfo = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Book book = ReadBook(bookIinfo);               
                library.Books.Add(book);
            }

            foreach (var author in library.Books.GroupBy(x => x.Author)
                .Select(a => new { Author = a.Key, Prices = a.Sum(s => s.Price)})
                .OrderByDescending(a => a.Prices)
                .ThenBy(a => a.Author))
            {
                Console.WriteLine("{0} -> {1:f2}", author.Author, author.Prices);
            }
        }

        private static Book ReadBook(string[] bookIinfo)
        {
            Book book = new Book();
            book.Title = bookIinfo[0];
            book.Author = bookIinfo[1];
            book.Publisher = bookIinfo[2];
            book.ReleaseDate = DateTime.ParseExact(bookIinfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.ISBN = bookIinfo[4];
            book.Price = decimal.Parse(bookIinfo[5]);

            return book;
        }
    }    
}
