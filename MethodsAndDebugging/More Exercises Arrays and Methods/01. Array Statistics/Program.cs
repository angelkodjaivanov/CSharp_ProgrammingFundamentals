using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            int[] numbers = new int[nums.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(nums[i]);
            }

            int maxElement = numbers[0], minElement = numbers[0], sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(maxElement < numbers[i])
                {
                    maxElement = numbers[i];
                }
                if (minElement > numbers[i])
                {
                    minElement = numbers[i];
                }
                sum += numbers[i];
            }

            Console.WriteLine("Min = {0}", minElement);
            Console.WriteLine("Max = {0}", maxElement);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", sum * 1.0 / numbers.Length);

        }
    }
}
