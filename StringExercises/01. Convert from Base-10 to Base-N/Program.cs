using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger baseN = input[0], number = input[1];
            string result = "";
            while (number != 0)
            {
                result += number % baseN;
                number = number / baseN;
            }
            Console.WriteLine(new String(result.Reverse().ToArray()));
        }
    }
}
