using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CalculateFactorial(number);
        }

        private static void CalculateFactorial(int number)
        {
            BigInteger result = 1;
            for (int num = 1; num <= number; num++ )
            {
                result = result * num;
            }
            Console.WriteLine(result);
        }
    }
}
