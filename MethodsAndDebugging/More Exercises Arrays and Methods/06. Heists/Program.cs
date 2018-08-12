using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            string prices = Console.ReadLine();
            string[] elPr = prices.Split(' ');
            int[] pricesGoldAndJewel = new int[elPr.Length];

            for (int i = 0; i < elPr.Length; i++)
            {
                pricesGoldAndJewel[i] = int.Parse(elPr[i]);
            }

            string input = Console.ReadLine();

            int totalEarning = 0, totalExpenses = 0;
            while (input != "Jail Time")
            {
                string[] text = input.Split(' ');
                string goldAndJewel = text[0];
                int expens = int.Parse(text[1]), goldBr = 0, jewelBr = 0;

                for (int i = 0; i < goldAndJewel.Length; i++ )
                {
                    if (goldAndJewel[i] == '%' )
                    {
                        jewelBr++;
                    }
                    else if (goldAndJewel[i] == '$')
                    {
                        goldBr++;
                    }
                }

                totalEarning += goldBr * pricesGoldAndJewel[1] + jewelBr * pricesGoldAndJewel[0];
                totalExpenses += expens;

                input = Console.ReadLine();

            }

            if (totalEarning >= totalExpenses)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.", totalEarning - totalExpenses);
            }
            else
            {
                Console.WriteLine("Have to find another job. Lost: {0}.", Math.Abs(totalEarning - totalExpenses));
            }

        }

    }
}
