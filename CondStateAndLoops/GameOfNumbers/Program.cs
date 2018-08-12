using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int br = 0, saveNumber1 = 0, saveNumber2 = 0;
            bool isThereANumber = false;

            for (int i = n; i <= m ; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if ( i + j == magicNumber)
                    {
                        isThereANumber = true;
                        saveNumber1 = i;
                        saveNumber2 = j;
                    }
                    br++;
                }
            }

            if (isThereANumber == true )
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", saveNumber1, saveNumber2, magicNumber);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", br, magicNumber);
            }

        }
    }
}
