using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(',', ' ').Where(p => p != "").ToArray();
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new String('*', word.Length));
                }
            }

            Console.WriteLine(text);

        }
    }
}
