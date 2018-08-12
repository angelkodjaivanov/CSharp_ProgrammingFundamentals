using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool remove = false;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                    if (input[i] >= 48 && input[i] <= 57 && remove)
                    {
                        if (i == 0 ||input[i - 1] < 48 || input[i - 1] > 57)
                        {
                            input = input.Replace(input[i], input[i + 1]);
                        }
                        else
                        {
                            input = input.Remove(i, 1);

                        }

                    }
                    else if(input[i] < 48 || input[i] > 57)
                    {
                        remove = true;
                    }
            }

            Console.WriteLine(input);

        }
    }
}
