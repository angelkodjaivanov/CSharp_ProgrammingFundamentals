using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            StringBuilder result = new StringBuilder();
            string number = "";
            int startIndex = 0, endInex = 0;
            List<char> symbols = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                
                if (text[i] >= 48 && text[i] <= 57)
                {
                    string textForRepeat = "";
                    if ( i < text.Length - 1 && text[i + 1] >= 48 && text[i + 1] <= 57)
                    {
                        number = text[i] + "" + text[i + 1];
                    }
                    else
                    {
                        number = "" + text[i];
                    }
                    int numberAsInt = int.Parse(number);
                    for (int j = startIndex; j < i; j++)
                    {
                        if (symbols.Contains(text[j]) || numberAsInt == 0)
                        {

                        }
                        else
                        {
                            if ((text[j] >= '0' && text[j] <= '9'))
                            {

                            }
                            else
                            {
                                symbols.Add(text[j]);
                            }
                        }
                        if (text[j] >= 'a' && text[j] <= 'z')
                        {
                            textForRepeat += (char)(text[j] - 32);

                        }
                        else
                        {
                            textForRepeat += text[j];
                        }
                    }
                    for (int j = 0; j < numberAsInt; j++)
                    {
                        result.Append(textForRepeat);
                    }
                    startIndex = i + 1;
                }
            }

            Console.WriteLine("Unique symbols used: {0}", symbols.Count);
            Console.WriteLine(result);

        }
    }
}
