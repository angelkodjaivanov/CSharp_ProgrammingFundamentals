using System;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            long num = (long)(number);

            if (Math.Ceiling(Math.Abs(num * 1.0)) == Math.Ceiling(Math.Abs(number)))
            {
                if (number >= sbyte.MinValue && number <= byte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (number >= int.MinValue && number <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (number >= long.MinValue && number <= long.MaxValue)
                {
                    Console.WriteLine("Windy");
                }
            }
            else
            {
                Console.WriteLine("Rainy");
            }

        }
    }
}