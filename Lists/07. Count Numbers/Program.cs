using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(p => p).ToList();
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                bool weHaveNum = false;
                foreach (int number in numbers.Keys)
                {
                    if (number == num)
                    {
                        weHaveNum = true;
                    }
                }
                if (weHaveNum)
                {
                    numbers[num]++;
                }
                else
                {
                    numbers[num] = 1;
                }
            }

            foreach (int number in numbers.Keys)
            {
                Console.WriteLine($"{number} -> {numbers[number]}");
            }

        }
    }
}
