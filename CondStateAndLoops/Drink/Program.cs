using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            if ( br<=50 )
            {
                if (package == "Normal")
                {
                    double price = 3000 - 5 * 3000 / 100;
                    double pricePerPerson = price / br;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
                else if (package == "Gold")
                {
                    double price = 3250 - 10 * 3250 / 100;
                    double pricePerPerson = price / br;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
                else if (package == "Platinum")
                {
                    double price = 3500 - 15 * 3500 / 100;
                    double pricePerPerson = price / br;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
            }
            else if ( br<=100 && br > 50)
            {
                if (package == "Normal")
                {
                    double price = 5500 - 5 * 5500 / 100;
                    double pricePerPerson = price / br;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
                else if (package == "Gold")
                {
                    double price = 5750 - 10 * 5750 / 100;
                    double pricePerPerson = price / br;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
                else if (package == "Platinum")
                {
                    double price = 6000 - 15 * 6000 / 100;
                    double pricePerPerson = price / br;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
            }
            else if (br<=120 && br > 100)
            {
                if (package == "Normal")
                {
                    double price = 8000 - 5 * 8000 / 100;
                    double pricePerPerson = price / br;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
                else if (package == "Gold")
                {
                    double price = 8250 - 10 * 8250 / 100;
                    double pricePerPerson = price / br;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
                else if (package == "Platinum")
                {
                    double price = 8500 - 15 * 8500 / 100;
                    double pricePerPerson = price / br;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

        }
    }
}
