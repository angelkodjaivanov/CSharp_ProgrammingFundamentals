using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string[] firstText = input1.Split(' ');
            string[] secondText = input2.Split(' ');
            string[] saveCommonWordsFromStart = new string[Math.Min(firstText.Length, secondText.Length)];
            string[] saveCommonWordsFromEnd = new string[Math.Min(firstText.Length, secondText.Length)];
            bool weHaveCommonWord = false;
            int starComWords = 0, endComWords = 0;

            for (int i = 0; i < Math.Min(firstText.Length, secondText.Length); i++ )
            {
                if (firstText[i] == secondText[i])
                {
                    saveCommonWordsFromStart[i] = firstText[i];
                    starComWords++;
                    weHaveCommonWord = true;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < Math.Min(firstText.Length, secondText.Length); i++)
            {
                if (firstText[firstText.Length - i - 1] == secondText[secondText.Length - i - 1])
                {
                    saveCommonWordsFromEnd[i] = firstText[firstText.Length - i - 1];
                    endComWords++;
                    weHaveCommonWord = true;
                }
                else
                {
                    break;
                }
            }

            saveCommonWordsFromEnd = saveCommonWordsFromEnd.Where(c => c != null).ToArray();
            saveCommonWordsFromEnd = saveCommonWordsFromEnd.Reverse().ToArray();

            if ( weHaveCommonWord == true )
            {
                if ( starComWords >= endComWords )
                {
                    string result = String.Join(" ", saveCommonWordsFromStart);
                    Console.Write("The largest common end is at the left: {0}", result);
                }
                else
                {
                    string result = String.Join(" ", saveCommonWordsFromEnd);
                    Console.Write("The largest common end is at the right: {0}", result);
                }
            }
            else
            {
                Console.WriteLine("No common words at the left and right");
            }

        }
    }
}
