using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
            List<string> words = Console.ReadLine().ToLower().Split(separators).ToList();

            var result = words.Where(p => p != "").Where(p => p.Length < 5).Distinct().OrderBy(p => p);
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
