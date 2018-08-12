using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Karate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    int strength = input[i + 1] - 48;
                    for (int j = 0; j < strength; j++)
                    {
                        if (input[i + 1] == '>')
                        {
                            strength += input[i + 2] - 48;
                            i++;
                            j++;
                            input = input.Remove(i + 1, 1);
                        }
                        input = input.Remove(i + 1 , 1);
                    }
                }
            }

            Console.WriteLine(input);

        }
    }
}
