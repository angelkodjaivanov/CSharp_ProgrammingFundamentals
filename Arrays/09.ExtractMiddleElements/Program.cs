using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] elements = input.Split(' ');

            if (elements.Length == 1)
            {
                Console.WriteLine("{ " + elements[0] + " }");
            }
            else if (elements.Length % 2 == 0)
            {
                Console.WriteLine("{ " + elements[elements.Length / 2 - 1] + ", " +  elements[elements.Length / 2]  + " }");
            }
            else
            {
                Console.WriteLine("{ " + elements[elements.Length / 2 - 1] + ", " + elements[elements.Length / 2]
                    + ", " + elements[elements.Length / 2 + 1] + " }");
            }

        }
    }
}
