using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = new string[n];

            for (int i = 0; i < nums.Length ; i++)
            {
                nums[nums.Length - i - 1] = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", nums));

        }
    }
}
