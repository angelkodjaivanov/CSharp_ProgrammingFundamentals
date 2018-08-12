using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTheTriangle(int.Parse(Console.ReadLine()));
        }

        static void PrintTheTriangle(int n)
        {
            for ( int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
                Console.WriteLine();
            }

            for( int i = n - 1; i >= 1; i--)
            {
                PrintLine(1, i);
                Console.WriteLine();
            }

        }

        static void PrintLine(int start, int end)
        {
            for ( int i = start; i <= end; i++)
            {
                Console.Write(i  + " ");
            }
        }

    }
}
