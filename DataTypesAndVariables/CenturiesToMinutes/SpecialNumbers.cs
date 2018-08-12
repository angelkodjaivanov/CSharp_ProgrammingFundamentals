using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToMinutes
{
    class SpecialNumbers
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 1; number <= n; number++)
            { 
                int sum = 0;
                int saveNum = number;
                while (number!=0)
                {
                    int digg = number % 10;
                    sum = sum + digg;
                    number = number / 10;
                }
                if ( sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> True", saveNum);
                }
                else
                {
                    Console.WriteLine("{0} -> False", saveNum);
                }
                number = saveNum;
            }

        }
    }
}
