using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            FindTrailingZeroes(number);
        }

        static void FindTrailingZeroes(int number)
        {
            int zeroes = 0;

            for (int num = 1; num <= number; num++)
            {
                int save = num;
                while ( save % 5 == 0)
                {
                    zeroes++;
                    save = save / 5;
                }
            }
            Console.WriteLine(zeroes);
        }
        
    }
}
