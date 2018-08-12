using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Morse_Code_Upgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                int sum = 0, num = 2; ;
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (input[i][j] == '1')
                    {
                        sum += 5;
                    }
                    else
                    {
                        sum += 3;
                    }

                    if (j > 0 && input[i][j] == input[i][j - 1])
                    {
                        if (input[i][j] != num)
                        {
                            sum++;
                            num = input[i][j];
                        }
                        sum += 1;
                    }
                    else
                    {
                        num = 2;
                    }

                }
                result += (char)sum;
            }

            Console.WriteLine(result);

        }
    }
}
