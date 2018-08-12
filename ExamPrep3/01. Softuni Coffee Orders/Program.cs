using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                decimal count = decimal.Parse(Console.ReadLine());

                decimal price = (System.DateTime.DaysInMonth(date.Year, date.Month) * count) * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${price:F2}");

                totalPrice += price;

            }

            Console.WriteLine($"Total: ${totalPrice:F2}");

        }
    }
}
