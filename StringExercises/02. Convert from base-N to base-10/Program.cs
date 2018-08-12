using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            ////String[] input = Console.ReadLine().Split(' ').ToArray();
            ////BigInteger sum = 0, number = BigInteger.Parse(input[1]);
            ////double curIndex = 0, baseN = double.Parse(input[0]);

            ////while (number != 0)
            ////{
            ////    BigInteger digg = number % 10;
            ////    sum += digg * (BigInteger)Math.Pow(baseN, curIndex);
            ////    curIndex++;
            ////    number = number / 10;
            ////}
            ////Console.WriteLine(sum);

            string[] line = Console.ReadLine().Trim().Split();
            int baseN = int.Parse(line[0]);
            char[] number = line[1].ToCharArray();
            BigInteger result = new BigInteger(0);
            for (int i = number.Length - 1, n = 0; i >= 0; i--, n++)
            {
                BigInteger num = new BigInteger(char.GetNumericValue(number[n]));
                BigInteger forSum = BigInteger.Multiply(num, BigInteger.Pow(new BigInteger(baseN), i));
                result += forSum;
            }

            Console.WriteLine(result.ToString());
        }
    }
}
