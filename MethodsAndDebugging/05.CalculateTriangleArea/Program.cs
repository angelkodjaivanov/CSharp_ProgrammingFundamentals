using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetTriangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
        }

        static double GetTriangleArea(double height, double width)
        {
            return height * width / 2;
        }

    }
}
