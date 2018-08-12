using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b\+359 2 [0-9][0-9][0-9] [0-9][0-9][0-9][0-9]";
            string phones = Console.ReadLine();

            MatchCollection matchedPhones = Regex.Matches(phones, regex);

            var matched = matchedPhones.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(String.Join(", ", matched));

        }
    }
}
