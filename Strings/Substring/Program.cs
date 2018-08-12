using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            int count = 0, lastIndex = -1;
            while (true)
            {
                int index = text.IndexOf(word, lastIndex + 1);
                if (index != -1 )
                {
                    count++;
                    lastIndex = index;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);

        }
    }
}
