using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
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

            int saveIndex = 0, br = 0, maxBr = 0 ;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                       
                        br++;
                    }
                }
                if ( maxBr < br)
                {
                    maxBr = br;
                    saveIndex = i;
                }
                br = 0;
            }

            Console.WriteLine(numbers[saveIndex]);

        }
    }
}
