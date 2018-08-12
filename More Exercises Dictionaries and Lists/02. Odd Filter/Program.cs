using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).Where(p => p % 2 == 0).ToList();

            int sum = 0;
            foreach (int num in input)
            {
                sum += num;
            }

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > sum * 1.0 / input.Count )
                {
                    input[i]++;
                }
                else
                {
                    input[i]--;
                }
            }

            Console.WriteLine(String.Join(" ", input));

        }
    }
}
