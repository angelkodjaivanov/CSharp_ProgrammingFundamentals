using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 0; i < n; i++)
            {
                char symb = char.Parse(Console.ReadLine());

                result = result + symb;

            }

            Console.WriteLine("The word is: " + result);

        }
    }
}
