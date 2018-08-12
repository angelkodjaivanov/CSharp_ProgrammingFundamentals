using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _06.Book_Library_Modification
{
    class Program
    {
            class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN_number { get; set; }
            public decimal price { get; set; }
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                List<string> bookProp = Console.ReadLine().Split(' ').ToList();
                Book book = new Book
                {
                    Title = bookProp[0],
                    Author = bookProp[1],
                    Publisher = bookProp[2],
                    ReleaseDate = DateTime.ParseExact(bookProp[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN_number = bookProp[4],
                    price = decimal.Parse(bookProp[5])
                };
                books.Add(book);

            }

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            books = books.OrderBy(p => p.ReleaseDate).ThenBy(p => p.Title).ToList();

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ReleaseDate > date)
                {
                    Console.WriteLine("{0} -> {1:dd.MM.yyyy}", books[i].Title, books[i].ReleaseDate);
                }
            }

        }
    }
}
