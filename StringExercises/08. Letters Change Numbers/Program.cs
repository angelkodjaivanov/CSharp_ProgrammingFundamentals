using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double result = 0, index = 1, number = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = strings[i].Length - 2; j > 0; j--)
                {
                    number += (strings[i][j] - 48) * index;
                    index *= 10;
                }
                index = 1;
                if (strings[i][0] >= 97  && strings[i][0] <= 122)
                {
                    number *= strings[i][0] - 96;
                }
                else
                {
                    number /= strings[i][0] - 64;
                }

                if (strings[i][strings[i].Length - 1] >= 97 && strings[i][strings[i].Length - 1] <= 122)
                {
                    number += strings[i][strings[i].Length - 1] - 96;
                }
                else
                {
                    number -= strings[i][strings[i].Length - 1] - 64;
                }

                result += number;
                number = 0;
            }

            Console.WriteLine($"{result:F2}");

        }
    }
}
