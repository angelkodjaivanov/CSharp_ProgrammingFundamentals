using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Intersection_of_Circles
{
   
    class Program
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        class Circle
        {
            public Point Center { get; set; }
            public int Radius { get; set; }
        }

        static void Main(string[] args)
        {
            int[] circle1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] circle2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point pointForCircle1 = new Point();
            pointForCircle1.X = circle1[0];
            pointForCircle1.Y = circle1[1];
            Point pointForCircle2 = new Point();
            pointForCircle2.X = circle2[0];
            pointForCircle2.Y = circle2[1];

            Circle fCirlce = new Circle();
            fCirlce.Center = pointForCircle1;
            fCirlce.Radius = circle1[2];

            Circle sCirlce = new Circle();
            sCirlce.Center = pointForCircle2;
            sCirlce.Radius = circle2[2];


            if (Intersect(fCirlce, sCirlce))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        static bool Intersect(Circle firtsCircle, Circle secondCircle)
        {
            bool isIntersect = false;
            double centerToCenterDistance = Math.Sqrt((firtsCircle.Center.X - secondCircle.Center.X) * (firtsCircle.Center.X - secondCircle.Center.X)
                                                + (firtsCircle.Center.Y - secondCircle.Center.Y) * (firtsCircle.Center.Y - secondCircle.Center.Y));

            if (centerToCenterDistance <= firtsCircle.Radius + secondCircle.Radius)
            {
                isIntersect = true;
            }

            return isIntersect;

        }

    }
}
