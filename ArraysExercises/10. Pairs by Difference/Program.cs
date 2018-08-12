using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int diff = int.Parse(Console.ReadLine());
            string[] nums = input.Split(' ');
            int[] numbers = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                numbers[i] = int.Parse(nums[i]);
            }

            int br = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for ( int j = i + 1; j < numbers.Length; j++) {
                    if (Math.Abs(numbers[i] - numbers[j]) == diff)
                    {
                        br++;
                    }
                }
            }
            Console.WriteLine(br);
        }
    }
}
