using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string text1 = input[0], text2 = input[1];
            bool exchangeable = true;
            Dictionary<char, char> characters = new Dictionary<char,char>();

            for (int i = 0; i < Math.Min(text1.Length, text2.Length); i++)
            {
                if (characters.ContainsKey(text1[i]))
                {
                    if (text2[i] != characters[text1[i]])
                    {
                        exchangeable = false;
                    }
                }
                else if (characters.ContainsValue(text2[i]))
                {
                    exchangeable = false;
                }
                else
                {
                    characters[text1[i]] = text2[i];
                }
            }

            if (text1.Length > text2.Length)
            {
                for (int i = text2.Length; i < text1.Length; i++)
                {
                    if (!characters.ContainsKey(text1[i]))
                    {
                        exchangeable = false;
                    }                  
                }
            }
            else if(text2.Length > text1.Length)
            {
                for (int i = text1.Length; i < text2.Length; i++)
                {
                    if (!characters.ContainsValue(text2[i]))
                    {
                        exchangeable = false;
                    }
                }
            }

            if (exchangeable)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
