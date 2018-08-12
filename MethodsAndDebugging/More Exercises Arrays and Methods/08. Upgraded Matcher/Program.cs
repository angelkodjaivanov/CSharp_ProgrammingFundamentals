using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string prNames = Console.ReadLine();
            string prQuantities = Console.ReadLine();
            string prPrices = Console.ReadLine();
            string[] names = prNames.Split(' ');
            string[] quantities = prQuantities.Split(' ');
            string[] prices = prPrices.Split(' ');

            long[] productQuantities = new long[names.Length];
            decimal[] productPrices = new decimal[prices.Length];

            for (int i = 0; i < productQuantities.Length; i++)
            {
                try
                { 
                    productQuantities[i] = long.Parse(quantities[i]);
                    if (productQuantities[i] < 0)
                    {
                        productQuantities[i] = 0;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    productQuantities[i] = 0;
                }
                productPrices[i] = decimal.Parse(prices[i]);
            }

            string input = Console.ReadLine();
            while (input != "done")
            {
                string[] currentProduct = input.Split(' ');
                string name = currentProduct[0];
                long quant = long.Parse(currentProduct[1]);

                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        if (productQuantities[i] >= quant)
                        {
                            productQuantities[i] -= quant;
                            Console.WriteLine("{0} x {1} costs {2}", name, quant, productPrices[i] * quant);
                        }
                        else
                        {
                            Console.WriteLine("We do not have enough {0}", name);
                        }
                    }
                }

                input = Console.ReadLine();
            }

        }
    }
}
