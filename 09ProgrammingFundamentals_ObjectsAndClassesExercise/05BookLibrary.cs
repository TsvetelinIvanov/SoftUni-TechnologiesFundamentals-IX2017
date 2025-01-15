using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05BookLibrary
{
    class Book
    {
        public string Title { get; set; }
        
        public string Author { get; set; }
        
        public string Publisher { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        public string ISBN { get; set; }
        
        public decimal Price { get; set; }
    }
    
    class Library
    {
        public string Name { get; set; }
        
        public List<Book> Books { get; set; }
    }    

    class Program
    {
        static void Main(string[] args)
        {
            int booksCount = int.Parse(Console.ReadLine());
            Library library = new Library();
            library.Books = new List<Book>();           
            for (int i = 0; i < booksCount; i++)
            {
                string[] bookIinfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Book book = ReadBook(bookIinfo);               
                library.Books.Add(book);
            }

            foreach (
                        var authorWithPricesSum in library.Books.GroupBy(b => b.Author)
                        .Select(g => new
                                { 
                                    Author = g.Key,
                                    PricesSum = g.Sum(b => b.Price)
                                })
                        .OrderByDescending(aps => aps.PricesSum)
                        .ThenBy(aps => aps.Author)
                    )
            {
                Console.WriteLine("{0} -> {1:f2}", authorWithPricesSum.Author, authorWithPricesSum.PricesSum);
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
