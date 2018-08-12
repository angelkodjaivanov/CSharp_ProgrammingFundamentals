using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    class Program
    {

        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }

        static void Main(string[] args)
        {
            double[] firstPointProp = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] secondPointProp = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Point firstPoint = new Point{ X = firstPointProp[0], Y = firstPointProp[1]};
            Point secondPoint = new Point { X = secondPointProp[0], Y = secondPointProp[1] };

            Console.WriteLine($"{CalculateDistance(firstPoint, secondPoint):F3}");

        }

        static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            double distance = Math.Sqrt((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X)
                + (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y));

            return distance;
        }
        
    }
}
