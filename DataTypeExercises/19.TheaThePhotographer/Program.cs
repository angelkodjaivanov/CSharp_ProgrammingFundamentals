using System;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long pictures = long.Parse(Console.ReadLine());
            long secondForTotal = long.Parse(Console.ReadLine());
            long perc = long.Parse(Console.ReadLine());
            long secondsForFilt = long.Parse(Console.ReadLine());

            long AllSeconds = (long)(pictures * secondForTotal);
            long filtPictures = (long)(Math.Ceiling(pictures * 1.0  * perc / 100));
            AllSeconds = (long)(AllSeconds + filtPictures * secondsForFilt);

            long days = (long)(AllSeconds / 86400);
            long hours = (long)((AllSeconds - days * 86400) / 3600);
            long minutes = (long)((AllSeconds - days * 86400 - hours * 3600) / 60);
            long seconds = (long)(AllSeconds - days * 86400 - hours * 3600 - minutes * 60);

            Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", days, hours, minutes, seconds);

        }
    }
}