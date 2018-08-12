using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char dontPrint = char.Parse(Console.ReadLine());

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char g = start; g <= end; g++)
                    {
                        if ( i != dontPrint && j != dontPrint && g != dontPrint)
                        {
                            Console.Write("{0}{1}{2} ", i, j, g);
                        }
                    }
                }
            }

        }
    }
}
