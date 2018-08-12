using System;

namespace PracticeFloatingPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            int days = (int)(years * 365.2422);
            uint hours = (uint)(days * 24);
            long minutes = hours * 60;
            decimal seconds = minutes * 60;
            decimal milli = seconds * 1000;
            decimal micro = milli * 1000;
            decimal nano = micro * 1000;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = " +
                "{5} seconds = {6} milliseconds = {7} microseconds = " +
                "{8} nanoseconds", centuries, years, days, hours, minutes, seconds, milli, micro, nano);
        }
    }
}