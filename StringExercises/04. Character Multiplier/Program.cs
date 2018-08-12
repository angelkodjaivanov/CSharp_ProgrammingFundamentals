using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine().Split(' ');
            string text1 = texts[0], text2 = texts[1];

            long sum = 0;
            for (int i = 0; i < Math.Min(text1.Length, text2.Length); i++)
            {
                sum += text1[i] * text2[i]; 
            }

            if (text1.Length > text2.Length)
            {
                for (int i = text2.Length; i < text1.Length; i++)
                {
                    sum += text1[i];
                }
            }
            else
            {
                for (int i = text1.Length; i < text2.Length; i++)
                {
                    sum += text2[i];
                }
            }

            Console.WriteLine(sum);

        }
    }
}
