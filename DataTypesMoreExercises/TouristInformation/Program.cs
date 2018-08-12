using System;

namespace TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());

            switch (type)
            {
                case "miles": Console.WriteLine("{0} {1} = {2:F2} kilometers", num, type, num * 1.6); break;
                case "inches": Console.WriteLine("{0} {1} = {2:F2} centimeters", num, type, num * 2.54); break;
                case "feet": Console.WriteLine("{0} {1} = {2:F2} centimeters", num, type, num * 30); break;
                case "yards": Console.WriteLine("{0} {1} = {2:F2} meters", num, type, num * 0.91); break;
                case "gallons": Console.WriteLine("{0} {1} = {2:F2} liters", num, type, num * 3.8); break;
            }

        }
    }
}

