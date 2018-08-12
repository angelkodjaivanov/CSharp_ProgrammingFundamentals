using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<char> symbs = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    numbers.Add(input[i] - 48);
                }
                else
                {
                    symbs.Add(input[i]);
                }
            }

            List<int> TakeNumbers = new List<int>();
            List<int> SkipNumbers = new List<int>();

            for (int i = 0; i < numbers.Count ; i++)
            {
                if (i % 2 ==0)
                {
                    TakeNumbers.Add(numbers[i]);
                }
                else
                {
                    SkipNumbers.Add(numbers[i]);
                }
            }

            string result = "";

            int index = 0;
            for (int i = 0; i < symbs.Count; i++)
            {
                TakeNumbers[index]--;
                if (TakeNumbers[index] >= 0)
                {
                    result += symbs[i];
                }
                else
                {
                    i += SkipNumbers[index] - 1;
                    index++;
                }
                if (index == TakeNumbers.Count)
                {
                    break;
                }
            }
            Console.WriteLine(result);

        }
    }
}
