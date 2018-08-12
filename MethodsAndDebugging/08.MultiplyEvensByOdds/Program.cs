using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetResult(number));
        }

        static int GetResult(int number)
        {
            int result = GetEvenSum(number) * GetOddSum(number);
            return result;
        }

        static int GetOddSum(int num)
        {
            int number = num;
            int result = 0;
            while (number > 0 )
            {
                int lastDigg = number % 10;
                if (lastDigg % 2 == 1)
                {
                    result += lastDigg;
                }
                number = number / 10;
            }
            
            return result;
        }

        static int GetEvenSum(int num)
        {
            int number = num;
            int result = 0;
            while (number > 0)
            {
                int lastDigg = number % 10;
                if (lastDigg % 2 == 0)
                {
                    result += lastDigg;
                }
                number = number / 10;
            }
            return result;
        }
    }
}
