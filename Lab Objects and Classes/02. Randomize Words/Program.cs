using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfWords = Console.ReadLine().Split(' ');
            Random rnd = new Random();

            for (int i = 0; i < arrayOfWords.Length; i++)
            {

                int newIndex = rnd.Next(0, arrayOfWords.Length - 1);
                string save = arrayOfWords[i];
                arrayOfWords[i] = arrayOfWords[newIndex];
                arrayOfWords[newIndex] = save;
            }

            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                Console.WriteLine(arrayOfWords[i]);
            }

        }
    }
}
