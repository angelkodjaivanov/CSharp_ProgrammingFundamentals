using System;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            for (int number = 1; number <= numbers; number++)
            {
                int sum = 0;
                int saveNumber = number;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                bool theNumberWorks = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{saveNumber} -> {theNumberWorks}");
                number = saveNumber;
            }

        }
    }
}