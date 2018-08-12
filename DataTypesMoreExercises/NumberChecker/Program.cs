using System;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());

            long num = (long)(input * 100);
            if (num % 100 == 0)
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
        
    }
}