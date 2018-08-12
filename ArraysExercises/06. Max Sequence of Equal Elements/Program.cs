using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            int[] numbers = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                numbers[i] = int.Parse(nums[i]);
            }

            int start = 0, len = 1, bestLen = 1, bestStart = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
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

            for (int i = bestStart; i > bestStart - bestLen; i--)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}
