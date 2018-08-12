using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, double> price = new Dictionary<string, double>();
            Dictionary<string, double> quantity = new Dictionary<string, double>();

            while (input != "stocked" )
            {

                List<string> prodcutParam = input.Split(' ').ToList();
                bool isRepeated = false;

                price[prodcutParam[0]] = double.Parse(prodcutParam[1]);

                foreach (var pr in quantity.Keys)
                {
                    if ( pr == prodcutParam[0])
                    {
                        isRepeated = true;
                    }
                }

                if (isRepeated)
                {
                    quantity[prodcutParam[0]] += double.Parse(prodcutParam[2]);
                }
                else
                {
                    quantity[prodcutParam[0]] = double.Parse(prodcutParam[2]);
                }

                input = Console.ReadLine();
            }

            double totalPrice = 0;
            foreach (string product in price.Keys)
            {
                Console.WriteLine("{0}: ${1:F2} * {2} = ${3:F2}", 
                    product, price[product], quantity[product], price[product] * quantity[product]);
                totalPrice += price[product] * quantity[product];
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Grand Total: ${0:F2}", totalPrice);

        }
    }
}
