using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string[] names = input1.Split(' ');
            string[] quantities = input2.Split(' ');
            string[] prices = input3.Split(' ');

            string input = Console.ReadLine();
            while ( input != "done" )
            {

                for (int i = 0; i < names.Length ; i++)
                {
                    if (input == names[i])
                    {
                        Console.WriteLine("{0} costs: {1}; Available quantity: {2}", 
                            names[i], prices[i], quantities[i]);
                    }
                }

                input = Console.ReadLine();
            }

        }
    }
}
