using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ', ',', ';', ':', '.', '!', '(', ')', '\'', '\"', '\\', '/', '[', ']').Where(p => p != "")
                .ToList();
            List<string> lower = new List<string>();
            List<string> mixed = new List<string>();
            List<string> upper = new List<string>();

            foreach (string word in input)
            {
                int lowerBr = 0, upperBr = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] >= 65 && word[i] <= 90)
                    {
                        upperBr++;
                    }
                    if (word[i] >= 97 && word[i] <= 122)
                    {
                        lowerBr++;
                    }
                }

                if (lowerBr == word.Length)
                {
                    lower.Add(word);
                }
                else if (upperBr == word.Length)
                {
                    upper.Add(word);
                }
                else
                {
                    mixed.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", String.Join(", ", lower));
            Console.WriteLine("Mixed-case: {0}", String.Join(", ", mixed));
            Console.WriteLine("Upper-case: {0}", String.Join(", ", upper));
        }
    }
}
