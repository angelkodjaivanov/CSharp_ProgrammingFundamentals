using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
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
            Dictionary<string, Book> bookPrice = new Dictionary<string, Book>();

            for (int i = 0; i < n; i++)
            {
                List<string> bookProp = Console.ReadLine().Split(' ').ToList();
                Book book = new Book { Title = bookProp[0], Author = bookProp[1], Publisher = bookProp[2],
                    ReleaseDate = DateTime.ParseExact(bookProp[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN_number = bookProp[4], price = decimal.Parse(bookProp[5])
                };

                if (bookPrice.ContainsKey(bookProp[1]))
                {
                    bookPrice[bookProp[1]].price += book.price;
                }
                else
                {
                    bookPrice[bookProp[1]] = book;
                }

            }

            bookPrice = bookPrice.OrderByDescending(p => p.Value.price).ToDictionary(p => p.Key, p => p.Value);

            foreach (var key in bookPrice.Keys)
            {
                Console.WriteLine($"{key} -> {bookPrice[key].price:F2}");
            }

        }
    }
}
