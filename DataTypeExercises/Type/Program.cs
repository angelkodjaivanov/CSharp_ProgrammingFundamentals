using System;

namespace Type
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            if (input >= 48 && input <= 57)
            {
                Console.WriteLine("digit");
            }
            else if ( input == 65 || input == 69 || input == 73 || input == 79 || input == 85 || input == 89
                || input == 97 || input == 101 || input ==105 || input == 111 || input ==117 || input ==121)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}