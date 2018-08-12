using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaportStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double startMoney = balance;
            bool end = false;

            while (true)
            {
                var game = Console.ReadLine();

                switch (game)
                {
                    case "OutFall 4":
                        if (balance - 39.99 >= 0)
                        {
                            balance = balance - 39.99;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (balance - 15.99 >= 0)
                        {
                            balance = balance - 15.99;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (balance - 19.99 >= 0)
                        {
                            balance = balance - 19.99;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (balance - 59.99 >= 0)
                        {
                            balance = balance - 59.99;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (balance - 29.99 >= 0)
                        {
                            balance = balance - 29.99;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance - 39.99 >= 0)
                        {
                            balance = balance - 39.99;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Game Time": end = true; break;
                    default: Console.WriteLine("Not Found"); break;
                }
                if ( end == true )
                {
                    break;
                }
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
            if (balance > 0) {
                Console.WriteLine("Total spent: ${0:F2}. Remaining: ${1:F2}", startMoney - balance, balance);
            }


        }
    }
}
