using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        static bool IsPrime(long number)
        {
            bool isPrime = true;

            if ( number >= 2) {
                for (long i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }
            else
            {
                isPrime = false;
            }

            return isPrime;
        }
    }
}
