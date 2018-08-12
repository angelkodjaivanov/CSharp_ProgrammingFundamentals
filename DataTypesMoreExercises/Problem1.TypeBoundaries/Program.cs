using System;

namespace Problem1.TypeBoundaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if ( input == "sbyte" )
            {
                Console.WriteLine(sbyte.MaxValue);
                Console.WriteLine(sbyte.MinValue);
            }
            else if (input == "byte" )
            {
                Console.WriteLine(byte.MaxValue);
                Console.WriteLine(byte.MinValue);
            }
            else if (input == "int" )
            {
                Console.WriteLine(int.MaxValue);
                Console.WriteLine(int.MinValue);
            }
            else if ( input == "uint" )
            {
                Console.WriteLine(uint.MaxValue);
                Console.WriteLine(uint.MinValue);
            }
            else if (input == "long" )
            {
                Console.WriteLine(long.MaxValue);
                Console.WriteLine(long.MinValue);
            }
        }
    }
}