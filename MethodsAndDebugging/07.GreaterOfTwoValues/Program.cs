using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if ( type == "int" )
            {
                Console.WriteLine(GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            }
            else if ( type == "char" )
            {
                Console.WriteLine(GetMax(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine())));
            }
            else if ( type == "string" )
            {
                Console.WriteLine(GetMax(Console.ReadLine(), Console.ReadLine()));
            }
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            int result = 0;
            if ( firstNumber >= secondNumber)
            {
                result = firstNumber;
            }
            else
            {
                result = secondNumber;
            }
            return result;
        }

        static char GetMax(char firstSymb, char secondSymb)
        {
            char symb;
            if (firstSymb >= secondSymb)
            {
                symb = firstSymb;
            }
            else
            {
                symb = secondSymb;
            }
            return symb;
        }

        static string GetMax(string firstString, string secondString)
        {
            string result;
            if (firstString.CompareTo(secondString) >= 0)
            {
                result = firstString;
            }
            else
            {
                result = secondString;
            }
            return result;
        }

    }
}
