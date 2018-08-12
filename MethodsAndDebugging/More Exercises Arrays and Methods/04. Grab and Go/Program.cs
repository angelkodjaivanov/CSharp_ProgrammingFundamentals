using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long number = long.Parse(Console.ReadLine());
            string[] nums = input.Split(' ');
            long[] numbers = new long[nums.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = long.Parse(nums[i]);
            }

            int lastPosition = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    lastPosition = i;
                }
            }

            if (lastPosition >= 0)
            {
                long sum = 0;
                for (int i = 0; i < lastPosition; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }

        }
    }
}
