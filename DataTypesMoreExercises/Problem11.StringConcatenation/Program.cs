using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11.StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string symb = Console.ReadLine();
            string linesToGet = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = "";

            if ( linesToGet == "odd" )
            {
                for ( int i = 1; i <= n; i++)
                {
                    string text = Console.ReadLine();
                    if ( i % 2 == 1)
                    {
                        result = result + text + symb;
                    }

                }
            }
            else if( linesToGet == "even" )
            {
                for (int i = 1; i <= n; i++)
                {
                    string text = Console.ReadLine();
                    if (i % 2 == 0)
                    {
                        result = result + text + symb;
                    }
                }
            }

            result = result.Remove(result.Length - 1, 1);

            Console.WriteLine(result);

        }
    }
}
