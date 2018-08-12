using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Math_A_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string text = Console.ReadLine();

            MatchCollection mathcedNames = Regex.Matches(text, regex);

            foreach (Match name in mathcedNames)
            {
                Console.Write(name.Value + " ");
            }

        }
    }
}
