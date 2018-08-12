using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHallProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double startMoney = money;
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<=n; i++)
            {
                var product = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                int br = int.Parse(Console.ReadLine());
                if (br>1) {
                    Console.WriteLine("Adding {0} {1}s to cart.", br, product);
                }
                else
                {
                    Console.WriteLine("Adding {0} {1} to cart.", br, product);
                }
                money = money - price * br;

            }

            if ( money >= 0)
            {
                Console.WriteLine("Subtotal: ${0:F2}", startMoney - money);
                Console.WriteLine("Money left: ${0:F2}", money);
            }
            else
            {
                Console.WriteLine("Subtotal: ${0:F2}", startMoney - money);
                Console.WriteLine("Not enough. We need ${0:F2} more.", Math.Abs(money));
            }

        }
    }
}
