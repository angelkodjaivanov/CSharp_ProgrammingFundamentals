using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minDigs = int.Parse(Console.ReadLine());
            string[] text = input.Split(' ');

            int br = 0;
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length == minDigs)
                {
                    br++;
                    Console.WriteLine("Adding {0}.", text[i]);
                    result =  result + text[i] + ", ";
                    if (br == 10)
                    {
                        break;
                    }
                }
                
            }

            Console.WriteLine("Made pizza with total of {0} ingredients.", br);
            result = result.Remove(result.Length - 2, 2) + ".";
            Console.WriteLine("The ingredients are: {0}", result);

        }
    }
}
