using System;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float firstResult = (float)(meters  / (hours * 3600 + minutes * 60 + seconds) );
            float secondResult = (float)((meters / 1000) / ((hours * 3600 + minutes * 60 + seconds) / 3600) );
            float thirdResult = (float)((meters / 1609) / ((hours * 3600 + minutes * 60 + seconds) / 3600)  );

            Console.WriteLine(firstResult);
            Console.WriteLine(secondResult);
            Console.WriteLine(thirdResult);
        }
    }
}