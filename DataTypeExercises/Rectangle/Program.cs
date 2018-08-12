using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine( 2 * width + 2 * height);
            Console.WriteLine(height* width);
            Console.WriteLine(Math.Sqrt(height* height + width * width));

        }
    }
}