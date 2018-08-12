using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine(draw(" ", i - 1) + "x" + draw(" ", n - 2 * i) + "x" + draw(" ", i - 1));
            }

            Console.WriteLine(draw(" ", (n - 1) / 2) + "x" + draw(" ", (n - 1) / 2));

            for (int i = n / 2; i >= 1; i--)
            {
                Console.WriteLine(draw(" ", i - 1) + "x" + draw(" ", n - 2 * i) + "x" + draw(" ", i - 1));
            }

        }

        public static string draw( string symb, int count)
        {
            string output = "";

            for (int i = 0; i < count; i++)
            {
                output = output + symb;
            }

            return output;
        }

    }
}
