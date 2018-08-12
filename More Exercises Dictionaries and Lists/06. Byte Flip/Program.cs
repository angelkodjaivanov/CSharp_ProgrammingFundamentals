using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').Where(p => p.Length == 2).ToList();

            for (int i = 0; i < input.Count ; i++)
            {
                string change = input[i];
                string res = "";
                res += change[1] + "" + change[0];
                input[i] = res;
            }

            input.Reverse();

            foreach (string inp in input)
            {
                char symb = (char)Convert.ToInt32(inp, 16);
                Console.Write(symb);
            }

        }
    }
}
