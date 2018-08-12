using System;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (char i = (char)num1; i <= num2; i++)
            {
                Console.Write(i + " ");
            }

        }
    }
}