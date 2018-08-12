using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            char[] symb = new char[4];
            symb[0] = 'A';
            symb[1] = 'C';
            symb[2] = 'G';
            symb[3] = 'T';
            int br = 0;

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    for (int g = 0; g <= 3 ; g++)
                    {
                        br++;
                        if ( i + j + g + 3>= n)
                        {
                            Console.Write("O{0}{1}{2}O ",symb[i],symb[j],symb[g]);
                        }
                        else
                        {
                            Console.Write("X{0}{1}{2}X ", symb[i], symb[j], symb[g]);
                        }
                        if (br%4==0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }

        }
    }
}
