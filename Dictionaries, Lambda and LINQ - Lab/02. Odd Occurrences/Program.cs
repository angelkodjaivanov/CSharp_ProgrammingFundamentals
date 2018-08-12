using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().ToLower().Split(' ').ToList();
            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var num in input)
                words[num] = 0;

            foreach (var num in input)
                words[num]++;

            string result = "";
            foreach(var word in words.Keys)
            {
                if (words[word] % 2 == 1)
                {
                    result += word + ", "; 
                }
            }

            result = result.Remove(result.Length - 2, 2);
            Console.WriteLine(result);

        }
    }
}
