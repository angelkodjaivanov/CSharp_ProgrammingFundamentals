using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            int[] numbers = new int[nums.Length];
            int[] result = new int[numbers.Length / 2];

            for (int i = 0; i < nums.Length; i++)
            {
                numbers[i] = int.Parse(nums[i]);
                if ( i < numbers.Length / 2)
                {
                    result[i] = 0;
                }
            }


            for (int i = 0; i < numbers.Length; i++)
            {
                if ( i >= numbers.Length / 4 && i < numbers.Length - numbers.Length / 4)
                {
                    result[i - numbers.Length / 4] += numbers[i];
                }
                else
                {
                    if ( i < numbers.Length / 4)
                    {
                        result[i] += numbers[numbers.Length / 4 - i - 1];
                    }
                    else
                    {
                        result[i - numbers.Length / 2] += numbers[numbers.Length - (i - (numbers.Length - numbers.Length / 4)) - 1];
                    }
                }

            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("{0} ", result[i]);
            }

        }
    }
}
