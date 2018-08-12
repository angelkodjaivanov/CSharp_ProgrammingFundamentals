using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for ( int number = 2; number <= n; number++)
            {
                bool isTrue = false;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if ( number % i == 0 )
                    {
                        isTrue = true;
                    }
                }
                if ( isTrue == false )
                {
                    Console.Write(number + " ");
                }
            }

        }
    }
}
