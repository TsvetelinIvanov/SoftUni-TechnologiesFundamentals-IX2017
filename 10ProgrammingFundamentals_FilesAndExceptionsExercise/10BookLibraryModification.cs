using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace _10BookLibraryModification
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
        static StreamReader streamReader = new StreamReader("input.txt");
        
        static void Main(string[] args)
        {
            int booksCount = int.Parse(streamReader.ReadLine());
            List<Book> books = new List<Book>();
            for (int i = 0; i < booksCount; i++)
            {
                books.Add(ReadBook(streamReader.ReadLine()));
            }

            Library library = new Library { Name = "Library", Books = books };
            DateTime date = DateTime.ParseExact(streamReader.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Dictionary<string, DateTime> booksByDate = new Dictionary<string, DateTime>();
            foreach (Book book in library.Books)
            {
                if (book.ReleaseDate.CompareTo(date) > 0)
                {
                    booksByDate.Add(book.Title, book.ReleaseDate);
                }
            }

            string text = String.Empty;
            foreach (KeyValuePair<string, DateTime> pair in booksByDate.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                text += $"{pair.Key} -> {pair.Value:dd.MM.yyyy}\r\n";
            }

            File.WriteAllText("output.txt", text);
            
            streamReader.Close();
        }
       
        static Book ReadBook(string input)
        {
            Book book = new Book();
            
            string[] bookInfo = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            book.Title = bookInfo[0];
            book.Author = bookInfo[1];
            book.Publisher = bookInfo[2];
            book.ReleaseDate = DateTime.ParseExact(bookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.ISBN = bookInfo[4];
            book.Price = decimal.Parse(bookInfo[5], CultureInfo.InstalledUICulture);
            
            return book;
        }
    }    
}
