using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            FindPrimes(start, end);
        }

        static void FindPrimes(int start, int end)
        {
            string result = "";
            for (int number = start; number <= end; number++)
            {
                bool isPrime = true;
                if (number >= 2) {
                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if ( number % i == 0)
                        {
                            isPrime = false;
                        }
                    }
                }
                else
                {
                    isPrime = false;
                }
                if (isPrime == true) {
                    result = result + number + ", ";
                }
            }
            result = result.Remove(result.Length-2,2);
            Console.WriteLine(result);
        }
    }
}
