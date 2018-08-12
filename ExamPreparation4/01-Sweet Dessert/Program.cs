using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            long guests = long.Parse(Console.ReadLine());
            decimal priceForBananas = decimal.Parse(Console.ReadLine());
            decimal priceForEggs = decimal.Parse(Console.ReadLine());
            decimal priceForBerries = decimal.Parse(Console.ReadLine());

            decimal totalCost = 0;

            totalCost = (decimal)Math.Ceiling(guests / 6.0) * 2 * priceForBananas + (decimal)Math.Ceiling(guests / 6.0) * 4 * priceForEggs
                + (decimal)Math.Ceiling(guests / 6.0) * (decimal)0.2 * priceForBerries;

            if (totalCost <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalCost:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalCost - cash):F2}lv more.");
            }

        }
    }
}
