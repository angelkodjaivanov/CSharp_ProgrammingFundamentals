using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FindFibbNumber(n));
        }

        static int FindFibbNumber(int n)
        {
            int num1 = 1;
            int num2 = 1;
            for ( int i = 2; i <= n; i++)
            {
                if ( i % 2 == 0)
                {
                    num1 = num1 + num2;
                }
                else
                {
                    num2 = num1 + num2;
                }
            }

            if (num1 >= num2 )
            {
                return num1;
            }
            return num2;
        }
    }
}
