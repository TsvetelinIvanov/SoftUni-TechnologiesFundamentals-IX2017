using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06BookLibraryModification
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

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (Book book in library.Books.OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                if (date < book.ReleaseDate)
                {
                    Console.WriteLine("{0} -> {1:dd.MM.yyyy}", book.Title, book.ReleaseDate);
                }
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
