using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] elements = input.Split(' ');

            for ( int i = 0; i < elements.Length / 2; i++)
            {
                string saveOldValue = elements[i];
                elements[i] = elements[elements.Length - i - 1];
                elements[elements.Length - i - 1] = saveOldValue;
            }

            for ( int i = 0; i< elements.Length; i++ )
            {
                Console.Write(elements[i] + " ");
            }
        }
    }
}
