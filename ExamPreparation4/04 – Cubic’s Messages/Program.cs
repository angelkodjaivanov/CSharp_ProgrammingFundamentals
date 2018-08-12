using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _04___Cubic_s_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int current = 1;
            string text = "", result = "";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Over!")
                {
                    break;
                }
                if (current % 2 == 1)
                {
                    text = input;
                }
                else
                {
                    int number = int.Parse(input);
                    string pattern =@"^(?<digitsBefore>[0-9]*)(?<text>[a-zA-Z]*)(?<digitsAfter>[^a-zA-Z]*)$";
                    Match match = Regex.Match(text, pattern);
                    if (match.Groups["text"].Value.Length == number)
                    {
                        string textForWork = match.Groups["text"].Value;
                        result += match.Groups["text"].Value + " == ";
                        for (int i = 0; i < match.Groups["digitsBefore"].Value.Length ; i++)
                        {
                            int currIndex = match.Groups["digitsBefore"].Value[i] - 48;
                            if (match.Groups["text"].Value.Length > currIndex
                                && match.Groups["digitsBefore"].Value[i] >= '0' && match.Groups["digitsBefore"].Value[i] <= '9')
                            {
                                result += match.Groups["text"].Value[currIndex];
                            }
                            else
                            {
                                result += " ";
                            }
                        }
                        for (int i = 0; i < match.Groups["digitsAfter"].Value.Length; i++)
                        {
                            int currIndex = match.Groups["digitsAfter"].Value[i] - 48;
                            if ((match.Groups["text"].Value.Length > currIndex)
                                && match.Groups["digitsAfter"].Value[i] >= '0' && match.Groups["digitsAfter"].Value[i] <= '9')
                            {
                                result += match.Groups["text"].Value[currIndex];
                            }
                            else
                            {
                                result += " ";
                            }
                        }
                        result += Environment.NewLine;
                    }
                }
                current++;
            }

            Console.WriteLine(result);
        }
    }
}
