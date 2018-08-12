using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            double[] numbers = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                numbers[i] = double.Parse(nums[i]);
            }

            int start = 0, len = 1, bestLen = 1, bestStart = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] - 1 == numbers[i - 1])
                {
                    len++;
                    start = i;
                    if (bestLen < len)
                    {
                        bestStart = start;
                        bestLen = len;
                    }
                }
                else
                {
                    len = 1;
                }
            }

            for (int i = bestStart - bestLen + 1; i <= bestStart; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}
