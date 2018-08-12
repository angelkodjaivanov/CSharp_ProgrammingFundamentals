using System;

namespace CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            ulong diff = ulong.MaxValue;
            long saveNum = 0;

            //int.MaxValue - number >= 0;
            //number <= int.MaxValue;


            switch (type)
            {
                case "sbyte":
                    for (int i = 1; i <= n; i++)
                    {
                        long number = long.Parse(Console.ReadLine());
                        if (sbyte.MaxValue - number >= 0 && number >= sbyte.MinValue && (ulong)sbyte.MaxValue - (ulong)number <= diff)
                        {
                            diff = (ulong)sbyte.MaxValue - (ulong)number;
                            saveNum = number;
                        }
                    }
                    break;
                case "int":
                    for (int i = 1; i <= n; i++)
                    {
                        long number = long.Parse(Console.ReadLine());
                        if (int.MaxValue - number >= 0 && number >= int.MinValue && (ulong)int.MaxValue - (ulong)number <= diff)
                        {
                            diff = (ulong)int.MaxValue - (ulong)number;
                            saveNum = number;
                        }
                    }
                    break;
                case "long":
                    for (int i = 1; i <= n; i++)
                    {
                        long number = long.Parse(Console.ReadLine());
                        if (number <= long.MaxValue && number >= long.MinValue && (ulong)long.MaxValue - (ulong)number <= diff)
                        {
                            diff = (ulong)long.MaxValue - (ulong)number;
                            saveNum = number;
                        }
                    }
                    break;
            }
            double num = 0;

            if ( saveNum < 0)
            {
                num = sbyte.MinValue;
            }
            else
            {
                num = sbyte.MaxValue;
            }
            double years = Math.Ceiling(saveNum / num);
            Console.WriteLine("Prisoner with id {0} is sentenced to {1} {2}", saveNum, years, years > 1 ? "years":"year");

        }
    }
}