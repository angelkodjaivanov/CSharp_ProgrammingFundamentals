using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] text = input.Split(' ');
            int rotates = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotates; i++)
            {
                string option = Console.ReadLine();
                if (option == "Distinct")
                {
                    text = Distinct(text);
                }
                else if(option == "Reverse")
                {
                    text = Reverse(text);
                }
                else
                {
                    string[] optionReplace = option.Split(' ');
                    int index = int.Parse(optionReplace[1]);
                    string textForReplace = optionReplace[2];
                    Replace(text, index, textForReplace);
                }
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
            text[index] = replaceText;
        }

    }
}
