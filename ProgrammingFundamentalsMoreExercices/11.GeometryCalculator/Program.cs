using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            FindGeometryArea(type);
        }

        static void FindGeometryArea(string type)
        {
            double result = 0;
            switch (type)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    result = side * height / 2;
                    break; 
                case "square":
                    double sideLength = double.Parse(Console.ReadLine());
                    result = sideLength * sideLength;
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());
                    result = width * h;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    result = Math.PI * radius * radius;
                    break;
            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}
