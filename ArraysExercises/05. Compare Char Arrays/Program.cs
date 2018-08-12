using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string[] inp1 = input1.Split(' '), inp2 = input2.Split(' ');
            char[] firstSymbs = new char[inp1.Length], secondSymbs = new char[inp2.Length];
            bool isFirstSymb;
            if (firstSymbs.Length <= secondSymbs.Length)
            {
                isFirstSymb = true;
            }
            else
            {
                isFirstSymb = false;
            }

            for (int i = 0; i < Math.Max(firstSymbs.Length, secondSymbs.Length); i++)
            {
                if ( i < firstSymbs.Length )
                {
                    firstSymbs[i] = char.Parse(inp1[i]);
                }
                if (i < secondSymbs.Length)
                {
                    secondSymbs[i] = char.Parse(inp2[i]);
                }
            }


            for (int i = 0; i < Math.Min(firstSymbs.Length, secondSymbs.Length); i++)
            {
                if (firstSymbs.Length <= secondSymbs.Length)
                {
                    if (firstSymbs[i] > secondSymbs[i])
                    {
                        isFirstSymb = false;
                    }
                }
                else
                {
                    if (secondSymbs[i] > firstSymbs[i])
                    {
                        isFirstSymb = true;
                    }
                }
            }

            if (isFirstSymb)
            {
                for (int i = 0; i < firstSymbs.Length; i++)
                {
                    Console.Write(firstSymbs[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < secondSymbs.Length; i++)
                {
                    Console.Write(secondSymbs[i]);
                }
            }
            else
            {
                for (int i = 0; i < secondSymbs.Length; i++)
                {
                    Console.Write(secondSymbs[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < firstSymbs.Length; i++)
                {
                    Console.Write(firstSymbs[i]);
                }
            }

        }
    }
}
