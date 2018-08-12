using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
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

            int saveIndex = -1;
            for (int currentNumber = 0; currentNumber < numbers.Length; currentNumber++)
            {
                int sum1 = 0;
                int sum2 = 0;
                for (int i = 0; i < currentNumber; i++)
                {
                    sum1 = sum1 + numbers[i];
                }
                for (int i = currentNumber + 1; i < numbers.Length; i++)
                {
                    sum2 = sum2 + numbers[i];
                }
                if (sum1 == sum2)
                {
                    saveIndex = currentNumber;
                }
            }

            if (saveIndex >= 0)
            {
                Console.WriteLine(saveIndex);
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
