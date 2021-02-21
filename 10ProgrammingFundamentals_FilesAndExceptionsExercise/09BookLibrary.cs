using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace _09BookLibrary
{
    class Library
    {
        string Name { get; set; }
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
        static StreamReader file = new StreamReader("input.txt");
        static void Main(string[] args)
        {            
            int numOfBooks = int.Parse(file.ReadLine());
            Library library = new Library();
            List<Book> books = new List<Book>();
            for (int i = 0; i < numOfBooks; i++)
            {
                Book book = ReadBook();
                books.Add(book);
            }

            library.Books = books;
            PrintBooks(library);

            file.Close();
        }

        private static Book ReadBook()
        {

            Book book = new Book();
            string[] bookInfo = file.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();
            book.Title = bookInfo[0];
            book.Author = bookInfo[1];
            book.Publisher = bookInfo[2];
            book.ReleaseDate = DateTime.ParseExact(bookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.ISBN = bookInfo[4];
            book.Price = decimal.Parse(bookInfo[5], CultureInfo.InstalledUICulture);

            return book;
        }

        private static void PrintBooks(Library library)
        {
            var ordered = library.Books.GroupBy(b => b.Author)
                .Select(g => new { Author = g.Key, Prices = g.Sum(s => s.Price) })
                .OrderByDescending(x => x.Prices)
                .ThenBy(x => x.Author)
                .ToList();
            string text = string.Empty;
            foreach (var author in ordered)
            {
                text += ($"{author.Author} -> {author.Prices:f2}\r\n");
            }

            File.WriteAllText("output.txt", text);
        }        
    }    
}
