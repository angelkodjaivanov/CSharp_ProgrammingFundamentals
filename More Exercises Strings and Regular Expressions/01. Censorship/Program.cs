using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            if (text.Contains(word))
            {
                text = text.Replace(word, new String('*', word.Length));
            }

            Console.WriteLine(text);

        }
    }
}
