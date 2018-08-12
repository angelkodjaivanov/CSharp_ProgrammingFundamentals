using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathPow(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
        }

        static double MathPow(double number, double power)
        {
            double result = 1;

            for ( int i = 0; i < power; i++ )
            {
                result = result * number;
            }
            return result;
        }
    }
}
