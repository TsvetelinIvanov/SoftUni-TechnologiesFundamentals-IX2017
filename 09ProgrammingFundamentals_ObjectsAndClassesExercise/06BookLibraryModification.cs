using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06BookLibraryModification
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
                string[] bookInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Book book = ReadBook(bookInfo);
                library.Books.Add(book);
            }

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            foreach (Book book in library.Books.OrderBy(b => b.ReleaseDate).ThenBy(b => b.Title))
            {
                if (date < book.ReleaseDate)
                {
                    Console.WriteLine("{0} -> {1:dd.MM.yyyy}", book.Title, book.ReleaseDate);
                }
            }           
        }

        private static Book ReadBook(string[] bookInfo)
        {
            Book book = new Book();
            book.Title = bookInfo[0];
            book.Author = bookInfo[1];
            book.Publisher = bookInfo[2];
            book.ReleaseDate = DateTime.ParseExact(bookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.ISBN = bookInfo[4];
            book.Price = decimal.Parse(bookInfo[5]);

            return book;
        }
    }
}
