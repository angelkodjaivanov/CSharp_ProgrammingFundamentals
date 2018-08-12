using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] text = input.Split(' ');
            string option = Console.ReadLine();
            while (option != "END")
            {
                if (option == "Distinct")
                {
                    text = Distinct(text);
                }
                else if (option == "Reverse")
                {
                    text = Reverse(text);
                }
                else
                {
                    string[] optionReplace = option.Split(' ');
                    if (optionReplace[0] == "Replace")
                    {
                        int index = int.Parse(optionReplace[1]);
                        string textForReplace = optionReplace[2];
                        Replace(text, index, textForReplace);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                option = Console.ReadLine();
            }

            string result = String.Join(", ", text);
            Console.WriteLine(result);
        }

        static string[] Reverse(string[] text)
        {
            text = text.Reverse().ToArray();
            return text;
        }

        static string[] Distinct(string[] text)
        {
            text = text.Distinct().ToArray();
            return text;
        }
        static void Replace(string[] text, int index, string replaceText)
        {
            try
            {
                text[index] = replaceText;
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
