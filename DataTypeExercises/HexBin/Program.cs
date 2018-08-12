using System;

namespace HexBin
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber= int.Parse(Console.ReadLine());
            for (int number = 2; number <= endNumber; number++)
            {
                bool isPrime = true;
                for (int devide = 2; devide <= Math.Sqrt(number); devide++)
                {
                    if (number % devide == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {isPrime}");
            }

        }
    }
}