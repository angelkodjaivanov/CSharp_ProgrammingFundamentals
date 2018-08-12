using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (sum + liters <= 255)
                {
                    sum = sum + liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(sum);

        }
    }
}