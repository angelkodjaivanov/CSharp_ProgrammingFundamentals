using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            string[] nums = input.Split(' ');
            int[] numbers = new int[nums.Length];
            int[] numberSave = new int[nums.Length];
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++ )
            {
                numbers[i] = int.Parse(nums[i]);
                result[i] = 0;
            }


            for ( int rotations = 1; rotations <= k; rotations++)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    numberSave[i] = numbers[i];
                }

                numbers[0] = numbers[numbers.Length - 1];
                result[0] += numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    numbers[i] = numberSave[i - 1];
                    result[i] += numbers[i];
                }

            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("{0} ", result[i]);
            }

        }
    }
}
