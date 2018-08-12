using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
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
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

                points[i] = new Point { X = arr[0], Y = arr[1] };

            }

            Point[] result = FindClosestPoints(points);

            Console.WriteLine($"{Math.Sqrt((result[0].X - result[1].X) * (result[0].X - result[1].X) + (result[0].Y - result[1].Y) * (result[0].Y - result[1].Y)):F3}");

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("(" + result[i].X + ", " + result[i].Y + ")");
            }

        }

        static Point[] FindClosestPoints(Point[] points)
        {
            double maxDistance = Math.Sqrt((points[0].X - points[1].X) * (points[0].X - points[1].X)
                    + (points[0].Y - points[1].Y) * (points[0].Y - points[1].Y));
            int firtsIndex = 0, secondIndex = 1; ;

            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = Math.Sqrt((points[i].X - points[j].X) * (points[i].X - points[j].X)
                        + (points[i].Y - points[j].Y) * (points[i].Y - points[j].Y));

                    if (distance < maxDistance)
                    {
                        maxDistance = distance;
                        firtsIndex = i;
                        secondIndex = j;
                    }
                }

            }

            Point[] resultPoints = new Point[2];
            resultPoints[0] = new Point { X = points[firtsIndex].X, Y = points[firtsIndex].Y};
            resultPoints[1] = new Point { X = points[secondIndex].X, Y = points[secondIndex].Y };

            return resultPoints;

        }

    }
}
